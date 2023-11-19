using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DTO
{
    public class Bill
    {
        public Bill(int maHD, DateTime ngayLap, string maNV, int tongTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaNV = maNV;
            TongTien = tongTien;
        }

        public Bill(DataRow row)
        {
            MaHD = (int)row["MaHD"];
            NgayLap = (DateTime)row["NgayLap"];
            MaNV = row["MaNV"].ToString();
            TongTien = (int)row["TongTien"];
        }

        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNV { get; set; }
        public int TongTien { get; set; }
    }
}
