using OGC.Log_NhanVien;

namespace OGC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string username = "admin"; // Giả sử bạn đã đăng nhập với tài khoản quản lý
            Application.Run(new frmMain(username));
        }
    }
}