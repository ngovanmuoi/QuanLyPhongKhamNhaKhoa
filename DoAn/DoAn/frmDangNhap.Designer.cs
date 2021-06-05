
namespace DoAn
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(194, 349);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(208, 30);
            this.txt_matkhau.TabIndex = 24;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(194, 295);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(208, 30);
            this.txt_taikhoan.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::DoAn.Properties.Resources.cancel;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(275, 402);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(127, 50);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = global::DoAn.Properties.Resources.tick;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(41, 402);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(148, 50);
            this.btn_login.TabIndex = 25;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(134, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 494);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmDangNhap.IconOptions.SvgImage")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_thoat;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.TextBox txt_matkhau;
        public System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}