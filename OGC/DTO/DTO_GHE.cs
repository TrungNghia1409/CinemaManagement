using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGC.DTO
{
    public class GheDTO
    {
        public int ID { get; set; }
        public int IDPhong { get; set; }
        public string MaGhe { get; set; }
        public int TrangThai { get; set; } // 0: trống, 1: đã đặt

        public GheDTO() { }

        public GheDTO(int id, int idPhong, string maGhe, int trangThai)
        {
            this.ID = id;
            this.IDPhong = idPhong;
            this.MaGhe = maGhe;
            this.TrangThai = trangThai;
        }
    }
}

