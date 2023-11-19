using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DTO
{
    public class Coffee
    {
        public Coffee(int id, string name, int soluong, DateTime ngaynhap, DateTime hansd, float giaban, float giamua,string url)
        {
            this.Id = id;
            this.Name = name;
            this.Soluong = soluong;
            this.Ngaynhap = ngaynhap;
            this.Hansd = hansd;
            this.Giaban = giaban;
            this.Giamua = giamua;
            this.Url = url;
        }
        public Coffee(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["TENSP"].ToString();
            this.Soluong = (int)row["SOLUONG"];
            this.Ngaynhap = (DateTime)row["NGAYNHAP"];
            this.Hansd = (DateTime)row["HANSD"];
            this.Giamua = (int)row["GIAMUA"];
            this.Giaban = (int)row["GIABAN"];
            this.Url = row["HINHANH"].ToString();
        }
        private int id;
        private string name;
        private int soluong;
        private DateTime ngaynhap;
        private DateTime hansd;
        private float giaban;
        private float giamua;
        private string url;
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; }


        }

        public int Soluong { get => soluong; set => soluong = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public DateTime Hansd { get => hansd; set => hansd = value; }
        public float Giaban { get => giaban; set => giaban = value; }
        public float Giamua { get => giamua; set => giamua = value; }
        public string Url { get => url; set => url = value; }
    }
}
