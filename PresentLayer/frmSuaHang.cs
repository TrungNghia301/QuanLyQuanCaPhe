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
    public partial class frmSuaHang : Form
    {
        public frmSuaHang(string id , string tenCoffee, int giaMua, int giaBan, int soLuong, DateTime ngayNhap, DateTime hanSuDung, string imageUrl)
        {
            InitializeComponent();
            // Đặt giá trị cho các control
            txtIDHang.Text = id;
            txtTenCoffeeUpdate.Text = tenCoffee;
            txtUrlAnhSua.Text = imageUrl;
            nmSoluongUpdate.Value = soLuong;
            nmGiaMuaU.Value = giaMua;
            nmGiaBanU.Value = giaBan;
            dtpNgayNhapSua.Value = ngayNhap;
            dtpHSD.Value = hanSuDung;

        }

        private void frmSuaHang_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThoatThemHang_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDHang.Text);
            string tensp = txtTenCoffeeUpdate.Text;
            int soluong  = (int)nmSoluongUpdate.Value;
            DateTime ngaynhap = dtpNgayNhapSua.Value;
            DateTime HANSD = dtpHSD.Value;
            int giamua = (int)nmGiaMuaU.Value;
            int giaban = (int)nmGiaBanU.Value;
            string hinhanh = txtUrlAnhSua.Text;

            if (txtTenCoffeeUpdate.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CoffeeTypeDAO.Instance.UpdateNuocUong(id, tensp, soluong, ngaynhap, HANSD, giamua, giaban, hinhanh))
                {
                    MessageBox.Show("Đã cập nhật thông tin Cofee!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại kiểm tra lại các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
