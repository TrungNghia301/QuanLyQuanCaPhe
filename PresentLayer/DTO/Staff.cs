using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DTO
{
    public class Staff
    {
        public Staff(string id, string tenNV, string diachi,string sodienthoai, string email, int luong,string username, int type)
        {
            this.Id = id;
            this.TenNV = tenNV;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;
            this.Email = email;
            this.Username = username;
            this.Type = type;
        }
        public Staff(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenNV = row["tenNV"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sodienthoai = row["soDienThoai"].ToString();
            this.Email = row["email"].ToString();
            this.Luong = (int)row["luong"];
            this.Username = row["username"].ToString();
            this.Type = (int)row["type"];
        }
        private string id;
        private string tenNV, diachi,sodienthoai, email,username;
        private int luong, type;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public int Luong { get => luong; set => luong = value; }
        public int Type { get => type; set => type = value; }
        public string Id { get => id; set => id = value; }
    }
}

