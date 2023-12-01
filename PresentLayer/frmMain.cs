using PresentLayer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer
{
    public partial class frmMain : Form
    {
        private frmHome homeform;
        private frmLogin loginForm;
        private frmManage manageform;
        private frmBill billform;
        private frmLuong luongform;
        private static string startTime;
        public string endTime { get; set; }
      
        private static float calculateWorkTime;
        private static string idNV;
        public static string IdNV { get => idNV; set => idNV = value; }
        public static float CalculateWorkTime { get => calculateWorkTime; set => calculateWorkTime = value; }
        public static string StartTime { get => startTime; set => startTime = value; }

        public frmMain()
        {
            LoadMenuAsync();
            InitializeComponent();
            CheckStartTime();
         
        }
        public void CheckStartTime()
        {
            StartTime = DateTime.Now.ToString();
            Console.WriteLine(StartTime);
        }

        private async void LoadMenuAsync()
        {
            await Task.Delay(15000);
            pnADc.Visible = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //KhoaTacVuQUanLy
        public void BlockTabAdmin()
        {
            button3.Visible = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Text = "";
            
        }

        //Hiển thị tên nhân viên trực ca
        public void HienthiNhanVien(string name) 
        { 
            lblTenNhanVienTrucCa.Text = name;
   
        }
        //Hiển thị id trực ca
        public void HienthiIdNhanVien(string id)
        {
            lblMaNhanVienTrucCa.Text = id;
            idNV = lblMaNhanVienTrucCa.Text;
            Console.WriteLine(idNV);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //Hàm kiểm tra có form nào tồn tại hay không
        private bool IsFormVisible(Form form)
        {
            return form != null && !form.IsDisposed && form.Visible;
        }
        private bool homeFormHidden = false;

        private void OpenChildForm(Form childForm)
        {
           
            if (this.ActiveMdiChild != null && IsFormVisible(this.ActiveMdiChild))
            {
                
                if (this.ActiveMdiChild is frmHome)
                {
                    this.ActiveMdiChild.Hide();
                }
                else
                {
                    
                    this.ActiveMdiChild.Close();
                }
            }
        }
    
        //Button Trang chủ
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(homeform);
            if (homeform == null || homeform.IsDisposed)
            {
                homeform = new frmHome();
                homeform.LaytenThuNgan(lblTenNhanVienTrucCa.Text);
                homeform.LayIdthuNgan(lblMaNhanVienTrucCa.Text);
                homeform.MdiParent = this;
                homeform.Show();
            }
            else
            {
                homeform.Show();
            }
            pictureBoxlogo.Dispose();
        }
        private void btnLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(luongform);
            if(luongform == null || luongform.IsDisposed)
            {
                luongform =  new frmLuong();
                luongform.MdiParent = this;
                luongform.Show();
            }
            pictureBoxlogo.Dispose();
        }

        //Button mở Tác vụ quản lý
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(manageform);
            if (manageform == null || manageform.IsDisposed)
            {
                manageform = new frmManage();
                manageform.MdiParent = this;
                manageform.Show();
            }
            pictureBoxlogo.Dispose();
        }
        //Button mở Lịch sử bán
        public void button4_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(billform);
            if (button3.Text == "")
            {
                billform = new frmBill();
                billform.XoaBill();
                billform.MdiParent = this;
                billform.Show();
            }
            else
            {
                billform = new frmBill();
                billform.MdiParent = this;
                billform.Show();
            }
            pictureBoxlogo.Dispose();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        //Set function from LoginForm
        public void SetLoginForm(frmLogin form)
        {
            loginForm = form;
        }
        public void SetLogin(frmLogin textBox1)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
                "Xác nhận đăng xuất khỏi hệ thống?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            
            if (cc == DialogResult.Yes)
            {
                Console.WriteLine(StartTime);
                endTime = DateTime.Now.ToString();
                DateTime end = DateTime.Parse(endTime);
                Console.WriteLine(end.ToString());
                // Xóa ký tự trong TextBox khi nhấn btnLogout
                if (loginForm != null)
                {
                    loginForm.ClearTextBoxes();
                }
                if (loginForm == null || loginForm.IsDisposed)
                {
                    loginForm = new frmLogin();
                    loginForm.Show();
                }
                else
                {
                    loginForm.Show();
                }
                CalculateWorkTime = (float)(end - DateTime.Parse(StartTime)).TotalHours;
                SalaryDAO.Instance.UpdateWorkTime(idNV, CalculateWorkTime);
                Console.WriteLine(CalculateWorkTime.ToString());
                    // Đóng frmMain
                this.Close();
            }
            else if (cc == DialogResult.No) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

   
        
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void pnADc_MouseClick(object sender, MouseEventArgs e)
        {
            pnADc.Visible = false;
        }
    }
}
