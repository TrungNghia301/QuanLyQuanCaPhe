using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }

        }
        private AccountDAO() { }
        
        public bool Login (string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
     
        public bool InsertAccount(string userName ,string passWord ,int type)
        {
            string query = "USP_CreateAccount @userName , @passWord , @type";
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, passWord, type });
            return rowsAffected > 0;
        }
        public int GetUserType(string userName)
        {
            string query = "SELECT type FROM Account WHERE username = @userName";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName });

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return -1; // Trả về một giá trị không hợp lệ nếu không tìm thấy userType
        }
        public string GetTenNhanvien(string userName)
        {
            try
            {

                string query = "SELECT tenNV FROM NhanVien WHERE username = @userName";
                object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
                return result.ToString();
            }
            catch(Exception ed)
            {
                return ed.ToString();
                    MessageBox.Show(ed.ToString());
            }
          
        }
        public string GetIdNhanvien(string userName)
        {
            string query = "SELECT id FROM NhanVien Where username = @userName";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName});
            return result.ToString();

        }
        public DataTable LoadDSAccount()
        {
            string query = "SELECT * FROM Account";
            return DataProvider.Instance.ExecuteQuery(query, null);
        }
        public bool DeleteAccount(string userName)
        {
            string query = "USP_DeleteAccount @username";

            object[] parameters = { userName };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
    }
}
