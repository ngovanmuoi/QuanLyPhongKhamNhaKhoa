namespace DoAnNhaKhoa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDN.Location = new System.Drawing.Point(22, 212);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(145, 22);
            this.lbl_TenDN.TabIndex = 1;
            this.lbl_TenDN.Text = "Tên Đăng Nhập:";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(22, 271);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(98, 22);
            this.lbl_MatKhau.TabIndex = 2;
            this.lbl_MatKhau.Text = "Mật Khẩu:";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(184, 212);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(200, 22);
            this.txt_TenDN.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(184, 271);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 22);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(26, 350);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(141, 45);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(243, 350);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(141, 45);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(429, 437);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

