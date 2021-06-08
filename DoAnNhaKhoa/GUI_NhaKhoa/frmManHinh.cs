using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_NhaKhoa.BLL_NhaKhoa;

namespace GUI_NhaKhoa
{
    public partial class frmManHinh : Form
    {
        BLLManHinh manHinh = new BLLManHinh();
        bool Them = false;
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            manHinh.LayThongTin(dtgvDS);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;

            txtMaMH.ResetText();
            txtTenMH.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;

            this.txtMaMH.ResetText();
            this.txtTenMH.ResetText();
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dtgvDS.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dtgvDS.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            DialogResult xoa;
            xoa = MessageBox.Show("Bạn có muốn xóa màn hình chức năng này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (manHinh.XoaManHinh(maMH))
                    {
                        LoadData();
                        manHinh.LayThongTin(dtgvDS);
                        MessageBox.Show("Xóa màn hình thành công");
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn màn hình cần xóa");
                    }

                }
                catch
                {
                    MessageBox.Show("Xóa màn hình thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;

            txtMaMH.ResetText();
            txtTenMH.ResetText();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMH.Text.Trim()))
            {
                MessageBox.Show("Mã màn hình không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                this.txtMaMH.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTenMH.Text.Trim()))
            {
                MessageBox.Show("Tên màn hình không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtTenMH.Focus();
                return;
            }

            if (Them)
            {
                try
                {
                    manHinh.ThemManHinh(txtMaMH.Text, txtTenMH.Text);
                    LoadData();
                    manHinh.LayThongTin(dtgvDS);
                    MessageBox.Show("Thêm màn hình thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm màn hình thất bại", "Thông báo");
                }
            }
            else
            {
                try
                {
                    manHinh.SuaManHinh(txtMaMH.Text, txtTenMH.Text);
                    LoadData();
                    manHinh.LayThongTin(dtgvDS);
                    MessageBox.Show("Sửa màn hình thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Sửa màn hình thất bại", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
