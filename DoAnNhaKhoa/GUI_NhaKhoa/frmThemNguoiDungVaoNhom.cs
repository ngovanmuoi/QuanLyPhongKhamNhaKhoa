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
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        BLLNhomNguoiDung nhomNguoiDung = new BLLNhomNguoiDung();
        public string TenNhom { get; set; }
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadData()
        {
            nhomNguoiDung.LoadcbbTenNhom(cbbTenNhom);
            cbbTenNhom.Text = TenNhom;
            nhomNguoiDung.LayDanhSachNguoiDung(dtgvND);            
        }
        void ReLoad()
        {
            string MaNhom = nhomNguoiDung.LayMaNhomNguoiDung(cbbTenNhom.Text);
            nhomNguoiDung.LayDanhSachNguoiDungNhomNguoiDung(dtgvNDNND, MaNhom);
        }
        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbTenNhom_TextChanged(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenDN = dtgvND.CurrentRow.Cells[0].Value.ToString();
            string MaNhom = nhomNguoiDung.LayMaNhomNguoiDung(cbbTenNhom.Text);
            string GhiChu = txtGhiChu.Text;
            try
            {
                if (!nhomNguoiDung.KTTrung(TenDN, MaNhom))
                {
                    nhomNguoiDung.ThemNguoiDung(TenDN,MaNhom,GhiChu);
                    MessageBox.Show("Thêm người dùng vào nhóm thành công", "Thông báo");
                    ReLoad();
                }
                else
                {
                    MessageBox.Show("Người dùng đã ở trong nhóm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thêm người dùng vào nhóm thất bại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string TenDN = dtgvNDNND.CurrentRow.Cells[0].Value.ToString();
            string MaNhom = nhomNguoiDung.LayMaNhomNguoiDung(cbbTenNhom.Text);
            try
            {
                if (nhomNguoiDung.XoaNguoiDung(TenDN, MaNhom))
                {
                    MessageBox.Show("Xóa người dùng khỏi nhóm thành công", "Thông báo");
                    ReLoad();
                }
                else
                {
                    MessageBox.Show("Xóa người dùng khỏi nhóm thất bại", "Thông báo");
                }    
            }
            catch
            {
                MessageBox.Show("Xóa người dùng khỏi nhóm thất bại", "Thông báo");
            }
        }
    }
}
