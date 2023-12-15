using PresentLayer.DAO;
using PresentLayer.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentLayer
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
            LoadDanhSachKho();
            LoadDanhSachNhanVien();
            chartThongKe.MouseMove += chartThongKe_MouseMove;
            chartThongKe.MouseLeave += chartDoanhthu_MouseLeave;
            LoadThongKe();
        }
        private frmSuaHang FrmSuaHang;
        private frmCreateAccount FrmCreateAccount;
        private frmThemHang FrmThemHang;
        void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = StaffDAO.Instance.LoadStaffList();
        }
        void LoadDanhSachKho()
        {
             dataGridView2.DataSource = CoffeeTypeDAO.Instance.LoadDSNuocUong(); 

        }
        private void LoadStaffListByName(string tenNhanVien)
        {
            // Gọi phương thức trong DAO để lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = StaffDAO.Instance.LoadStaffListByName(tenNhanVien);

            // Hiển thị dữ liệu trong DataGridView dgvNhanVien
            dgvNhanVien.DataSource = dt;
        }
        private void LoadCoffeeByname(string TENSP)
        {
            DataTable dt = CoffeeTypeDAO.Instance.LoadCoffeeByName(TENSP);
            dataGridView2.DataSource = dt;
        }
        #region Test
        public bool AddNV (string id, string tenNV, string diaChi, string sodienthoai, string email, int luong, string username)
        {
            return StaffDAO.Instance.InsertStaff(id, tenNV, diaChi, sodienthoai, email, luong, username);
        }
        public bool UpdateNV (string id, string tenNV, string diaChi, string sodienthoai, string email, int luong, string username)
        {
            return StaffDAO.Instance.UpdateStaff(id, tenNV, diaChi, sodienthoai, email, luong, username);
        }
        public bool DeleteNV(string id)
        {
            return StaffDAO.Instance.DeleteStaff(id);
        }
        #endregion
        void AddStaff(string id, string TenNV, string DiaChi,string Sdt, string Email, int Luong, string Username)
        {
            if (StaffDAO.Instance.InsertStaff(id, TenNV, DiaChi, Sdt, Email, Luong, Username))
            {
                MessageBox.Show("Chào mừng nhân viên mới!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #region ChucNangTimKiem
        //Tìm kiếm

        private void txtTimNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
        private void txtTimNhanVien_Enter(object sender, EventArgs e)
        {
            if (txtTimNhanVien.Text == "Tìm theo tên nhân viên")
            {
                txtTimNhanVien.Text = "";
                txtTimNhanVien.ForeColor = Color.Black;
            }
        }

        private void txtTimNhanVien_Leave(object sender, EventArgs e)
        {
            if (txtTimNhanVien.Text == "")
            {
                txtTimNhanVien.Text = "Tìm theo tên nhân viên";
                txtTimNhanVien.ForeColor = Color.Silver;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        { // Lấy tên nhân viên từ TextBox txtTimNhanVien
            string tenNhanVien = txtTimNhanVien.Text.Trim();

            // Gọi phương thức để tải và hiển thị danh sách nhân viên theo tên
            LoadStaffListByName(tenNhanVien);
        }

        #endregion
        #region SuKienTuongtacBangNhanVien

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["id"].Value.ToString();
                txtTenNV.Text = row.Cells["tenNV"].Value.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
                txtSDT.Text = row.Cells["soDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                // Lấy giá trị từ cột "luong" của DataGridViewRow
                decimal luongFromRow = Convert.ToDecimal(row.Cells["luong"].Value);

                // Gán giá trị mới cho NumericUpDown
                nmLuong.Value = luongFromRow;
            }
        }
        #endregion
        #region ThemNhanVien
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( FrmCreateAccount == null || FrmCreateAccount.IsDisposed)
            {
                FrmCreateAccount = new frmCreateAccount();
                FrmCreateAccount.Show();
            }
        }

      

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox cảnh báo
            DialogResult result = MessageBox.Show("Hãy chắc chắn rằng bạn đã có tài khoản cho nhân viên với/hoặc thoát ra tạo tài khoản mới!",
                                                  "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (txtDiaChi.Text == null || txtEmail.Text == null || txtMaHang.Text == null || txtMaNV.Text == null || txtSDT.Text == null || nmLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (result == DialogResult.OK)
                {
                    string id = txtMaNV.Text;
                    string TenNV = txtTenNV.Text;
                    string DiaChi = txtDiaChi.Text;
                    string Sdt = txtSDT.Text;
                    string Email = txtEmail.Text;
                    int Luong = (int)nmLuong.Value;
                    string Username = txtUsername.Text;
                    AddStaff(id, TenNV, DiaChi, Sdt, Email, Luong, Username);
                }
            }
        }
        #endregion
        #region XoaNhanVien
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text;
            string id = txtMaNV.Text;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + tenNV + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (StaffDAO.Instance.DeleteStaff(id))
                {
                    MessageBox.Show("Đã xóa nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên muốn xóa dưới bảng bên dưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnXoa, "Xóa theo mã nhân viên bạn đã chọn!"); // Thay đổi nội dung theo ý muốn
        }
        #endregion
        #region SuaNhanVien
        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text;
            string TenNV = txtTenNV.Text;
            string DiaChi = txtDiaChi.Text;
            string Sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            int Luong = (int)nmLuong.Value;
            string Username = txtUsername.Text;

            if (StaffDAO.Instance.UpdateStaff(id, TenNV, DiaChi, Sdt, Email, Luong, Username))
            {
                MessageBox.Show("Đã cập nhật thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại kiểm tra lại các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtUsername.Text = "";
            nmLuong.Value = 0;
            LoadDanhSachNhanVien();
        }

        #endregion
        #region ChucNangTimHang
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtTimCoffee.Text == "Tìm theo tên coffee")
            {
                txtTimCoffee.Text = "";
                txtTimCoffee.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtTimCoffee.Text == "")
            {
                txtTimCoffee.Text = "Tìm theo tên coffee";
                txtTimCoffee.ForeColor = Color.Silver;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string TENSP = txtTimCoffee.Text;
            LoadCoffeeByname(TENSP);
        }

        private void txtTimCoffee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        #endregion
        #region SuaThongTinHang
        private void btnResetHang_Click(object sender, EventArgs e)
        {
            LoadDanhSachKho();
        }
        private void btnSuaHang_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại hàng muốn sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
            // Tạo một đối tượng frmSuaHang và truyền thông tin từ hàng được chọn
            string id = selectedRow.Cells["id"].Value.ToString();
            string tenCoffee = selectedRow.Cells["TENSP"].Value.ToString();
            int soLuong = Convert.ToInt32(selectedRow.Cells["SOLUONG"].Value);
            DateTime ngayNhap = Convert.ToDateTime(selectedRow.Cells["NGAYNHAP"].Value);
            DateTime hanSuDung = Convert.ToDateTime(selectedRow.Cells["HANSD"].Value);
            int giaMua = Convert.ToInt32(selectedRow.Cells["GIAMUA"].Value);
            int giaBan = Convert.ToInt32(selectedRow.Cells["GIABAN"].Value);
            string imageUrl = selectedRow.Cells["HINHANH"].Value.ToString();


            if (FrmSuaHang == null || FrmSuaHang.IsDisposed)
            {
                frmSuaHang frmSua = new frmSuaHang(id,tenCoffee, giaMua, giaBan, soLuong, ngayNhap, hanSuDung, imageUrl);
              frmSua.Show();
            }
        }
        #endregion
        #region ThemHangHoa
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (FrmThemHang == null || FrmThemHang.IsDisposed)
            {
                FrmThemHang = new frmThemHang();
                FrmThemHang.Show();
            }
        }
        #endregion
        #region XoaHang
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["id"].Value.ToString();
                txtTenHang.Text = row.Cells["TENSP"].Value.ToString();
            }
        }
        public bool DeleteCoffee(string id,string TenSP)
        {
            return CoffeeTypeDAO.Instance.DeleteNuocUong(id, TenSP);
        }
        void ClearLabelInfor()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
        }
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            string TenSP = txtTenHang.Text;
            string ID = txtMaHang.Text;
            try
            {
                int id = int.Parse(txtMaHang.Text);  // Hiển thị hộp thoại xác nhận
         
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + TenSP + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (CoffeeTypeDAO.Instance.DeleteNuocUong(ID,TenSP))
                    {
                        MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                        ClearLabelInfor();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dataGridView2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn loại hàng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Duyệt qua các hàng được chọn trong DataGridView
                foreach (DataGridViewRow selectedRow in dataGridView2.SelectedRows)
                {
                    // Lấy giá trị của trường ID từ mỗi hàng
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    // Gọi hàm xóa từ cơ sở dữ liệu
                    if (CoffeeTypeDAO.Instance.DeleteNuocUong(ID,TenSP))
                    {
                        Console.WriteLine($"Đã xóa sản phẩm có ID {id} thành công.");
                    }
                    else
                    {
                        Console.WriteLine($"Xóa sản phẩm có ID {id} không thành công.");
                    }
                }

                // Load lại danh sách sau khi xóa
                LoadDanhSachKho();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa dữ liệu: {ex.Message}");
            }
            LoadDanhSachKho();
        }
        #endregion
        #region Thongke
        //Thống kê doanh thu
        private void btnHienthi_Click(object sender, EventArgs e)
        {        
            LoadThongKe();
        }
        void LoadThongKe()
        { 
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpEnd.Value;
            txtLoiNhuan.Text = BillDAO.Instance.LoiNhuan(fromDate, toDate).ToString();
            txtTongHoaDon.Text = BillDAO.Instance.CountBill(fromDate, toDate).ToString();
            txtTongTienHoaDon.Text = BillDAO.Instance.SumTongTienBill(fromDate, toDate).ToString();
            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = BillDAO.Instance.GetBillInRange(fromDate, toDate);
            // Xóa dữ liệu hiện tại trước khi thêm mới vào biểu đồ
            chartThongKe.Series["DoanhThu"].Points.Clear();
            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in data.Rows)
            {
                // Lấy ngày và tổng tiền từ DataRow
                DateTime ngayLap = (DateTime)row["NgayLap"];
                int tongTien = Convert.ToInt32(row["TongTien"]);
                // Định dạng ngày thành chuỗi với định dạng mong muốn
                string formattedDate = ngayLap.ToString("dd/MM/yyyy");
                // Thêm điểm vào Series của biểu đồ
                chartThongKe.Series["DoanhThu"].Points.AddXY(formattedDate, tongTien);
            }
            LoadPieChart();
        }
        private void LoadPieChart()
        {
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpEnd.Value;
            DataTable dt = DataProvider.Instance.LoadPieChartData(fromDate, toDate);
            chartPieTrend.Series.Clear();
            Series series = new Series("Tỉ lệ theo sản phẩm");
            series.ChartType = SeriesChartType.Pie;
            foreach (DataRow row in dt.Rows)
            {
                string TENSP = row["TENSP"].ToString();
                int SOLUONG = Convert.ToInt32(row["SOLUONG"]);
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = TENSP; 
                dataPoint.YValues = new double[] { SOLUONG };
                dataPoint.IsValueShownAsLabel = true; 
                series.Points.Add(dataPoint);
            }
            chartPieTrend.Series.Add(series);
            chartPieTrend.ChartAreas[0].AxisX.Title = "Tên sản phẩm";
            chartPieTrend.ChartAreas[0].AxisY.Title = "Số lượng";
        }
        private void chartDoanhthu_MouseLeave(object sender, EventArgs e)
        {
            lblToolTip.Visible = false;
        }
        private void chartThongKe_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chartThongKe.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    int dataPointIndex = result.PointIndex;
                    var series = result.Series;
                    var dataPoint = series.Points[dataPointIndex];

                    // Lấy giá trị NgayLap và TongTien tương ứng
                    string ngayLap = dataPoint.AxisLabel;
                    string tongTien = dataPoint.YValues[0].ToString();

                    // Cập nhật vị trí và hiển thị thông tin
                    lblToolTip.Text = $"NgayLap: {ngayLap}, TongTien: {tongTien}";
                    lblToolTip.Location = new Point(pos.X + 10, pos.Y + 10);
                    lblToolTip.Visible = true;
                }
            }
        }
        #endregion  
        #region UI
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void splitContainer6_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void txtTimNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
        private void tcQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtTimCoffee_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
