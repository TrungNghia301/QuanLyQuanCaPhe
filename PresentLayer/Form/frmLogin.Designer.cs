namespace PresentLayer
{
    partial class frmLogin
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
            System.Windows.Forms.Button btnLogin;
            System.Windows.Forms.Button btnSubmitmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbhide = new System.Windows.Forms.PictureBox();
            this.pbshow = new System.Windows.Forms.PictureBox();
            this.lbfgpass = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pnForgotpassword = new System.Windows.Forms.Panel();
            this.lbbacklogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbCorrectmail = new System.Windows.Forms.Label();
            this.lbIncorrect = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnSubmitmail = new System.Windows.Forms.Button();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.pnForgotpassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(157)))));
            btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            btnLogin.Location = new System.Drawing.Point(31, 442);
            btnLogin.Margin = new System.Windows.Forms.Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(373, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSubmitmail
            // 
            btnSubmitmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(157)))));
            btnSubmitmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSubmitmail.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSubmitmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnSubmitmail.FlatAppearance.BorderSize = 0;
            btnSubmitmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmitmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmitmail.ForeColor = System.Drawing.SystemColors.Control;
            btnSubmitmail.Location = new System.Drawing.Point(33, 381);
            btnSubmitmail.Margin = new System.Windows.Forms.Padding(0);
            btnSubmitmail.Name = "btnSubmitmail";
            btnSubmitmail.Size = new System.Drawing.Size(373, 46);
            btnSubmitmail.TabIndex = 10;
            btnSubmitmail.Text = "Submit";
            btnSubmitmail.UseVisualStyleBackColor = false;
            btnSubmitmail.Click += new System.EventHandler(this.btnSubmitmail_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogo.Controls.Add(this.picLogo);
            this.pnLogo.Location = new System.Drawing.Point(0, -23);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(445, 243);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::PresentLayer.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(445, 243);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblUsername.Location = new System.Drawing.Point(29, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblPassword.Location = new System.Drawing.Point(29, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(29, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "admin";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(29, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(373, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "12345";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // pbhide
            // 
            this.pbhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbhide.Image = global::PresentLayer.Properties.Resources.hide;
            this.pbhide.Location = new System.Drawing.Point(368, 144);
            this.pbhide.Name = "pbhide";
            this.pbhide.Size = new System.Drawing.Size(30, 25);
            this.pbhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbhide.TabIndex = 6;
            this.pbhide.TabStop = false;
            this.pbhide.Click += new System.EventHandler(this.pbhide_Click);
            // 
            // pbshow
            // 
            this.pbshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbshow.Image = global::PresentLayer.Properties.Resources.show;
            this.pbshow.Location = new System.Drawing.Point(368, 144);
            this.pbshow.Name = "pbshow";
            this.pbshow.Size = new System.Drawing.Size(30, 25);
            this.pbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshow.TabIndex = 5;
            this.pbshow.TabStop = false;
            this.pbshow.Click += new System.EventHandler(this.pbshow_Click);
            // 
            // lbfgpass
            // 
            this.lbfgpass.AutoSize = true;
            this.lbfgpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbfgpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfgpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lbfgpass.Location = new System.Drawing.Point(164, 506);
            this.lbfgpass.Name = "lbfgpass";
            this.lbfgpass.Size = new System.Drawing.Size(115, 16);
            this.lbfgpass.TabIndex = 7;
            this.lbfgpass.Text = "Forgot password?";
            this.lbfgpass.Click += new System.EventHandler(this.lbfgpass_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.pbhide);
            this.pnLogin.Controls.Add(this.pbshow);
            this.pnLogin.Controls.Add(this.textBox2);
            this.pnLogin.Controls.Add(this.textBox1);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Controls.Add(this.lblUsername);
            this.pnLogin.Location = new System.Drawing.Point(2, 230);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(442, 200);
            this.pnLogin.TabIndex = 8;
            // 
            // pnForgotpassword
            // 
            this.pnForgotpassword.Controls.Add(this.lbIncorrect);
            this.pnForgotpassword.Controls.Add(this.lbCorrectmail);
            this.pnForgotpassword.Controls.Add(this.lbbacklogin);
            this.pnForgotpassword.Controls.Add(btnSubmitmail);
            this.pnForgotpassword.Controls.Add(this.label2);
            this.pnForgotpassword.Controls.Add(this.pictureBox1);
            this.pnForgotpassword.Controls.Add(this.label1);
            this.pnForgotpassword.Controls.Add(this.textBox3);
            this.pnForgotpassword.Location = new System.Drawing.Point(2, 3);
            this.pnForgotpassword.Name = "pnForgotpassword";
            this.pnForgotpassword.Size = new System.Drawing.Size(442, 589);
            this.pnForgotpassword.TabIndex = 9;
            // 
            // lbbacklogin
            // 
            this.lbbacklogin.AutoSize = true;
            this.lbbacklogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbbacklogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbacklogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lbbacklogin.Location = new System.Drawing.Point(179, 454);
            this.lbbacklogin.Name = "lbbacklogin";
            this.lbbacklogin.Size = new System.Drawing.Size(98, 16);
            this.lbbacklogin.TabIndex = 10;
            this.lbbacklogin.Text = "< Back to Login";
            this.lbbacklogin.Click += new System.EventHandler(this.lbbacklogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(29, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentLayer.Properties.Resources.forgot;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(55, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter your email we\'ll send your \r\npassword.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(33, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(373, 28);
            this.textBox3.TabIndex = 10;
            // 
            // lbCorrectmail
            // 
            this.lbCorrectmail.AutoSize = true;
            this.lbCorrectmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCorrectmail.Location = new System.Drawing.Point(30, 328);
            this.lbCorrectmail.Name = "lbCorrectmail";
            this.lbCorrectmail.Size = new System.Drawing.Size(317, 20);
            this.lbCorrectmail.TabIndex = 13;
            this.lbCorrectmail.Text = "Please check your mail and back to login.";
            this.lbCorrectmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbIncorrect
            // 
            this.lbIncorrect.AutoSize = true;
            this.lbIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrect.Location = new System.Drawing.Point(30, 328);
            this.lbIncorrect.Name = "lbIncorrect";
            this.lbIncorrect.Size = new System.Drawing.Size(193, 20);
            this.lbIncorrect.TabIndex = 14;
            this.lbIncorrect.Text = "We can\'t find your email.";
            this.lbIncorrect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 589);
            this.Controls.Add(this.pnForgotpassword);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.lbfgpass);
            this.Controls.Add(btnLogin);
            this.Controls.Add(this.pnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnForgotpassword.ResumeLayout(false);
            this.pnForgotpassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbshow;
        private System.Windows.Forms.PictureBox pbhide;
        private System.Windows.Forms.Label lbfgpass;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Panel pnForgotpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbbacklogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCorrectmail;
        private System.Windows.Forms.Label lbIncorrect;
    }
}

