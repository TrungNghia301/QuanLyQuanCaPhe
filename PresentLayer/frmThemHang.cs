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
    public partial class frmThemHang : Form
    {
        public frmThemHang()
        {
            InitializeComponent();
           
        }

        private void btnThoatThemHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
          
            if (txtTenIn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Coffee!",
                                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else {
                string tenCoffee = txtTenIn.Text;
                int soLuong = (int)nmSoLuongIn.Value;
                int giaMua = (int)nmGiaMuaI.Value;
                int giaBan = (int)nmGiaBanI.Value;
                DateTime ngayNhap = dtpNgayNhapIn.Value;
                DateTime hanSuDung = dtpHanSDI.Value;
                string imageUrl = txtUrlThemAnh.Text;
                DialogResult result = MessageBox.Show("Xác nhận thêm coffee" + tenCoffee + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (CoffeeTypeDAO.Instance.InsertNuocUong(tenCoffee ,soLuong ,ngayNhap,hanSuDung, giaMua, giaBan, imageUrl))
                    {
                        MessageBox.Show("Đã thêm món mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else  {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
           
        
        }

        private void txtTenIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
