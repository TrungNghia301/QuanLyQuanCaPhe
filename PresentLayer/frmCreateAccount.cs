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
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentLayer
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            LoadDSTaiKhoan();
          
        }

      
        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddAccount(string userName, string passWord, int type)
        {
        
            if (AccountDAO.Instance.InsertAccount(userName, passWord, type))
            {
                MessageBox.Show("Đăng ký thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else 
            {
                
                MessageBox.Show("Tài khoản đã tồn tại!","Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
             
            }
        
        }
    
        private void btnDangKy_Click(object sender, EventArgs e)
        {
         
                string userName = txtUserName.Text;
                string password = textBox2.Text;/* Lấy giá trị từ TextBox password */;
                int type1 = Convert.ToInt32(cbType.SelectedItem);
                int type = type1;
            if (txtUserName.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }
            AddAccount(userName, password, type);
            


        }
        private void LoadDSTaiKhoan()
        {
            dgvAccount.DataSource = AccountDAO.Instance.LoadDSAccount();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAccount.Rows.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvAccount.Rows[e.RowIndex];
                txtTaiKhoan.Text = row.Cells["username"].Value.ToString(); 
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string Username = txtTaiKhoan.Text;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản " + Username + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Username != "")
                {
                    if (AccountDAO.Instance.DeleteAccount(Username))
                    {
                        MessageBox.Show("Đã xóa tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSTaiKhoan();
                        ClearValueTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản bạn thuộc sở hữu của nhân viên vui lòng xóa nhân viên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng tài khoản muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        void ClearValueTextBox()
        {
            txtTaiKhoan.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tpAccountManagement")
            {
                LoadDSTaiKhoan();
            }
        }
    }
}
