using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLLPhanQuyen phanQuyen = new BLLPhanQuyen();

        public string TenNV { get; set; }
        public string Quyen { get; set; }
        public string TK { get; set; }
        public string TTin { get; set; }
        public string TenDN { get; set; }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            lblTenNV.Caption = TenNV;
            lblQuyen.Caption = Quyen;
            lblTaiKhoan.Caption = TenDN;
            LoadData();
            List<string> nhomND = phanQuyen.GetMaNhomNguoiDung(TenDN);

            foreach (string item in nhomND)
            {
                DataTable dsQuyen = phanQuyen.GetMaManHinh2(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.ribbon.Pages, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));
                    FindMenuGroupPhanQuyen(this.ribbHeThong.Groups, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }

            frmWellcome frm = new frmWellcome();
            frm.MdiParent = this;
            frm.Show();
            this.ClientSize = new Size(frm.Size.Width, frm.Size.Height + 190);

        }
        public void DongTatCaCacTab()
        {
            for (int i = xtraTabbedMdiManager1.Pages.Count - 1; i >= 0; i--)
            {
                xtraTabbedMdiManager1.Pages[i].MdiChild.Close();
            }
        }
        void LoadData()
        {
            //if (lblQuyen.Caption == "Lễ Tân")
            //{
            //    ribbQuanLy.Visible = false;
            //    ribbThongKe.Visible = false;
            //    ribbThuNgan.Visible = false;
            //    ribbThuNgan.Enabled = false;
            //    ribbBacSi.Visible = false;
            //    ribbBacSi.Enabled = false;
            //}
        }
        private void btnTiepDonBenNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();
            frmTiepDonBenhNhan tiepDonBenhNhan = new frmTiepDonBenhNhan();
            tiepDonBenhNhan.TiepDon = lblTenNV.Caption;
            tiepDonBenhNhan.MdiParent = this;
            tiepDonBenhNhan.Show();

        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn đăng xuất tài khoản này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
                this.Close();
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát khỏi chương trình hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQLTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNguoiDung nguoiDung = new frmNguoiDung();
            nguoiDung.MdiParent = this;
            nguoiDung.Show();
        }

        private void btnQLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();
            int dai = 0;
            int rong = 0;
            frmQuanLyNhanVien nhanVien = new frmQuanLyNhanVien();
            rong = nhanVien.Size.Width;
            dai = nhanVien.Size.Height;
            nhanVien.MdiParent = this;
            nhanVien.Show();
            this.ClientSize = new Size(rong, dai + 190);
        }

        private void btnQLNhomNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();
            frmNhomNguoiDung nhomNguoiDung = new frmNhomNguoiDung();
            nhomNguoiDung.MdiParent = this;
            nhomNguoiDung.Show();
        }

        private void btnDMManHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();
            frmManHinh manHinh = new frmManHinh();
            manHinh.MdiParent = this;
            manHinh.Show();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();            
            frmPhanQuyen phanQuyen = new frmPhanQuyen();
            phanQuyen.MdiParent = this;
            phanQuyen.Show();
        }

        private void FindMenuPhanQuyen(RibbonPageCollection items, string pScreenName, bool pEnable)
        {
            foreach (RibbonPage menu in items)
            {
                if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Visible = pEnable;
                }

            }
        }
        private void FindMenuGroupPhanQuyen(RibbonPageGroupCollection items, string pScreenName, bool pEnable)
        {
            foreach (RibbonPageGroup menu in items)
            {
                if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Visible = pEnable;
                }

            }
        }

        private void btnQLBenhNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            DongTatCaCacTab();
            int dai = 0;
            int rong = 0;
            frmQuanLyBenhNhan benhNhan = new frmQuanLyBenhNhan();
            rong = benhNhan.Size.Width;
            dai = benhNhan.Size.Height;
            benhNhan.MdiParent = this;
            benhNhan.Show();
            this.ClientSize = new Size(rong, dai + 190);
        }
    }
}