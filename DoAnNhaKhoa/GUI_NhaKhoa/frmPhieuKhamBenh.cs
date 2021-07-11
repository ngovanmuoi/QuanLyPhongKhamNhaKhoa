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
    public partial class frmPhieuKhamBenh : Form
    {
        public string LoaiKham { get; set; }
        public string SoPhieu { get; set; }
        public string NgayKham { get; set; }
        public string PhongKham { get; set; }

        bool them = true;
        BLLPhieuKham phieuKham = new BLLPhieuKham();
        public frmPhieuKhamBenh()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            
            cbbMaBN.Properties.DataSource = phieuKham.LayBenhNhan();
            cbbMaBN.Properties.DisplayMember = "MaBenhNhan";
            cbbMaBN.Properties.ValueMember = "MaBenhNhan";
            
            txtLoaiKham.Text = LoaiKham;
            txtSoPhieu.Text = SoPhieu;
            txtNgayKham.Text = NgayKham;
            txtPhongKham.Text = PhongKham;
            if (txtSoPhieu.Text != "" || txtNgayKham.Text != "")
            {
                cbbMaBN.Text = phieuKham.LayMaBN(txtSoPhieu.Text, txtNgayKham.Text);
                txtTiepDon.Text = phieuKham.LayTiepDon(txtSoPhieu.Text, txtNgayKham.Text);
                phieuKham.LayThongTin(txtSoPhieu.Text, txtNgayKham.Text, txtBacSi, txtLyDo, cbbTieuDuong, cbbHuyetAp, cbbTimMach);
                phieuKham.LayTTPhieuKham(txtSoPhieu.Text, txtChuanDoan, txtKetLuan);
            }
        }
        private void frmPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            LoadData();
            if(txtChuanDoan.Text =="" && txtKetLuan.Text == "")
            {
                btnSua.Enabled = false;
                btnIn.Enabled = false;
            } 
            else
            {
                txtChuanDoan.Enabled = false;
                txtKetLuan.Enabled = false;
                txtLoaiKham.ReadOnly = true;
                cbbMaBN.ReadOnly = true;
                cbbHuyetAp.Enabled = false;
                cbbTimMach.Enabled = false;
                cbbTieuDuong.Enabled = false;
                btnLuu.Enabled = false;
                txtChuanDoan.Focus();
            }    
        }

        private void cbbMaBN_TextChanged(object sender, EventArgs e)
        {
            phieuKham.LayTTBenhNhan(cbbMaBN.Text, txtMaThe, txtHoTen, txtGioiTinh, txtNgaySinh, txtDiaChi, txtDT, txtEmail);
        }

        private void btnKeDV_Click(object sender, EventArgs e)
        {
            frmPhieuDichVu phieuDichVu = new frmPhieuDichVu();
            phieuDichVu.SoPhieu = txtSoPhieu.Text;
            phieuDichVu.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChuanDoan.Text.Trim()))
            {
                MessageBox.Show("Chưa chuẩn đoán bệnh");
                this.txtChuanDoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtKetLuan.Text))
            {
                MessageBox.Show("Chưa kết luận bệnh");
                this.txtKetLuan.Focus();
                return;
            }
            
            if(them == true)
            {
                phieuKham.ThemPhieuKham(txtSoPhieu.Text, txtChuanDoan.Text, txtKetLuan.Text);
                phieuKham.CapNhatTrangThaiPhieu(txtSoPhieu.Text);
                LoadData();
                MessageBox.Show("Lưu phiếu khám thành công");
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnIn.Enabled = true;
            }
            if(them == false)
            {
                phieuKham.SuaPhieuKham(txtSoPhieu.Text, txtChuanDoan.Text, txtKetLuan.Text);
                LoadData();
                MessageBox.Show("Sửa phiếu khám thành công");

            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            cbbHuyetAp.Enabled = true;
            cbbTieuDuong.Enabled = true;
            cbbTimMach.Enabled = true;
            txtChuanDoan.Enabled = true;
            txtKetLuan.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtChuanDoan.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnKetThucKham_Click(object sender, EventArgs e)
        {
            DialogResult ketthuc = MessageBox.Show("Bạn đã hoàn thành khám bệnh cho bệnh nhân này", "Kết thúc khám", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ketthuc == DialogResult.Yes)
            {
                phieuKham.CapNhatTrangThaiPhieu(txtSoPhieu.Text);
                this.Close();
            }
        }

        private void btnHuyKham_Click(object sender, EventArgs e)
        {
            DialogResult huykham = MessageBox.Show("Bạn có chắc hủy khám cho bệnh nhân này", "Hủy khám", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (huykham == DialogResult.Yes)
            {             
                this.Close();
            }
        }
    }
}
