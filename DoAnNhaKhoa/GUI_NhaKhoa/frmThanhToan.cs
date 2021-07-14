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
using DevExpress.XtraReports.UI;
using GUI_NhaKhoa.BLL_NhaKhoa;
namespace GUI_NhaKhoa
{
    public partial class frmThanhToan : Form
    {
        BLLThanhToan thanhToan = new BLLThanhToan();
        BLLPhieuDichVu phieuDichVu = new BLLPhieuDichVu();
        public frmThanhToan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            thanhToan.LayThongTinDV(dtgvDS);
            btnThanhToan.Enabled = false;
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoPhieuDV.Text = dtgvDS.CurrentRow.Cells[0].Value.ToString();
            txtMaBN.Text = dtgvDS.CurrentRow.Cells[1].Value.ToString();
            txtNgayLap.Text = dtgvDS.CurrentRow.Cells[4].Value.ToString();
            txtTongTien.Text = dtgvDS.CurrentRow.Cells[6].Value.ToString();
            int gt = int.Parse(txtTongTien.Text);
            txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", gt);
            richTongTien.Text = phieuDichVu.ChuyenSo_chu(gt);
            btnThanhToan.Enabled = true;
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            phieuDichVu.LayTTBenhNhan(txtMaBN.Text, txtHoTen, txtGioiTinh, txtNgaySinh, txtDiaChi, txtDT);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult print = MessageBox.Show("Bạn có muốn in hóa đơn","In hóa đơn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(print == DialogResult.Yes)
            {
                thanhToan.CapNhatThanhToan(txtSoPhieuDV.Text);
                LoadData();
                DataTable dt = new DataTable();
                dt = thanhToan.RPHoaDon(txtSoPhieuDV.Text);
                RPHoaDon hoaDon = new RPHoaDon();
                hoaDon.DataSource = dt;
                hoaDon.TongTien = txtTongTien.Text;
                hoaDon.ThanhToan = richTongTien.Text;
                hoaDon.ShowPreview();
            }
            if(print == DialogResult.No)
            {
                thanhToan.CapNhatThanhToan(txtSoPhieuDV.Text);
                LoadData();
                MessageBox.Show("Thanh toán dịch vụ thành công");
            }    
        }
    }
}
