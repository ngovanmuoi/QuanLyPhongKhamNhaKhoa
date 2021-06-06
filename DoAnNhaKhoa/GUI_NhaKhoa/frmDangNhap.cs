using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_NhaKhoa;
namespace GUI_NhaKhoa
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLLTaiKhoan bllTK = new BLLTaiKhoan();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllTK.LayTaiKhoan(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()) == 1 && bllTK.LayTrangThai(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    frmHome home = new frmHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, kiểm tra lại tài khoản và mật khẩu", "Thông báo");
                }    
            }
            catch
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
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