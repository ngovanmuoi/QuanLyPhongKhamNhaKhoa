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
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        void LoadData()
        {            
            nguoiDung.LayThongTin(dtgvDS);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            this.txtMaNV.Enabled = false;
            this.txtMatKhau.Enabled = false;
            this.txtTenDN.Enabled = false;
            this.cbbHoTen.Enabled = true;
            this.cbbTrangThai.Enabled = false;

            this.txtMatKhau.ResetText();
            this.txtMaNV.ResetText();
            this.cbbTrangThai.ResetText();
            this.txtTenDN.ResetText();
            this.cbbHoTen.ResetText();           
            this.txtMaNV.Enabled = false;
            this.cbbHoTen.Enabled = false;
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
