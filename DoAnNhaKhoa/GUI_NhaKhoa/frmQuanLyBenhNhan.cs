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
    public partial class frmQuanLyBenhNhan : Form
    {
        BLLBenhNhan benhNhan = new BLLBenhNhan();
        public frmQuanLyBenhNhan()
        {
            InitializeComponent();
        }

        private void frmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            benhNhan.LayBenhNhan(dtgvDS);
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = false;

            this.txtMaBN.Enabled = false;
            this.txtMaThe.Enabled = false;
            this.txtHoTen.Enabled = false;
            this.cbbGioiTinh.Enabled = false;
            this.cbbNgaySinh.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtSDT.Enabled = false;
            this.txtEmail.Enabled = false;

            this.txtMaBN.ResetText();
            this.txtMaThe.ResetText();
            this.txtHoTen.ResetText();           
            this.cbbNgaySinh.ResetText();
            this.cbbGioiTinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtEmail.ResetText();
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBN.Text = dtgvDS.CurrentRow.Cells[0].Value.ToString();
            txtMaThe.Text = dtgvDS.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dtgvDS.CurrentRow.Cells[2].Value.ToString();
            cbbGioiTinh.Text = dtgvDS.CurrentRow.Cells[3].Value.ToString();
            cbbNgaySinh.Text = dtgvDS.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dtgvDS.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dtgvDS.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dtgvDS.CurrentRow.Cells[7].Value.ToString();

            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }
    }
}
