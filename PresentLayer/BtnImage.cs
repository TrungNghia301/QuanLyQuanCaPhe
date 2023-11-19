using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentLayer
{
    public partial class BtnImage : UserControl
    {
        public BtnImage()
        {
            InitializeComponent();
        }

        private void btnMenuPic_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện tùy chỉnh khi button được click
            CoffeeItemSelected?.Invoke(this, EventArgs.Empty);
        }
        // Định nghĩa sự kiện tùy chỉnh để thông báo khi button được click
        public event EventHandler CoffeeItemSelected;

        // ... (các mã khác)

       
        // Phương thức để cập nhật hình ảnh
        public void SetImage(string imageUrl)
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Tải dữ liệu ảnh từ URL
                    byte[] data = webClient.DownloadData(imageUrl);

                    // Chuyển dữ liệu nhị phân thành hình ảnh và gán cho PictureBox
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        pbButton.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading image: " + ex.Message);
                // Xử lý nếu có lỗi khi tải ảnh
            }
        }



        // Phương thức để cập nhật text của Button
        public void SetButtonText(string text)
        {
            btnMenuPic.Text = text;
        }

        private void BtnImage_Click_1(object sender, EventArgs e)
        {
            // Gọi sự kiện tùy chỉnh khi button được click
            CoffeeItemSelected?.Invoke(this, EventArgs.Empty);
        }

        private void pbButton_Click_1(object sender, EventArgs e)
        {
            // Gọi trực tiếp sự kiện Click của Button
            btnMenuPic_Click(btnMenuPic, e);
        }

        private void pbButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnMenuPic_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
