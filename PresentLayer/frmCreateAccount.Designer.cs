namespace PresentLayer
{
    partial class frmCreateAccount
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
            System.Windows.Forms.Button btnDangKy;
            System.Windows.Forms.Button btnHuyDangKy;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpAccountManagement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            btnDangKy = new System.Windows.Forms.Button();
            btnHuyDangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpAccountManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(157)))));
            btnDangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDangKy.ForeColor = System.Drawing.SystemColors.Control;
            btnDangKy.Location = new System.Drawing.Point(22, 495);
            btnDangKy.Margin = new System.Windows.Forms.Padding(0);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new System.Drawing.Size(188, 46);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Sign up";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuyDangKy
            // 
            btnHuyDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            btnHuyDangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnHuyDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHuyDangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnHuyDangKy.FlatAppearance.BorderSize = 0;
            btnHuyDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuyDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHuyDangKy.ForeColor = System.Drawing.SystemColors.Control;
            btnHuyDangKy.Location = new System.Drawing.Point(219, 495);
            btnHuyDangKy.Margin = new System.Windows.Forms.Padding(0);
            btnHuyDangKy.Name = "btnHuyDangKy";
            btnHuyDangKy.Size = new System.Drawing.Size(188, 46);
            btnHuyDangKy.TabIndex = 22;
            btnHuyDangKy.Text = "Exit";
            btnHuyDangKy.UseVisualStyleBackColor = false;
            btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::PresentLayer.Properties.Resources.logo11;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(431, 219);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(22, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 28);
            this.textBox2.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(22, 258);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(373, 28);
            this.txtUserName.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblPassword.Location = new System.Drawing.Point(22, 321);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblUsername.Location = new System.Drawing.Point(22, 225);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.label9.Location = new System.Drawing.Point(22, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Role";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbType.Location = new System.Drawing.Point(26, 437);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(184, 24);
            this.cbType.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpAccountManagement);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 589);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picLogo);
            this.tabPage1.Controls.Add(btnHuyDangKy);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblPassword);
            this.tabPage1.Controls.Add(btnDangKy);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpAccountManagement
            // 
            this.tpAccountManagement.Controls.Add(this.label1);
            this.tpAccountManagement.Controls.Add(this.txtTaiKhoan);
            this.tpAccountManagement.Controls.Add(this.btnXoaTaiKhoan);
            this.tpAccountManagement.Controls.Add(this.dgvAccount);
            this.tpAccountManagement.Location = new System.Drawing.Point(4, 25);
            this.tpAccountManagement.Name = "tpAccountManagement";
            this.tpAccountManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountManagement.Size = new System.Drawing.Size(437, 560);
            this.tpAccountManagement.TabIndex = 1;
            this.tpAccountManagement.Text = "Danh Sách Tài Khoản";
            this.tpAccountManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTaiKhoan.Location = new System.Drawing.Point(123, 52);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(156, 21);
            this.txtTaiKhoan.TabIndex = 29;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnXoaTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(319, 40);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(89, 44);
            this.btnXoaTaiKhoan.TabIndex = 23;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 109);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(431, 443);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 589);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpAccountManagement.ResumeLayout(false);
            this.tpAccountManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpAccountManagement;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
    }
}