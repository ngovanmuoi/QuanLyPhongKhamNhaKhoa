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
    public partial class frmPhongKham : Form
    {
        BLLPhongKham phongKham = new BLLPhongKham();
        public frmPhongKham()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            cbbNgayKham.Text = DateTime.Now.ToString("dd/MM/yyyy");
            phongKham.LayPhongKham(cbbPhongKham);
            //phongKham.LayThongTin(dtgvTT, "20/06/2021", "PK001");
        }
        private void frmPhongKham_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void cbbNgayKham_EditValueChanged(object sender, EventArgs e)
        {
            //phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, cbbPhongKham.Text);
        }

        private void cbbPhongKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, cbbPhongKham.Text);
        }

        private void cbbNgayKham_TextChanged(object sender, EventArgs e)
        {
            string maPhong = phongKham.LayMaPhongKham(cbbPhongKham.Text);
            phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoKham, rbtnDaKham, rbtnTatCa);
        }

        private void cbbPhongKham_TextChanged(object sender, EventArgs e)
        {
            string maPhong = phongKham.LayMaPhongKham(cbbPhongKham.Text);
            phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoKham, rbtnDaKham, rbtnTatCa);
            lblTenPhong.Text = "PHÒNG CHỜ KHÁM BỆNH - "+cbbPhongKham.Text;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtnChoKham_CheckedChanged(object sender, EventArgs e)
        {
            string maPhong = phongKham.LayMaPhongKham(cbbPhongKham.Text);
            phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoKham, rbtnDaKham, rbtnTatCa);
        }

        private void rbtnDaKham_CheckedChanged(object sender, EventArgs e)
        {
            string maPhong = phongKham.LayMaPhongKham(cbbPhongKham.Text);
            phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoKham, rbtnDaKham, rbtnTatCa);
        }

        private void rbtnTatCa_CheckedChanged(object sender, EventArgs e)
        {
            string maPhong = phongKham.LayMaPhongKham(cbbPhongKham.Text);
            phongKham.LayThongTin(dtgvTT, cbbNgayKham.Text, maPhong, rbtnChoKham, rbtnDaKham, rbtnTatCa);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvTT.Columns[e.ColumnIndex].Name == "Column4")
            {
                frmPhieuKhamBenh phieuKhamBenh = new frmPhieuKhamBenh();

                phieuKhamBenh.SoPhieu = dtgvTT.CurrentRow.Cells[1].Value.ToString();
                phieuKhamBenh.LoaiKham = dtgvTT.CurrentRow.Cells[3].Value.ToString();
                phieuKhamBenh.NgayKham = cbbNgayKham.Text;
                phieuKhamBenh.PhongKham = cbbPhongKham.Text;
                phieuKhamBenh.ShowDialog();
            }    
        }
    }
}
