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
        bool them = false;
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
            this.grTimKiem.Enabled = true;

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
        public string LayMaBNTuTang()
        {
            int count = dtgvDS.Rows.Count;
            string ma = "";
            string mamoi = "";
            int manv = 0;
            ma = Convert.ToString(dtgvDS.Rows[count - 1].Cells[0].Value);
            manv = Convert.ToInt32((ma.Remove(0, 2)));
            if (manv + 1 < 10)
            {
                mamoi = "BN00" + (manv + 1).ToString();
            }
            else if (manv + 1 < 100)
            {
                mamoi = "BN0" + (manv + 1).ToString();
            }
            else if (manv + 1 < 1000)
            {
                mamoi = "BN" + (manv + 1).ToString();
            }
            return mamoi;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            string manvmoi = LayMaBNTuTang();
            txtMaBN.Text = manvmoi;

            this.txtMaThe.ResetText();
            this.txtHoTen.ResetText();
            this.cbbNgaySinh.ResetText();
            this.cbbGioiTinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtEmail.ResetText();

            this.txtMaBN.Enabled = false;
            this.txtMaThe.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.cbbGioiTinh.Enabled = true;
            this.cbbNgaySinh.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtEmail.Enabled = true;

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.grTimKiem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa;
            xoa = MessageBox.Show("Bạn có chắc muốn xóa bệnh nhân này chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (benhNhan.XoaBN(txtMaBN.Text))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                        LoadData();
                        benhNhan.LayBenhNhan(dtgvDS);
                    }
                    else
                    {
                        MessageBox.Show("Xóa bệnh nhân thất bại", "Thông Báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            this.txtMaBN.Enabled = false;
            this.txtMaThe.Enabled = true;
            this.txtHoTen.Enabled = true;
            this.cbbGioiTinh.Enabled = true;
            this.cbbNgaySinh.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtEmail.Enabled = true;

            this.btnLuu.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (them)
                {
                    try
                    {
                        //if (benhNhan.KTTrungMaThe(txtMaThe.Text.Trim().ToString()))
                        //{
                        //    MessageBox.Show("Mã thẻ trùng với bệnh nhân khác", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        //}
                        //else
                        //{
                            benhNhan.ThemBN(txtMaBN.Text, txtMaThe.Text, txtHoTen.Text, cbbGioiTinh.Text, cbbNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                            MessageBox.Show("Thêm bệnh nhân thành công");
                            LoadData();
                            benhNhan.LayBenhNhan(dtgvDS);
                        //}
                    }
                    catch
                    {
                        MessageBox.Show("Thêm bệnh nhân thất bại");
                    }

                }
                else
                {
                    try
                    {
                        benhNhan.SuaBN(txtMaBN.Text, txtMaThe.Text, txtHoTen.Text, cbbGioiTinh.Text, cbbNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text);
                        MessageBox.Show("Sửa thông tin nhân viên thành công");
                        LoadData();
                        benhNhan.LayBenhNhan(dtgvDS);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thông tin bệnh nhân thất bại");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtTimKiem.ResetText();
            this.cbbLocGT.Text = "Tất Cả";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtTimKiem.ResetText();
            this.cbbLocGT.Text = "Tất Cả";
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                benhNhan.Loc(cbbLocGT, txtTimKiem, dtgvDS);
                if (txtTimKiem.Text == "" && cbbLocGT.Text == "Tất Cả")
                {
                    LoadData();
                }
            }
            catch
            {

            }
        }

        private void cbbLocGT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                benhNhan.Loc(cbbLocGT, txtTimKiem, dtgvDS);
                if (txtTimKiem.Text == "" && cbbLocGT.Text == "Tất Cả")
                {
                    LoadData();
                }
            }
            catch
            {

            }
        }
    }
}
