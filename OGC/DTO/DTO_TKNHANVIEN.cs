using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class DTO_TKNHANVIEN
    {
        public DTO_TKNHANVIEN(string Username, string Password, string TrangThai)
        {
            this.Username = Username;
            this.Password = Password;
            this.TrangThai = Password;
        }
        public DTO_TKNHANVIEN() { }

        public DTO_TKNHANVIEN(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
