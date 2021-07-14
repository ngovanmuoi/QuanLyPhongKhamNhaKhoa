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
    public partial class frmPhongDichVu : Form
    {
        BLLPhongDichVu phongDichVu = new BLLPhongDichVu();
        public frmPhongDichVu()
        {
            InitializeComponent();
        }

        private void rbtnTatCa_CheckedChanged(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            cbbNgayKham.Text = DateTime.Now.ToString("dd/MM/yyyy");
            phongDichVu.LayPhongDichVu(cbbPhongKham);
        }
        private void frmPhongDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbPhongKham_TextChanged(object sender, EventArgs e)
        {
            string maPhong = phongDichVu.LayMaPhong(cbbPhongKham.Text);
            phongDichVu.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoTH, rbtnDaTH, rbtnTatCa);
            lblTenPhong.Text = "PHÒNG THỰC HIỆN DỊCH VỤ - " + cbbPhongKham.Text;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rbtnChoTH_CheckedChanged(object sender, EventArgs e)
        {
            string maPhong = phongDichVu.LayMaPhong(cbbPhongKham.Text);
            phongDichVu.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoTH, rbtnDaTH, rbtnTatCa);
        }

        private void rbtnDaTH_CheckedChanged(object sender, EventArgs e)
        {
            string maPhong = phongDichVu.LayMaPhong(cbbPhongKham.Text);
            phongDichVu.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoTH, rbtnDaTH, rbtnTatCa);
        }

        private void rbtnTatCa_CheckedChanged_1(object sender, EventArgs e)
        {
            string maPhong = phongDichVu.LayMaPhong(cbbPhongKham.Text);
            phongDichVu.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoTH, rbtnDaTH, rbtnTatCa);
        }

        private void dtgvTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvTT.Columns[e.ColumnIndex].Name == "Column4")
            {
                frmPhieuKetQuaDV phieuKetQua = new frmPhieuKetQuaDV();
                phieuKetQua.SoPhieu = dtgvTT.CurrentRow.Cells[1].Value.ToString();
                phieuKetQua.ShowDialog();
            }
        }

        private void cbbNgayKham_TextChanged(object sender, EventArgs e)
        {
            string maPhong = phongDichVu.LayMaPhong(cbbPhongKham.Text);
            phongDichVu.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoTH, rbtnDaTH, rbtnTatCa);
        }
    }
}
