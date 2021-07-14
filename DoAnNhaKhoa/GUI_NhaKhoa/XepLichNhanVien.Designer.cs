
namespace GUI_NhaKhoa
{
    partial class XepLichNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XepLichNhanVien));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excute = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chooseEX = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblThu7 = new System.Windows.Forms.Label();
            this.lblThu6 = new System.Windows.Forms.Label();
            this.lblThu5 = new System.Windows.Forms.Label();
            this.lblThu4 = new System.Windows.Forms.Label();
            this.lblThu3 = new System.Windows.Forms.Label();
            this.lblThu2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.938838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.44343F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 654);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsnv});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 227);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 425);
            this.dataGridView1.TabIndex = 3;
            // 
            // dsnv
            // 
            this.dsnv.HeaderText = "Danh sách ca làm việc nhân viên";
            this.dsnv.MinimumWidth = 6;
            this.dsnv.Name = "dsnv";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_SL);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_excute);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_chooseEX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 155);
            this.panel1.TabIndex = 0;
            // 
            // txt_SL
            // 
            this.txt_SL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(207, 91);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(159, 34);
            this.txt_SL.TabIndex = 13;
            this.txt_SL.Text = "0";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.Location = new System.Drawing.Point(481, 91);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 43);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_excute
            // 
            this.btn_excute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excute.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excute.Appearance.Options.UseFont = true;
            this.btn_excute.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excute.ImageOptions.Image")));
            this.btn_excute.Location = new System.Drawing.Point(481, 28);
            this.btn_excute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excute.Name = "btn_excute";
            this.btn_excute.Size = new System.Drawing.Size(145, 43);
            this.btn_excute.TabIndex = 11;
            this.btn_excute.Text = "Sắp Xếp";
            this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập danh sách";
            // 
            // btn_chooseEX
            // 
            this.btn_chooseEX.ImageOptions.Image = global::GUI_NhaKhoa.Properties.Resources.excel;
            this.btn_chooseEX.Location = new System.Drawing.Point(207, 28);
            this.btn_chooseEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chooseEX.Name = "btn_chooseEX";
            this.btn_chooseEX.Size = new System.Drawing.Size(159, 43);
            this.btn_chooseEX.TabIndex = 5;
            this.btn_chooseEX.Text = "Chọn file excel";
            this.btn_chooseEX.Click += new System.EventHandler(this.btn_chooseEX_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCN);
            this.panel2.Controls.Add(this.lblThu7);
            this.panel2.Controls.Add(this.lblThu6);
            this.panel2.Controls.Add(this.lblThu5);
            this.panel2.Controls.Add(this.lblThu4);
            this.panel2.Controls.Add(this.lblThu3);
            this.panel2.Controls.Add(this.lblThu2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1287, 58);
            this.panel2.TabIndex = 1;
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCN.Location = new System.Drawing.Point(951, 20);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(111, 26);
            this.lblCN.TabIndex = 6;
            this.lblCN.Text = "Chủ Nhật";
            this.lblCN.Click += new System.EventHandler(this.lblCN_Click);
            // 
            // lblThu7
            // 
            this.lblThu7.AutoSize = true;
            this.lblThu7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu7.Location = new System.Drawing.Point(796, 20);
            this.lblThu7.Name = "lblThu7";
            this.lblThu7.Size = new System.Drawing.Size(72, 26);
            this.lblThu7.TabIndex = 5;
            this.lblThu7.Text = "Thứ 7";
            this.lblThu7.Click += new System.EventHandler(this.lblThu7_Click);
            // 
            // lblThu6
            // 
            this.lblThu6.AutoSize = true;
            this.lblThu6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu6.Location = new System.Drawing.Point(624, 20);
            this.lblThu6.Name = "lblThu6";
            this.lblThu6.Size = new System.Drawing.Size(72, 26);
            this.lblThu6.TabIndex = 4;
            this.lblThu6.Text = "Thứ 6";
            this.lblThu6.Click += new System.EventHandler(this.lblThu6_Click);
            // 
            // lblThu5
            // 
            this.lblThu5.AutoSize = true;
            this.lblThu5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu5.Location = new System.Drawing.Point(476, 20);
            this.lblThu5.Name = "lblThu5";
            this.lblThu5.Size = new System.Drawing.Size(72, 26);
            this.lblThu5.TabIndex = 3;
            this.lblThu5.Text = "Thứ 5";
            this.lblThu5.Click += new System.EventHandler(this.lblThu5_Click);
            // 
            // lblThu4
            // 
            this.lblThu4.AutoSize = true;
            this.lblThu4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu4.Location = new System.Drawing.Point(332, 20);
            this.lblThu4.Name = "lblThu4";
            this.lblThu4.Size = new System.Drawing.Size(72, 26);
            this.lblThu4.TabIndex = 2;
            this.lblThu4.Text = "Thứ 4";
            this.lblThu4.Click += new System.EventHandler(this.lblThu4_Click);
            // 
            // lblThu3
            // 
            this.lblThu3.AutoSize = true;
            this.lblThu3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu3.Location = new System.Drawing.Point(202, 20);
            this.lblThu3.Name = "lblThu3";
            this.lblThu3.Size = new System.Drawing.Size(72, 26);
            this.lblThu3.TabIndex = 1;
            this.lblThu3.Text = "Thứ 3";
            this.lblThu3.Click += new System.EventHandler(this.lblThu3_Click);
            // 
            // lblThu2
            // 
            this.lblThu2.AutoSize = true;
            this.lblThu2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu2.Location = new System.Drawing.Point(78, 20);
            this.lblThu2.Name = "lblThu2";
            this.lblThu2.Size = new System.Drawing.Size(72, 26);
            this.lblThu2.TabIndex = 0;
            this.lblThu2.Text = "Thứ 2";
            this.lblThu2.Click += new System.EventHandler(this.lblThu2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số nhân viên";
            // 
            // XepLichNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XepLichNhanVien";
            this.Text = "Xếp Lịch Làm Việc";
            this.Load += new System.EventHandler(this.XepLichNhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_chooseEX;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.SimpleButton btn_excute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblThu7;
        private System.Windows.Forms.Label lblThu6;
        private System.Windows.Forms.Label lblThu5;
        private System.Windows.Forms.Label lblThu4;
        private System.Windows.Forms.Label lblThu3;
        private System.Windows.Forms.Label lblThu2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsnv;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label2;
    }
}