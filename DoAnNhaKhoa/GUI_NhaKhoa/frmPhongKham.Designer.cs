
namespace GUI_NhaKhoa
{
    partial class frmPhongKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongKham));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvTT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbPhongKham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbNgayKham = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbtnChoKham = new System.Windows.Forms.RadioButton();
            this.rbtnDaKham = new System.Windows.Forms.RadioButton();
            this.rbtnTatCa = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhongKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayKham.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayKham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.10145F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblTenPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 97);
            this.panel1.TabIndex = 0;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(486, 37);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(376, 32);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.dtgvTT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 229);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1346, 458);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách bệnh nhân";
            // 
            // dtgvTT
            // 
            this.dtgvTT.AllowUserToAddRows = false;
            this.dtgvTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTT.Location = new System.Drawing.Point(2, 41);
            this.dtgvTT.Name = "dtgvTT";
            this.dtgvTT.RowHeadersWidth = 51;
            this.dtgvTT.RowTemplate.Height = 24;
            this.dtgvTT.Size = new System.Drawing.Size(1342, 415);
            this.dtgvTT.TabIndex = 0;
            this.dtgvTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTT_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rbtnTatCa);
            this.panel2.Controls.Add(this.rbtnDaKham);
            this.panel2.Controls.Add(this.rbtnChoKham);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbbPhongKham);
            this.panel2.Controls.Add(this.cbbNgayKham);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 117);
            this.panel2.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = global::GUI_NhaKhoa.Properties.Resources.icon_reload;
            this.btnReload.Location = new System.Drawing.Point(1297, 31);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(149, 51);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(851, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phòng khám";
            // 
            // cbbPhongKham
            // 
            this.cbbPhongKham.Location = new System.Drawing.Point(1009, 43);
            this.cbbPhongKham.Name = "cbbPhongKham";
            this.cbbPhongKham.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongKham.Properties.Appearance.Options.UseFont = true;
            this.cbbPhongKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPhongKham.Size = new System.Drawing.Size(264, 32);
            this.cbbPhongKham.TabIndex = 3;
            this.cbbPhongKham.SelectedIndexChanged += new System.EventHandler(this.cbbPhongKham_SelectedIndexChanged);
            this.cbbPhongKham.TextChanged += new System.EventHandler(this.cbbPhongKham_TextChanged);
            // 
            // cbbNgayKham
            // 
            this.cbbNgayKham.EditValue = null;
            this.cbbNgayKham.Location = new System.Drawing.Point(621, 43);
            this.cbbNgayKham.Name = "cbbNgayKham";
            this.cbbNgayKham.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgayKham.Properties.Appearance.Options.UseFont = true;
            this.cbbNgayKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNgayKham.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNgayKham.Size = new System.Drawing.Size(198, 32);
            this.cbbNgayKham.TabIndex = 2;
            this.cbbNgayKham.EditValueChanged += new System.EventHandler(this.cbbNgayKham_EditValueChanged);
            this.cbbNgayKham.TextChanged += new System.EventHandler(this.cbbNgayKham_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày khám";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoPhieu";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Số Phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChiDinh";
            this.Column3.HeaderText = "Chỉ Định Khám";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Khám";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "Khám bệnh";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // rbtnChoKham
            // 
            this.rbtnChoKham.AutoSize = true;
            this.rbtnChoKham.Checked = true;
            this.rbtnChoKham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoKham.Location = new System.Drawing.Point(33, 46);
            this.rbtnChoKham.Name = "rbtnChoKham";
            this.rbtnChoKham.Size = new System.Drawing.Size(139, 30);
            this.rbtnChoKham.TabIndex = 6;
            this.rbtnChoKham.Text = "Chờ khám";
            this.rbtnChoKham.UseVisualStyleBackColor = true;
            this.rbtnChoKham.CheckedChanged += new System.EventHandler(this.rbtnChoKham_CheckedChanged);
            // 
            // rbtnDaKham
            // 
            this.rbtnDaKham.AutoSize = true;
            this.rbtnDaKham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDaKham.Location = new System.Drawing.Point(188, 46);
            this.rbtnDaKham.Name = "rbtnDaKham";
            this.rbtnDaKham.Size = new System.Drawing.Size(125, 30);
            this.rbtnDaKham.TabIndex = 7;
            this.rbtnDaKham.Text = "Đã khám";
            this.rbtnDaKham.UseVisualStyleBackColor = true;
            this.rbtnDaKham.CheckedChanged += new System.EventHandler(this.rbtnDaKham_CheckedChanged);
            // 
            // rbtnTatCa
            // 
            this.rbtnTatCa.AutoSize = true;
            this.rbtnTatCa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTatCa.Location = new System.Drawing.Point(331, 45);
            this.rbtnTatCa.Name = "rbtnTatCa";
            this.rbtnTatCa.Size = new System.Drawing.Size(97, 30);
            this.rbtnTatCa.TabIndex = 8;
            this.rbtnTatCa.Text = "Tất cả";
            this.rbtnTatCa.UseVisualStyleBackColor = true;
            this.rbtnTatCa.CheckedChanged += new System.EventHandler(this.rbtnTatCa_CheckedChanged);
            // 
            // frmPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPhongKham";
            this.Text = "Phòng Khám";
            this.Load += new System.EventHandler(this.frmPhongKham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhongKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayKham.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayKham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenPhong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPhongKham;
        private DevExpress.XtraEditors.DateEdit cbbNgayKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dtgvTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.RadioButton rbtnChoKham;
        private System.Windows.Forms.RadioButton rbtnTatCa;
        private System.Windows.Forms.RadioButton rbtnDaKham;
    }
}