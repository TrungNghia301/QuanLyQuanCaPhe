using PresentLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DAO
{
    public class CoffeeTypeDAO
    {
        private static CoffeeTypeDAO instance;
        public static CoffeeTypeDAO Instance
        {
            get { if (instance == null) instance = new CoffeeTypeDAO(); return instance; }
            private set { CoffeeTypeDAO.instance = value; }
        }
        private CoffeeTypeDAO() { }
        public List<Coffee> LoadCoffeeList()
        {
            List<Coffee> coffeeList = new List<Coffee>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_Nuocuong");
            foreach (DataRow item in data.Rows)
            {
                Coffee tb = new Coffee(item);
                coffeeList.Add(tb);
            }
            return coffeeList;
        }
        public DataTable LoadDSNuocUong()
        {
            string query = "USP_GetCoffeeList";
            return DataProvider.Instance.ExecuteQuery(query, null);
        }
        public bool InsertNuocUong(string TENSP, int SOLUONG, DateTime NgayNhap, DateTime HANSD, int GIAMUA, int GIABAN, string HINHANH)
        {
            string query = "USP_InsertNuocUong @TENSP , @SOLUONG , @NGAYNHAP , @HANSD , @GIAMUA , @GIABAN , @HINHANH";

            object[] parameters = { TENSP, SOLUONG, NgayNhap, HANSD, GIAMUA, GIABAN, HINHANH };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public bool DeleteNuocUong( int id)
        {
            string query = "USP_DeleteNuocUong @id";

            object[] parameters = { id};
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public bool UpdateNuocUong(int id,string TENSP, int SOLUONG, DateTime NgayNhap, DateTime HANSD, int GIAMUA, int GIABAN, string HINHANH)
        {
            string query = "USP_UpdateNuocUong @Id , @TENSP , @SOLUONG , @NGAYNHAP , @HANSD , @GIAMUA , @GIABAN , @HINHANH";

            object[] parameters = {id, TENSP, SOLUONG, NgayNhap, HANSD, GIAMUA, GIABAN, HINHANH };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public DataTable LoadCoffeeByName(string TENSP)
        {
            string query = "USP_GetCoffeeSearch @TENSP";
            object[] parameters = { TENSP };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
   

    }
}
