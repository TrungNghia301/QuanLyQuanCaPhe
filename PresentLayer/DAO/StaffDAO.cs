using PresentLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { StaffDAO.instance = value; }
        }
        private StaffDAO() { }
        public DataTable LoadStaffList()
        {
            string query = "USP_GetStaffList";
            return DataProvider.Instance.ExecuteQuery(query, null);

        }
        public bool InsertStaff(string id, string tenNV, string diaChi, string sodienthoai, string email, int luong, string username)
        {
            string query = "USP_InsertStaff @id , @tenNV , @diaChi , @soDienThoai , @email , @luong , @username";

            object[] parameters = { id, tenNV, diaChi, sodienthoai, email, luong, username };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public bool DeleteStaff(string id)
        {
            string query = "USP_DeleteStaff @id";

            object[] parameters = { id };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public bool UpdateStaff(string id, string tenNV, string diaChi, string sodienthoai, string email, int luong, string username)
        {
            string query = "USP_UpdateStaff @id , @tenNV , @diaChi , @soDienThoai , @email , @luong , @username";

            object[] parameters = { id, tenNV, diaChi, sodienthoai, email, luong, username };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        public DataTable LoadStaffListByName(string tenNhanVien)
        {
            string query = "USP_GetStaffListByName @tenNhanVien";
            object[] parameters = { tenNhanVien };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
      


    }
}
