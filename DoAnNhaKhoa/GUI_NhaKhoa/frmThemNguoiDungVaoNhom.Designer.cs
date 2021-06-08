
namespace GUI_NhaKhoa
{
    partial class frmThemNguoiDungVaoNhom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvND = new System.Windows.Forms.DataGridView();
            this.dtgvNDNND = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenNhom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNDNND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(375, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm Người Dùng Vào Nhóm";
            // 
            // dtgvND
            // 
            this.dtgvND.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            this.dtgvND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvND.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvND.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgvND.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvND.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvND.EnableHeadersVisualStyles = false;
            this.dtgvND.Location = new System.Drawing.Point(13, 154);
            this.dtgvND.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvND.Name = "dtgvND";
            this.dtgvND.ReadOnly = true;
            this.dtgvND.RowHeadersWidth = 51;
            this.dtgvND.RowTemplate.Height = 30;
            this.dtgvND.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvND.Size = new System.Drawing.Size(451, 380);
            this.dtgvND.TabIndex = 2;
            // 
            // dtgvNDNND
            // 
            this.dtgvNDNND.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.AliceBlue;
            this.dtgvNDNND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvNDNND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNDNND.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvNDNND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvNDNND.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgvNDNND.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNDNND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvNDNND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvNDNND.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvNDNND.EnableHeadersVisualStyles = false;
            this.dtgvNDNND.Location = new System.Drawing.Point(658, 154);
            this.dtgvNDNND.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNDNND.Name = "dtgvNDNND";
            this.dtgvNDNND.ReadOnly = true;
            this.dtgvNDNND.RowHeadersWidth = 51;
            this.dtgvNDNND.RowTemplate.Height = 30;
            this.dtgvNDNND.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNDNND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNDNND.Size = new System.Drawing.Size(456, 380);
            this.dtgvNDNND.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_NhaKhoa.Properties.Resources.icon_add;
            this.btnThem.Location = new System.Drawing.Point(489, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 73);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI_NhaKhoa.Properties.Resources.icon_remove;
            this.btnXoa.Location = new System.Drawing.Point(489, 282);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 73);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::GUI_NhaKhoa.Properties.Resources.icon_cancel;
            this.btnHuy.Location = new System.Drawing.Point(489, 390);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(149, 73);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhóm";
            // 
            // cbbTenNhom
            // 
            this.cbbTenNhom.Location = new System.Drawing.Point(775, 70);
            this.cbbTenNhom.Name = "cbbTenNhom";
            this.cbbTenNhom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNhom.Properties.Appearance.Options.UseFont = true;
            this.cbbTenNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTenNhom.Size = new System.Drawing.Size(288, 32);
            this.cbbTenNhom.TabIndex = 12;
            this.cbbTenNhom.TextChanged += new System.EventHandler(this.cbbTenNhom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(775, 111);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(288, 33);
            this.txtGhiChu.TabIndex = 14;
            // 
            // frmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 547);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTenNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNDNND);
            this.Controls.Add(this.dtgvND);
            this.Controls.Add(this.label1);
            this.Name = "frmThemNguoiDungVaoNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng vào nhóm";
            this.Load += new System.EventHandler(this.frmThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNDNND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvND;
        private System.Windows.Forms.DataGridView dtgvNDNND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTenNhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}