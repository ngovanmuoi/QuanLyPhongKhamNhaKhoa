
namespace GUI_NhaKhoa
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvQuyen = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.dtgvDS);
            this.groupControl1.Location = new System.Drawing.Point(17, 76);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 327);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Danh sách người dùng";
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.dtgvDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgvDS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDS.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.EnableHeadersVisualStyles = false;
            this.dtgvDS.Location = new System.Drawing.Point(2, 33);
            this.dtgvDS.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.RowHeadersWidth = 51;
            this.dtgvDS.RowTemplate.Height = 30;
            this.dtgvDS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDS.Size = new System.Drawing.Size(424, 292);
            this.dtgvDS.TabIndex = 1;
            this.dtgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phân Quyền Người Dùng";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.dtgvQuyen);
            this.groupControl2.Location = new System.Drawing.Point(451, 76);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(619, 524);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Danh sách quyền chức năng";
            // 
            // dtgvQuyen
            // 
            this.dtgvQuyen.AllowUserToAddRows = false;
            this.dtgvQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQuyen.BackgroundColor = System.Drawing.Color.White;
            this.dtgvQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQuyen.GridColor = System.Drawing.Color.Black;
            this.dtgvQuyen.Location = new System.Drawing.Point(2, 33);
            this.dtgvQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvQuyen.Name = "dtgvQuyen";
            this.dtgvQuyen.RowHeadersWidth = 51;
            this.dtgvQuyen.RowTemplate.Height = 24;
            this.dtgvQuyen.Size = new System.Drawing.Size(615, 489);
            this.dtgvQuyen.TabIndex = 0;
            this.dtgvQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuyen_CellClick);
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.btnLuu);
            this.groupControl3.Location = new System.Drawing.Point(17, 410);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(427, 190);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Xử lý";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI_NhaKhoa.Properties.Resources.icon_save;
            this.btnLuu.Location = new System.Drawing.Point(19, 74);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(208, 76);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaManHinh";
            this.Column1.HeaderText = "Mã Màn Hình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenManHinh";
            this.Column2.HeaderText = "Tên Màn Hình";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CoQuyen";
            this.Column3.FalseValue = "False";
            this.Column3.HeaderText = "Có Quyền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.TrueValue = "True";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 612);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền người dùng";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dtgvQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}