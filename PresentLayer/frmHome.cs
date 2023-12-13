using ImageButtonControl;
using PresentLayer.DAO;
using PresentLayer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentLayer
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            LoadMenuAsync();
        }
        private async void LoadMenuAsync()
        {
            await Task.Delay(1000);
            LoadMenu();
        }
        public void LayIdthuNgan(string id)
        {
            txtMaNvThuNgan.Text = id;
        }
        public void LaytenThuNgan(string tenNV)
        {
            txtThuNgan.Text = tenNV;
        }
        public void NgayLap()
        {
            DateTime current = DateTime.Now;
            string i = current.ToString("yyyy-MM-dd HH:mm:ss");
            txtNgayLap.Text = i;
        }

            void LoadMenu()
            {
            // Xóa tất cả các control đang có trong flpMenu
            flpMenu.Controls.Clear();
            List<Coffee> coffeeList = CoffeeTypeDAO.Instance.LoadCoffeeList();
                //với mỗi item trong list table tạo một bàn với ctrl button
                foreach (Coffee item in coffeeList)
                {
                BtnImage button = new BtnImage();
                button.SetButtonText(item.Name + "\n" + item.Giaban +" VND" +" SL:"+ item.Soluong);
                button.CoffeeItemSelected += BtnImage_CoffeeItemSelected; // Thêm xử lý sự kiện cho sự kiện tùy chỉnh
                button.Tag = item;
          
                // Thiết lập hình ảnh từ URL
                button.SetImage(item.Url);

                flpMenu.Controls.Add(button);
               

            }   
            }
        
        void BtnImage_CoffeeItemSelected(object sender, EventArgs e)
        {
           
            // Xử lý sự kiện khi sản phẩm được chọn
            ChooseCoffeeMenu(sender as BtnImage);
            TottalPrice();
        }
        void TottalPrice()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                int thanhtien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                total = thanhtien + total;
            }

            txtTottalPrice.Text = total.ToString();
        }
        void ChooseCoffeeMenu(BtnImage selectedButton)
        {
            // Truy cập dữ liệu từ Tag của Button đã chọn
            Coffee selectedCoffee = selectedButton.Tag as Coffee;
            // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView chưa
            DataGridViewRow existingRow = null;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["Id"].Value != null && row.Cells["Id"].Value.ToString() == selectedCoffee.Id.ToString())
                {
                    existingRow = row;
                    break;
                }
            }
            if (existingRow != null)
            {
                // Nếu sản phẩm đã tồn tại, chỉ cập nhật số lượng
                int currentQuantity = Convert.ToInt32(existingRow.Cells["Soluong"].Value);
                existingRow.Cells["Soluong"].Value = currentQuantity + 1;
                existingRow.Cells["ThanhTien"].Value = Convert.ToInt32(existingRow.Cells["Soluong"].Value) * selectedCoffee.Giaban;
            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thêm mới vào DataGridView
                dgvHoaDon.Rows.Add(selectedCoffee.Id, selectedCoffee.Name, 1, selectedCoffee.Giaban);
            }
        }
        //TaiLaiMENU
        private void btnTaiLaiMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }
        #region ui
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtThuNgan_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
        void ResetformHoadon()
        {
            dgvHoaDon.Rows.Clear();
            txtTottalPrice.Text = "0";
            txtNgayLap.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ResetformHoadon();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvHoaDon.CurrentRow;
            if (currentRow != null)
            {
                try
                {
                    dgvHoaDon.Rows.Remove(currentRow);
                }
                catch(Exception ab)
                {
                    MessageBox.Show("Chọn 1 hàng để xóa!");
                }
            }
            TottalPrice();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool exceptionOccurred = false;
            int MaHD = 0;
            DialogResult cc = MessageBox.Show(
                "Xác nhận thanh toán?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (cc == DialogResult.Yes)
            {
                if (dgvHoaDon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hàng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else {
                    try
                    {
                        string nguoiThuNgan = txtMaNvThuNgan.Text;
                        int maHD;
                        BillDAO.Instance.CreateBill(out maHD, nguoiThuNgan);
                        Console.WriteLine("MaHD sau khi tạo: " + maHD);
                        MaHD = maHD;
                        // Lấy thông tin từ GridView và thêm vào BillChiTiet
                        foreach (DataGridViewRow row in dgvHoaDon.Rows)
                        {
                            int id = Convert.ToInt32(row.Cells["id"].Value);
                            int soLuong = Convert.ToInt32(row.Cells["Soluong"].Value);
                            int thanhTien = 0;
                            BillDAO.Instance.CreateBillChiTiet(id, maHD, soLuong, out thanhTien);
                            row.Cells["ThanhTien"].Value = thanhTien;
                        }
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        BillDAO.Instance.DeleteBill(MaHD);
                        exceptionOccurred = true;
                        MessageBox.Show("Số lượng hàng còn lại không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (!exceptionOccurred)
                    {
                        // Các dòng lệnh muốn thực hiện dù có exception hay không
                        NgayLap();
                        DialogResult result = MessageBox.Show("Có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            PrintPanel(pnHoaDon);
                            MessageBox.Show("In hóa đơn thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            ResetformHoadon();
                        }

                    }
                } 
            }
            else
            {
            }  
        }
        private void PrintPanel(Panel panelToPrint)
        {
            // Tạo một bitmap từ nội dung của Panel
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            // Hiển thị hộp thoại in
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = new PrintDocument();
            printDialog.Document.PrintPage += (s, ev) =>
            {
                // In hình ảnh của Panel lên trang in
                ev.Graphics.DrawImage(bitmap, 0, 0);
            };

            // Chọn máy in và hiển thị hộp thoại in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }
    }
}
