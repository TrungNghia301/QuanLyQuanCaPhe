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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        #region nonContact
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
        #endregion
     
        //Phương thức xóa kí tự TextBox
        public void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        bool Login(string userName, string passWord) 
        { 

            return AccountDAO.Instance.Login(userName,passWord); 
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = textBox1.Text;
            string passWord = textBox2.Text;
            if (Login(userName, passWord))
            {
                frmLogin frmLogin = new frmLogin();
                string tenNV = AccountDAO.Instance.GetTenNhanvien(userName);
                string id = AccountDAO.Instance.GetIdNhanvien(userName);
                int userType = AccountDAO.Instance.GetUserType(userName);
                if (userType == 0)
                {

                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.HienthiNhanVien(tenNV);
                    frm.HienthiIdNhanVien(id);
                    frm.SetLoginForm(this); // SetLoginForm là một phương thức trong frmMain để lưu tham chiếu
                    frm.Show();
                }
                else
                {
                    this.Hide(); 
                    frmMain frm = new frmMain();
                    frm.HienthiNhanVien(tenNV);
                    frm.HienthiIdNhanVien(id);
                    frm.BlockTabAdmin();
                    frm.SetLoginForm(this); // SetLoginForm là một phương thức trong frmMain để lưu tham chiếu
                    frm.Show();
                }    
            }
           else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}
