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
    public partial class frmNguoiDung : Form
    {

        BLLNguoiDung nguoiDung = new BLLNguoiDung();
        bool Them = false;
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        void LoadData()
        {            
            nguoiDung.LayThongTin(dtgvDS);
            nguoiDung.LoadcbbTenNV(cbbHoTen);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            txtMaNV.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTenDN.Enabled = false;
            cbbHoTen.Enabled = true;
            cbbTrangThai.Enabled = false;

            txtMatKhau.ResetText();
            txtMaNV.ResetText();
            cbbTrangThai.ResetText();
            txtTenDN.ResetText();
            cbbHoTen.ResetText();           
            txtMaNV.Enabled = false;
            cbbHoTen.Enabled = false;
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            this.txtMaNV.Enabled = false;
            this.txtMatKhau.Enabled = true;
            this.txtTenDN.Enabled = true;
            this.cbbTrangThai.Enabled = true;

            this.txtMatKhau.ResetText();
            this.txtMaNV.ResetText();
            this.cbbTrangThai.ResetText();
            this.txtTenDN.ResetText();
            this.cbbHoTen.ResetText();
            this.cbbHoTen.Enabled = true;
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvDS.CurrentCell.RowIndex;
            txtMaNV.Text = dtgvDS.Rows[r].Cells[0].Value.ToString();
            cbbHoTen.Text = dtgvDS.Rows[r].Cells[1].Value.ToString();
            txtTenDN.Text = dtgvDS.Rows[r].Cells[2].Value.ToString();          
            cbbTrangThai.Text = dtgvDS.Rows[r].Cells[3].Value.ToString();
            txtMatKhau.Text = nguoiDung.LayMatKhau(txtTenDN.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tdn = txtTenDN.Text;
            DialogResult xoa;
            xoa = MessageBox.Show("Bạn có muốn xóa tài khoản người dùng này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if(nguoiDung.XoaNguoiDung(tdn))
                    {
                        LoadData();
                        nguoiDung.LayThongTin(dtgvDS);
                        MessageBox.Show("Xóa tài khoản người dùng thành công");
                    }    
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn tài khoản người dùng cần xóa");
                    }    
                    
                }
                catch
                {
                    MessageBox.Show("Xóa tài khoản người dùng thất bại");
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

            cbbHoTen.Enabled = false;
            txtTenDN.Enabled = true;
            txtMatKhau.Enabled = true;
            cbbTrangThai.Enabled = true;

            txtTenDN.ResetText();
            txtMatKhau.ResetText();            
            cbbTrangThai.ResetText();
            cbbHoTen.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbHoTen.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                this.cbbHoTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống","Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtTenDN.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.cbbTrangThai.Text))
            {
                MessageBox.Show("Trạng thái không được bỏ trống", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                cbbTrangThai.Focus();
                return;
            }

            if (Them)
            {
                try
                {
                    nguoiDung.ThemNguoiDung(txtMaNV.Text, txtTenDN.Text, nguoiDung.MaHoa(txtMatKhau.Text), cbbTrangThai.Text);
                    LoadData();
                    nguoiDung.LayThongTin(dtgvDS);
                    MessageBox.Show("Thêm tài khoản người dùng thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Thêm tài khoản người dùng thất bại", "Thông báo");
                }
            }
            else
            {
                try
                {
                    nguoiDung.SuaNguoiDung(txtMaNV.Text, txtTenDN.Text, nguoiDung.MaHoa(txtMatKhau.Text), cbbTrangThai.Text);
                    LoadData();
                    nguoiDung.LayThongTin(dtgvDS);
                    MessageBox.Show("Sửa tài khoản người dùng thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Sửa tài khoản người dùng thất bại", "Thông báo");
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbHoTen_TextChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = nguoiDung.LayMaNV(cbbHoTen.Text);
        }
    }
}
