using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave; // voice tự động
using System.Net; // voice tự động
using QRCoder;
using AForge.Video;
using AForge.Video.DirectShow; // thư viện truy xuất camera
using ZXing;
using OGC.DAO; // thư viện đọc mã QR

namespace OGC.Phim
{
    public partial class KiemTraHoaDonVe : Form
    {
        public KiemTraHoaDonVe()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection; // lưu thông tin các thiết bị video
        VideoCaptureDevice videoCaptureDevice;     // biến tương tác với các thiết bị video

        private void KiemTraHoaDonVe_Load(object sender, EventArgs e)
        {
            // lấy danh sách tất cả các thiết bị video đang kết nối với máy tính
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // thêm tên của mỗi thiết bị vào combobox
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbCamera.Items.Add(device.Name);
            }

            if (cbCamera.Items.Count > 0)
                cbCamera.SelectedIndex = 0; // chọn thiết bị đầu tiên
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (filterInfoCollection == null || filterInfoCollection.Count == 0)
            {
                MessageBox.Show("Không tìm thấy camera nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txbID.Invoke(new MethodInvoker(delegate ()
                {
                    txbID.Text = result.ToString();
                }));
            }
            ptbCamera.Image = bitmap;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void KiemTraHoaDonVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                ptbCamera.Image = null;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbID.Text.Trim(), out int id))
            {
                MessageBox.Show("ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tồn tại vé phim
            if (!DAO_CTHD_VE.Instance.KiemTraTonTaiID(id))
            {
                MessageBox.Show("❌ Mã QR không tồn tại hoặc đã bị thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = DAO_CTHD_VE.Instance.LayTrangThaiTheoID(id);

            if (trangThai == "Đã in")
            {
                MessageBox.Show("Vé phim không hợp lệ!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể phát tiếng nếu muốn
                //PhatTiengNoiTuGoogle("Vé phim không hợp lệ");
            }
            else
            {
                //PhatTiengNoiTuGoogle("Vé phim chính xác.");
                //frmChiTietHoaDonVePhim f = new frmChiTietHoaDonVePhim(id);
                //f.ShowDialog();
            }
        }

        private void PhatTiengNoiTuGoogle(string noiDung)
        {
            using (var webClient = new WebClient())
            {
                string url = "https://translate.google.com/translate_tts?ie=UTF-8&q=" +
                             Uri.EscapeDataString(noiDung) +
                             "&tl=vi&client=tw-ob";

                byte[] voiceData = webClient.DownloadData(url);

                using (var ms = new MemoryStream(voiceData))
                using (var mp3Reader = new Mp3FileReader(ms))
                using (var waveOut = new WaveOutEvent())
                {
                    waveOut.Init(mp3Reader);
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
