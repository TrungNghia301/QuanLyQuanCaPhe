namespace PresentLayer
{
    partial class BtnImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuPic = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbButton = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuPic
            // 
            this.btnMenuPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPic.Location = new System.Drawing.Point(3, 140);
            this.btnMenuPic.Name = "btnMenuPic";
            this.btnMenuPic.Size = new System.Drawing.Size(174, 57);
            this.btnMenuPic.TabIndex = 1;
            this.btnMenuPic.Text = "button1";
            this.btnMenuPic.UseVisualStyleBackColor = true;
            this.btnMenuPic.Click += new System.EventHandler(this.btnMenuPic_Click);
            this.btnMenuPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuPic_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.pbButton);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuPic);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 200);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pbButton
            // 
            this.pbButton.BackgroundImage = global::PresentLayer.Properties.Resources.logo;
            this.pbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbButton.Location = new System.Drawing.Point(3, 3);
            this.pbButton.Name = "pbButton";
            this.pbButton.Size = new System.Drawing.Size(173, 131);
            this.pbButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbButton.TabIndex = 0;
            this.pbButton.TabStop = false;
            this.pbButton.Click += new System.EventHandler(this.pbButton_Click_1);
            this.pbButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbButton_MouseClick);
            // 
            // BtnImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BtnImage";
            this.Size = new System.Drawing.Size(180, 200);
            this.Click += new System.EventHandler(this.BtnImage_Click_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbButton;
        private System.Windows.Forms.Button btnMenuPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
