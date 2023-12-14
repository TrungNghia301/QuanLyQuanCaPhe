using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer.DAO
{
    public class DataProvider
    {
        //tạo patern singleton
        private static DataProvider instance; 
        private string connectionString = @"Data Source=.;Initial Catalog=JTCoffee;Integrated Security=True";

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider();return DataProvider.instance;}
            private set { DataProvider.instance = value; } 

        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (
            SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

                
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (
            SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    data = command.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show("Không thành công lỗi: " + ex.Message);
                    Console.WriteLine(ex.Message);
                }
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (
            SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }


            return data;
        }
        public DataTable LoadPieChartData(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataTable data = new DataTable();

            string query = "SELECT NU.TENSP, SUM(BC.SOLUONG) AS SOLUONG " +
                           "FROM NuocUong NU " +
                           "JOIN BillChiTiet BC ON NU.id = BC.ID " +
                           "JOIN Bill B ON BC.MaHD = B.MaHD " +
                           "WHERE B.NgayLap >= @NgayBatDau AND B.NgayLap < DATEADD(day, 1, @NgayKetThuc) " +
                           "GROUP BY NU.TENSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }





    }
}
