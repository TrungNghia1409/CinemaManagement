using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_OTPXN
    {
        public DTO_OTPXN(string Username, string Email, string MaOTP, DateTime ThoiGianTao, string TrangThai)
        {
            this.Username = Username;
            this.Email = Email;
            this.MaOTP = MaOTP;
            this.ThoiGianTao = ThoiGianTao;
            this.TrangThai = TrangThai;
        }

        public DTO_OTPXN() { }

        public DTO_OTPXN(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Email = row["Email"].ToString();
            this.MaOTP = row["MaOTP"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
           
            this.ThoiGianTao = Convert.ToDateTime(row["ThoiGianTao"]);
            
        }


        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string maOTP;
        public string MaOTP
        {
            get { return maOTP; }
            set { maOTP = value; }
        }

        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private DateTime thoiGianTao;
        public DateTime ThoiGianTao
        {
            get { return thoiGianTao; }
            set { thoiGianTao = value; }
        }

        
    }
}
