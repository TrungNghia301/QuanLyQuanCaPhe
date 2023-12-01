using PresentLayer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer
{
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
            LoadAllSalary();
        }
        void LoadAllSalary()
        {
            dgvSalary.DataSource = SalaryDAO.Instance.GetAllSalaryTable();
        }
        void GetTimeWork(string MaNV, float TotalTime)
        {
            
        }
        
        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.RowIndex < dgvSalary.Rows.Count)
                {
                    DataGridViewRow row = dgvSalary.Rows[e.RowIndex];
                    txtidNV.Text = row.Cells["MaNV"].Value.ToString();
                    txtTenNV.Text = row.Cells["tenNV"].Value.ToString();
                    txtLuong.Text = row.Cells["Luong"].Value.ToString();
                    txtTotalSalary.Text = row.Cells["TotalSalary"].Value.ToString();
                    txtTotalTime.Text = row.Cells["TotalTimeWork"].Value.ToString();
            }
            }
        
        private void btnResetSalary_Click(object sender, EventArgs e)
        {
            string maNV = frmMain.IdNV;
            DateTime end = DateTime.Now;
            float TimeWork = (float)(end - DateTime.Parse(frmMain.StartTime)).TotalHours; ;
            Console.WriteLine(maNV +","+ TimeWork);
            SalaryDAO.Instance.UpdateWorkTime(maNV,TimeWork);
            LoadAllSalary();
            frmMain.StartTime = DateTime.Now.ToString();
            txtidNV.Text = "";
            txtLuong.Text = "";
            txtTenNV.Text = "";
            txtTotalSalary.Text = "";
            txtTotalTime.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thanh toán lương " + txtTenNV.Text + " không?", "Xác nhận lương", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string maNV = txtidNV.Text;
            if (result == DialogResult.Yes)
            {
                if (SalaryDAO.Instance.ResetSalaryToZero(maNV))
                {
                    MessageBox.Show("Đã trả lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllSalary();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên muốn thanh toán bảng bên dưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

 
        }
    }

}

