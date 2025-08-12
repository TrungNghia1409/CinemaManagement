using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave; //voice tự động
using System.Net; //voice tự động
using QRCoder;
using AForge.Video;
using AForge.Video.DirectShow; //thu vien truy xuat cam
using ZXing;
using OGC.DAO; //thu vien doc ma QR


namespace OGC.QuanLyDichVu
{
    public partial class frmKiemTraHoaDon : Form
    {
        public frmKiemTraHoaDon()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection; //luu thong tin cac thiet bi video
        VideoCaptureDevice videoCaptureDevice; //biet tuong tac voi cac thiet bi video

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            //khoi tao thiet vi video dau trn thiet bi chon tu combobox
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);

            //dang ky nhan su kien frame moi tu camera
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //nhan frame hinh anh tu camera
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txbID.Invoke(new MethodInvoker(delegate ()
                {
                    txbID.Text = result.ToString(); //hien thi ket qua doc duoc, gan len txb 
                }
                ));

            }
            ptbCamera.Image = bitmap; // hien thi frame hinh anh len picturebox

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop(); // không gọi Stop()
                videoCaptureDevice.WaitForStop();  // chờ dừng lại
                ptbCamera.Image = null;
            }
        }

        private void frmKiemTraHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop(); // không gọi Stop()
                videoCaptureDevice.WaitForStop();  // chờ dừng lại
                ptbCamera.Image = null;
            }
        }

        private void frmKiemTraHoaDon_Load(object sender, EventArgs e)
        {
            //lay danh sach tat ca cac thiet bi video dang duoc ket noi voi may tinh
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //them ten cua moi thiet bi vao combobox
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbCamera.Items.Add(device.Name);
                cbCamera.SelectedIndex = 0; // chon thiet bi dau tien trong danh sach
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbID.Text.Trim(), out int id))
            {
                MessageBox.Show("ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DAO_CTHD_MONAN.Instance.KiemTraTonTaiID(id))
            {
                MessageBox.Show("❌ Mã QR không tồn tại hoặc đã bị thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = DAO_CTHD_MONAN.Instance.LayTrangThaiTheoID(id);

            if (trangThai == "Đã in")
            {
                // Đọc thành tiếng với số tiền thực tế
                string textToSpeak = $"Khứa này gian lận.";
                PhatTiengNoiTuGoogle(textToSpeak); // 👈 Phát tiếng Việt động 
            }
            else // NULL hoặc khác "Đã in"
            {
                // Đọc thành tiếng với số tiền thực tế
                string textToSpeak = $"Hóa đơn chính xác.";
                PhatTiengNoiTuGoogle(textToSpeak); // 👈 Phát tiếng Việt động 
                frmChiTietHoaDonMonAn_TrucTuyen f = new frmChiTietHoaDonMonAn_TrucTuyen(id);
                f.ShowDialog();
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
