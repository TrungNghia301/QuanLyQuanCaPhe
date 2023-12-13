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
    public partial class frmBill : Form
    { 

        public frmBill()
        {
            InitializeComponent();
            LoadDanhSachBill();
        }
        public void XoaBill()
        {
            grboxXoaBill.Visible = false;
        }
        void LoadDanhSachBill()
        {
            dgvBill.DataSource = BillDAO.Instance.LoadDSBill();
        }
        private void LoadChiTietHD(int MaHD)
        {
            DataTable dt = BillDAO.Instance.LoadBillInforById(MaHD);
            dgvBillChiTiet.DataSource = dt;
        }
        private void LoadHoaDonTheoNgay(DateTime From, DateTime To)
        {
            DataTable dt = BillDAO.Instance.LoadBillFromTo(From, To);
            dgvBill.DataSource = dt;
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0 && e.RowIndex < dgvBill.Rows.Count)
                {
                    DataGridViewRow row = dgvBill.Rows[e.RowIndex];
                    txtMaHoaDon.Text = row.Cells["MaHD"].Value.ToString();
                try
                {
                    int maHD = int.Parse(txtMaHoaDon.Text);
                    LoadChiTietHD(maHD);
                }
                catch(Exception kk)
                {
                }
                }
            
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            DateTime From = dtpFrom.Value;
            DateTime To = dtpTo.Value;
            LoadHoaDonTheoNgay(From, To);
        }

        private void btnXoaBill_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else { 
                int Mahd = int.Parse(txtMaHoaDon.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BillDAO.Instance.DeleteBill(Mahd))
                    {
                        MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                        LoadDanhSachBill();
                    }
                    try
                    {
                        foreach (DataGridViewRow selectedRow in dgvBill.SelectedRows)
                        {
                            int maHd = Convert.ToInt32(selectedRow.Cells["MaHD"].Value);
                            if (BillDAO.Instance.DeleteBill(maHd))
                            {
                                Console.WriteLine("Đã xóa sản phẩm có ID {id} thành công.");
                            }
                            else
                            {
                                Console.WriteLine("Xóa sản phẩm có ID {id} không thành công.");
                            }
                        }
                        LoadDanhSachBill();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi xóa dữ liệu: {ex.Message}");
                    }

                }
            }
            
            LoadDanhSachBill();
        }
    }
}
