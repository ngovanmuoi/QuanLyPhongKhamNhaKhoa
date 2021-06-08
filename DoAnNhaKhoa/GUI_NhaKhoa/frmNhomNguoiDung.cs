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
    public partial class frmNhomNguoiDung : Form
    {
        BLLNhomNguoiDung nhomNguoiDung = new BLLNhomNguoiDung();
        bool Them = false;
        public frmNhomNguoiDung()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            nhomNguoiDung.LayThongTin(dtgvDS);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThemNguoiDungVaoNhom.Enabled = false;

            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = false;
            txtGhiChu.Enabled = false;

            txtMaNhom.ResetText();
            txtTenNhom.ResetText();
            txtGhiChu.ResetText();
        }
        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhom.Text = dtgvDS.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = dtgvDS.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dtgvDS.CurrentRow.Cells[2].Value.ToString();
            btnThemNguoiDungVaoNhom.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThemNguoiDungVaoNhom.Enabled = false;

            txtMaNhom.Enabled = true;
            txtTenNhom.Enabled = true;
            txtGhiChu.Enabled = true;

            txtMaNhom.ResetText();
            txtTenNhom.ResetText();
            txtGhiChu.ResetText();        
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhom = txtMaNhom.Text;
            DialogResult xoa;
            xoa = MessageBox.Show("Bạn có muốn xóa nhóm người dùng này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (nhomNguoiDung.XoaNhomNguoiDung(maNhom))
                    {
                        LoadData();
                        nhomNguoiDung.LayThongTin(dtgvDS);
                        MessageBox.Show("Xóa nhóm người dùng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn nhóm người dùng cần xóa");
                    }

                }
                catch
                {
                    MessageBox.Show("Xóa nhóm người dùng thất bại");
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
            btnThemNguoiDungVaoNhom.Enabled = false;

            txtTenNhom.Enabled = true;
            txtGhiChu.Enabled = true;

            txtTenNhom.ResetText();
            txtGhiChu.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text.Trim()))
            {
                MessageBox.Show("Mã nhóm không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                this.txtMaNhom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTenNhom.Text.Trim()))
            {
                MessageBox.Show("Tên nhóm không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtTenNhom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtGhiChu.Text))
            {
                MessageBox.Show("Hãy thêm ghi chú", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtGhiChu.Focus();
                return;
            }
            
            if (Them)
            {
                try
                {
                    nhomNguoiDung.ThemNhomNguoiDung(txtMaNhom.Text, txtTenNhom.Text, txtGhiChu.Text);
                    LoadData();
                    nhomNguoiDung.LayThongTin(dtgvDS);
                    MessageBox.Show("Thêm nhóm người dùng thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm nhóm người dùng thất bại", "Thông báo");
                }
            }
            else
            {
                try
                {
                    nhomNguoiDung.SuaNhomNguoiDung(txtMaNhom.Text, txtTenNhom.Text, txtGhiChu.Text);
                    LoadData();
                    nhomNguoiDung.LayThongTin(dtgvDS);
                    MessageBox.Show("Sửa nhóm người dùng thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Sửa nhóm người dùng thất bại", "Thông báo");
                }
            }
        }

        private void btnThemNguoiDungVaoNhom_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungVaoNhom themNguoiDungVaoNhom = new frmThemNguoiDungVaoNhom();
            themNguoiDungVaoNhom.TenNhom = txtTenNhom.Text.ToString();
            themNguoiDungVaoNhom.ShowDialog();
        }
    }
}
