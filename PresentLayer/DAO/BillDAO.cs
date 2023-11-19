using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public DataTable LoadDSBill()
        {
            string query = "USP_GetDSBill";
            return DataProvider.Instance.ExecuteQuery(query, null);

        }

        public DataTable LoadBillInforById(int MaHD)
        {
            string query = "USP_GetBillChiTiet @MaHD";
            object[] parameters = { MaHD };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable LoadBillFromTo(DateTime FromDate,DateTime ToDate)
        {
            string query = "USP_GetBillFromTo @FromDate , @ToDate";
            object[] parameters = { FromDate, ToDate };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public int CountBill(DateTime Start, DateTime End)
        {
            string query = "USP_CountBillInRange @StartDate , @EndDate";
            object[] parameters = { Start, End };
            int result = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return result;
        }
        public decimal SumTongTienBill(DateTime Start, DateTime End)
        {
            string query = "USP_SumTongTienBill @StartDate , @EndDate";
            object[] parameters = { Start, End };
            try
            {
                decimal totalAmount = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query, parameters));
                return totalAmount;
            }
            catch(Exception huy)
            {
                return 0;
            }
            
        }
        public decimal LoiNhuan(DateTime S,DateTime E)
        {
            string query = "USP_LoiNhuan @NgayBatDau , @NgayKetThuc";
            object[] parameters = { S, E };
            try
            {
                decimal totalAmount = Convert.ToDecimal(DataProvider.Instance.ExecuteScalar(query, parameters));
                return totalAmount;
            }
            catch (Exception huy)
            {
                return 0;
            }
        }
        public DataTable GetBillInRange(DateTime startDate, DateTime endDate)
        {
            string query = "USP_GetBillInRange @startDate , @endDate";
            object[] parameters = { startDate, endDate };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void CreateBill(out int maHD, string maNV)
        {
            maHD = 0;
            string query = "USP_CreateBill @MaNV , @MaHD OUTPUT";
            object[] parameters = { maNV, maHD };

            maHD = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
        }
        public bool DeleteBill(int maHD)
        {
            string query = "USP_DeleteBill @MaHD";

            object[] parameters = { maHD };
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
        // Cập nhật phương thức trong lớp DataProvider
        public void CreateBillChiTiet(int id, int maHD, int soLuong, out int thanhTien)
        {
            string query = "USP_CreateBillChiTiet  @ID , @MaHD , @SoLuong , @ThanhTien OUTPUT";
            object[] parameters = { id,maHD, soLuong, 0 };
            thanhTien = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
        }



    }
}
