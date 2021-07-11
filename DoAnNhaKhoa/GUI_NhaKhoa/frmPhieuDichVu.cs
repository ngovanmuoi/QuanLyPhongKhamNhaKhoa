using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_NhaKhoa.BLL_NhaKhoa;
namespace GUI_NhaKhoa
{
    public partial class frmPhieuDichVu : Form
    {
        BLLPhieuKham phieuKham = new BLLPhieuKham();
        BLLPhieuDichVu phieuDichVu = new BLLPhieuDichVu();
        public string SoPhieu { get; set; }
        
        public frmPhieuDichVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            cbbMaBN.Properties.DataSource = phieuKham.LayBenhNhan();
            cbbMaBN.Properties.DisplayMember = "MaBenhNhan";
            cbbMaBN.Properties.ValueMember = "MaBenhNhan";
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cbbLoaiDichVu.Properties.DataSource = phieuDichVu.LayLoaiDichVu();
            cbbLoaiDichVu.Properties.DisplayMember = "TenLoai";
            cbbLoaiDichVu.Properties.ValueMember = "MaLoai";
            phieuDichVu.LayPhongDV(cbbPhong);
            txtSoPhieu.Text = SoPhieu;            
            if (txtSoPhieu.Text != "")
            {
                cbbMaBN.Text = phieuDichVu.LayMaBN(txtSoPhieu.Text);
                phieuDichVu.LayTTKham(txtSoPhieu.Text, txtTieuDuong, txtHuyetAp, txtBenhTimMach, txtChuanDoan, txtKetLuan);
            }
        }
        public string LaySoPhieuDVTuTang(string pMaPhong)
        {
            DataTable dt = phieuDichVu.LayDanhSachDV(pMaPhong);
            int count = dt.Rows.Count;
            string phieu = "";
            string soPhieuMoi = "";
            int soPhieu = 0;
            if (count == 0 && pMaPhong == "PDV003")
            {
                return "PDV003-001";
            }
            else if (count == 0 && pMaPhong == "PDV004")
            {
                return "PDV004-001";
            }
            else if (count != 0 && pMaPhong == "PDV003")
            {
                phieu = dt.Rows[count - 1][0].ToString();
                soPhieu = Convert.ToInt32((phieu.Remove(0, 7)));
                if (soPhieu + 1 < 10)
                {
                    soPhieuMoi = "PDV003-00" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 100)
                {
                    soPhieuMoi = "PDV003-0" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 1000)
                {
                    soPhieuMoi = "PDV003-" + (soPhieu + 1).ToString();
                }
                return soPhieuMoi;
            }
            else if (count != 0 && pMaPhong == "PDV004")
            {
                phieu = dt.Rows[count - 1][0].ToString();
                soPhieu = Convert.ToInt32((phieu.Remove(0, 7)));
                if (soPhieu + 1 < 10)
                {
                    soPhieuMoi = "PDV004-00" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 100)
                {
                    soPhieuMoi = "PDV004-0" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 1000)
                {
                    soPhieuMoi = "PDV004-" + (soPhieu + 1).ToString();
                }
                return soPhieuMoi;
            }
            return soPhieuMoi;
        }
        private void frmPhieuDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbMaBN_TextChanged(object sender, EventArgs e)
        {
            phieuDichVu.LayTTBenhNhan(cbbMaBN.Text, txtHoTen, txtGioiTinh, txtNgaySinh, txtDiaChi, txtDT);
        }

        private void cbbLoaiDichVu_TextChanged(object sender, EventArgs e)
        {
            string maLoai = phieuDichVu.LayMaLoaiDV(cbbLoaiDichVu.Text);
            phieuDichVu.LayThongTinDV(dtgvTT, maLoai);
        }

        private void cbbPhong_TextChanged(object sender, EventArgs e)
        {
            string maphong = phieuDichVu.LayMaPhongDV(cbbPhong.Text);
            txtSoPhieuDV.Text = LaySoPhieuDVTuTang(maphong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sophieu = txtSoPhieuDV.Text;
            string mabn = cbbMaBN.Text;
            string maphong = phieuDichVu.LayMaPhongDV(cbbPhong.Text);
            string ngaylap = txtNgayLap.Text;
            string madv = dtgvTT.CurrentRow.Cells[0].Value.ToString();
            int gia = int.Parse(dtgvTT.CurrentRow.Cells[2].Value.ToString());
            if(phieuDichVu.KTSoPhieuDV(sophieu))
            {
                phieuDichVu.ThemPhieuDichVu(sophieu, mabn, maphong, ngaylap);
            }
            phieuDichVu.ThemCTDV(sophieu, madv);
            phieuDichVu.CapNhatTongTien(sophieu, gia);
            int gt = int.Parse(phieuDichVu.LayTongTien(sophieu));
            txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", gt);
            lblTongTien.Text = phieuDichVu.ChuyenSo_chu(gt);
            phieuDichVu.DanhSachDV(dtgvDV, sophieu);
        }
    }
}
