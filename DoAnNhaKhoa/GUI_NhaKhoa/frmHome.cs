using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            int dai = 0;
            int rong = 0;
            frmTiepDonBenhNhan frm = new frmTiepDonBenhNhan();
            rong = frm.Size.Width;
            dai = frm.Size.Height;
            frm.MdiParent = this;
            frm.Show();
            this.ClientSize = new Size(rong, dai + 190);
        }

        private void btnTiepDonBenNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int dai = 0;
            int rong = 0;
            frmTiepDonBenhNhan frm = new frmTiepDonBenhNhan();
            rong = frm.Size.Width;
            dai = frm.Size.Height;
            frm.MdiParent = this;
            frm.Show();
            this.ClientSize = new Size(rong, dai + 190);
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
    }
}