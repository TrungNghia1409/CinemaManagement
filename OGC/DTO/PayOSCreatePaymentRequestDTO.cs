using System;
using System.Collections.Generic;

namespace OGC.DTO
{
    public class PayOSCreatePaymentRequestDTO
    {
        /// <summary>
        /// Mã đơn hàng, phải là số nguyên duy nhất trong hệ thống.
        /// </summary>
        public int orderCode { get; set; }

        /// <summary>
        /// Số tiền thanh toán (VND), phải lớn hơn 0.
        /// </summary>
        public long amount { get; set; }

        /// <summary>
        /// Mô tả đơn hàng.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Danh sách sản phẩm trong đơn hàng.
        /// </summary>
        public List<Item> items { get; set; }

        /// <summary>
        /// URL chuyển hướng khi thanh toán thành công (tùy chọn).
        /// </summary>
        public string returnUrl { get; set; }

        /// <summary>
        /// URL chuyển hướng khi hủy thanh toán (tùy chọn).
        /// </summary>
        public string cancelUrl { get; set; }

        /// <summary>
        /// Thời gian hết hạn của link thanh toán (Unix timestamp, giây, tùy chọn).
        /// </summary>
        public int expiredAt { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// Tên sản phẩm.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Số lượng, phải lớn hơn 0.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Giá sản phẩm (VND), phải lớn hơn hoặc bằng 0.
        /// </summary>
        public long price { get; set; }
    }
}