
namespace GUI_NhaKhoa
{
    partial class frmKetNoi
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.cbbDB = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.lbl_ServerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(239, 310);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(176, 45);
            this.btn_Huy.TabIndex = 19;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(22, 310);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(156, 45);
            this.btn_Luu.TabIndex = 18;
            this.btn_Luu.Text = "Lưu lại";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(17, 244);
            this.lbl_Database.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(101, 27);
            this.lbl_Database.TabIndex = 17;
            this.lbl_Database.Text = "Database";
            // 
            // lbl_PassWord
            // 
            this.lbl_PassWord.AutoSize = true;
            this.lbl_PassWord.Location = new System.Drawing.Point(17, 200);
            this.lbl_PassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PassWord.Name = "lbl_PassWord";
            this.lbl_PassWord.Size = new System.Drawing.Size(108, 27);
            this.lbl_PassWord.TabIndex = 16;
            this.lbl_PassWord.Text = "PassWord";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(17, 155);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 27);
            this.lbl_UserName.TabIndex = 15;
            this.lbl_UserName.Text = "UserName";
            // 
            // cbbDB
            // 
            this.cbbDB.FormattingEnabled = true;
            this.cbbDB.Location = new System.Drawing.Point(181, 241);
            this.cbbDB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDB.Name = "cbbDB";
            this.cbbDB.Size = new System.Drawing.Size(234, 34);
            this.cbbDB.TabIndex = 14;
            this.cbbDB.DropDown += new System.EventHandler(this.cbbDB_DropDown);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(181, 193);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(234, 34);
            this.txtPass.TabIndex = 13;
            // 
            // txtUseName
            // 
            this.txtUseName.Location = new System.Drawing.Point(181, 148);
            this.txtUseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(234, 34);
            this.txtUseName.TabIndex = 12;
            // 
            // cbbServer
            // 
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(181, 106);
            this.cbbServer.Margin = new System.Windows.Forms.Padding(4);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(234, 34);
            this.cbbServer.TabIndex = 11;
            this.cbbServer.DropDown += new System.EventHandler(this.cbbServer_DropDown);
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.AutoSize = true;
            this.lbl_ServerName.Location = new System.Drawing.Point(17, 109);
            this.lbl_ServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.Size = new System.Drawing.Size(131, 27);
            this.lbl_ServerName.TabIndex = 10;
            this.lbl_ServerName.Text = "ServerName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_ServerName);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.cbbServer);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.txtUseName);
            this.groupBox1.Controls.Add(this.lbl_Database);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.lbl_PassWord);
            this.groupBox1.Controls.Add(this.cbbDB);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 434);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kết Nối Cơ Sở Dữ Liệu";
            // 
            // frmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKetNoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.Label lbl_PassWord;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.ComboBox cbbDB;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUseName;
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.Label lbl_ServerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}