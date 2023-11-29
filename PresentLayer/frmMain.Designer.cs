namespace PresentLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaNhanVienTrucCa = new System.Windows.Forms.Label();
            this.lblTenNhanVienTrucCa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnADc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnADc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(157)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblMaNhanVienTrucCa);
            this.panel1.Controls.Add(this.lblTenNhanVienTrucCa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDongHo);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 673);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMaNhanVienTrucCa
            // 
            this.lblMaNhanVienTrucCa.AutoSize = true;
            this.lblMaNhanVienTrucCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaNhanVienTrucCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVienTrucCa.ForeColor = System.Drawing.Color.White;
            this.lblMaNhanVienTrucCa.Location = new System.Drawing.Point(0, 250);
            this.lblMaNhanVienTrucCa.Name = "lblMaNhanVienTrucCa";
            this.lblMaNhanVienTrucCa.Size = new System.Drawing.Size(161, 20);
            this.lblMaNhanVienTrucCa.TabIndex = 7;
            this.lblMaNhanVienTrucCa.Text = "Nguyễn Trung Nghĩa";
            // 
            // lblTenNhanVienTrucCa
            // 
            this.lblTenNhanVienTrucCa.AutoSize = true;
            this.lblTenNhanVienTrucCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenNhanVienTrucCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVienTrucCa.ForeColor = System.Drawing.Color.White;
            this.lblTenNhanVienTrucCa.Location = new System.Drawing.Point(0, 230);
            this.lblTenNhanVienTrucCa.Name = "lblTenNhanVienTrucCa";
            this.lblTenNhanVienTrucCa.Size = new System.Drawing.Size(161, 20);
            this.lblTenNhanVienTrucCa.TabIndex = 6;
            this.lblTenNhanVienTrucCa.Text = "Nguyễn Trung Nghĩa";
            this.lblTenNhanVienTrucCa.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xin chào!";
            // 
            // lblDongHo
            // 
            this.lblDongHo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongHo.ForeColor = System.Drawing.Color.White;
            this.lblDongHo.Location = new System.Drawing.Point(60, 555);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(137, 57);
            this.lblDongHo.TabIndex = 4;
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(60, 626);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 35);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 210);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 69);
            this.button3.TabIndex = 6;
            this.button3.Text = "Quản lý tác vụ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 69);
            this.button4.TabIndex = 7;
            this.button4.Text = "Lịch sử hóa đơn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(270, 69);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Trang chủ/Order";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnADc
            // 
            this.pnADc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnADc.BackgroundImage = global::PresentLayer.Properties.Resources.Screenshot_2023_11_24_194608;
            this.pnADc.Controls.Add(this.pictureBox1);
            this.pnADc.Location = new System.Drawing.Point(-11, -28);
            this.pnADc.Name = "pnADc";
            this.pnADc.Size = new System.Drawing.Size(1506, 728);
            this.pnADc.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentLayer.Properties.Resources.you_me_and_coffee_gif_52650_315473;
            this.pictureBox1.Location = new System.Drawing.Point(178, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Image = global::PresentLayer.Properties.Resources.Untitled;
            this.pictureBoxlogo.Location = new System.Drawing.Point(270, 0);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(998, 673);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogo.TabIndex = 2;
            this.pictureBoxlogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.pnADc);
            this.Controls.Add(this.pictureBoxlogo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JonCoffee";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnADc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTenNhanVienTrucCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaNhanVienTrucCa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnADc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}