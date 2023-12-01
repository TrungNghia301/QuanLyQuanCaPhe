using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentLayer.DAO
{
    public class SalaryDAO
    {
        private static SalaryDAO instance;
        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return SalaryDAO.instance; }
            private set { SalaryDAO.instance = value; }

        }
        private SalaryDAO() { }

        public DataTable GetAllSalaryTable()
        {
            string query = "USP_GetAllSalaryTable";
            return DataProvider.Instance.ExecuteQuery(query,null);
        }
        public bool UpdateWorkTime(string maNV, float workTime)
        {
            string query = "USP_UpdateTotalSalaryByMaNV @MaNV , @TotalTimeWork";
            object[] parameters = { maNV, workTime };
            int rowAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowAffected > 0;
        }
        public bool ResetSalaryToZero(string maNV)
        {
            string query = "USP_ResetSalaryAndTimeByMaNV @MaNV";
            object[] parameters = {maNV};
            int rowAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return rowAffected > 0;
        }

    }
}
