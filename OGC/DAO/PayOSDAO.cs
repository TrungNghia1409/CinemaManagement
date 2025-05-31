using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OGC.DTO;

namespace OGC.DAO
{
    public class PayOSDAO
    {
        private readonly PayOS payOS;

        public PayOSDAO()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string clientId = configuration["PayOS:ClientId"] ?? throw new Exception("Cannot find Client ID");
            string apiKey = configuration["PayOS:ApiKey"] ?? throw new Exception("Cannot find API Key");
            string checksumKey = configuration["PayOS:ChecksumKey"] ?? throw new Exception("Cannot find Checksum Key");

            payOS = new PayOS(clientId, apiKey, checksumKey);
        }

        public async Task<string> CreatePayment(PayOSCreatePaymentRequestDTO requestDTO)
        {
            try
            {
                // Kiểm tra số tiền hợp lệ
                if (requestDTO.amount <= 0)
                    throw new Exception("Số tiền không hợp lệ");
                if (requestDTO.amount > int.MaxValue)
                    throw new Exception($"Số tiền vượt quá giới hạn cho phép ({int.MaxValue} VND)");

                // Tạo orderCode nếu chưa có
                if (requestDTO.orderCode == 0)
                {
                    requestDTO.orderCode = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() % int.MaxValue);
                }

                // Đặt thời gian hết hạn (30 phút sau)
                if (requestDTO.expiredAt == 0)
                {
                    requestDTO.expiredAt = (int)(DateTimeOffset.Now.AddMinutes(30).ToUnixTimeSeconds());
                }

                // Tạo danh sách sản phẩm nếu chưa có
                if (requestDTO.items == null || requestDTO.items.Count == 0)
                {
                    requestDTO.items = new List<Item>
                    {
                        new Item
                        {
                            name = requestDTO.description ?? "Dịch vụ",
                            quantity = 1,
                            price = requestDTO.amount
                        }
                    };
                }

                // Kiểm tra giá sản phẩm
                foreach (var item in requestDTO.items)
                {
                    if (item.price > int.MaxValue)
                        throw new Exception($"Giá sản phẩm '{item.name}' vượt quá giới hạn cho phép ({int.MaxValue} VND)");
                }

                // Chuyển đổi DTO sang PaymentData của payOS.Net5
                var items = requestDTO.items.Select(i => new ItemData(i.name, i.quantity, (int)i.price)).ToList();
                var paymentData = new PaymentData(
                    orderCode: requestDTO.orderCode,
                    amount: (int)requestDTO.amount,
                    description: requestDTO.description,
                    items: items,
                    cancelUrl: requestDTO.cancelUrl,
                    returnUrl: requestDTO.returnUrl,
                    buyerName: null, // Không có thông tin khách hàng
                    buyerEmail: null, // Không có thông tin khách hàng
                    buyerPhone: null, // Không có thông tin khách hàng
                    expiredAt: requestDTO.expiredAt
                );

                // Gọi API PayOS để tạo link thanh toán
                CreatePaymentResult result = await payOS.createPaymentLink(paymentData);
                return result.checkoutUrl;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo thanh toán: {ex.Message}", ex);
            }
        }
    }
}