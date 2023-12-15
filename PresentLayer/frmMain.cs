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
        private bool isVisible;
        private Timer timer;
        public frmMain()
        {
            LoadMenuAsync();
            InitializeComponent();
            CheckStartTime();
            InitializeBlinkingLabel();
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


        //KhoaTacVuQUanLy
        public void BlockTabAdmin()
        {
            button3.Visible = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Text = "";
            btnLuong.Visible = false;
            btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuong.Text = "";
            btnLuong.FlatAppearance.BorderSize= 0;


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
                logoutClicked = true;

                CalculateWorkTime = (float)(end - DateTime.Parse(StartTime)).TotalHours;
                SalaryDAO.Instance.UpdateWorkTime(idNV, CalculateWorkTime);
                Console.WriteLine(CalculateWorkTime.ToString());
                    // Đóng frmMain
                this.Close();
            }
            else if (cc == DialogResult.No)
            {
        
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

          
         private void pnADc_MouseClick(object sender, MouseEventArgs e)
        {
            pnADc.Visible = false;
        }
        private bool logoutClicked = false;


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logoutClicked)
            {
                DialogResult cc = MessageBox.Show(
                "Xác nhận thoát khỏi hệ thống?",
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
                }
                else if (cc == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
      
        }

        private void pbHello_MouseClick(object sender, MouseEventArgs e)
        {
            pbHello.Visible = false;
            pnADc.Visible = false;
        }
        private void InitializeBlinkingLabel()
        {
            // Bắt đầu nhấp nháy khi form được hiển thị
            Shown += (sender, e) => StartBlinking();
        }

        private void StartBlinking()
        {
            // Sử dụng Timer để thay đổi trạng thái nhấp nháy mỗi 500ms
            timer = new Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            lbpass.Visible = isVisible;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Dừng Timer khi form đóng
            timer.Stop();
            base.OnFormClosing(e);
        }
      
    }
}
