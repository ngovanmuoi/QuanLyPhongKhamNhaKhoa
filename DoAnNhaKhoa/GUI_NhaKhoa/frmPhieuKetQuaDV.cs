using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI_NhaKhoa.BLL_NhaKhoa;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public partial class frmPhieuKetQuaDV : Form
    {
        BLLPhieuKham phieuKham = new BLLPhieuKham();
        BLLPhieuKetQua phieuKetQua = new BLLPhieuKetQua();
        bool them = false;
        public string SoPhieu { get; set; }
        public frmPhieuKetQuaDV()
        {
            InitializeComponent();
        }

        private void btnThemFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }    
        }
        
        public string LaySoPhieuTuTang()
        {
            DataTable dt = phieuKetQua.LayDanhPhieuKQ();
            int count = dt.Rows.Count;
            string phieu = "";
            string soPhieuMoi = "";
            int soPhieu = 0;
            if (count == 0)
            {
                return "PKQ001";
            }
            else if (count != 0)
            {
                phieu = dt.Rows[count - 1][0].ToString();
                soPhieu = Convert.ToInt32((phieu.Remove(0, 3)));
                if (soPhieu + 1 < 10)
                {
                    soPhieuMoi = "PQK00" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 100)
                {
                    soPhieuMoi = "PQK0" + (soPhieu + 1).ToString();
                }
                else if (soPhieu + 1 < 1000)
                {
                    soPhieuMoi = "PQK" + (soPhieu + 1).ToString();
                }
                return soPhieuMoi;
            }
            return soPhieuMoi;
        }
        byte[] ImagetoByte(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richKetQua.Text.Trim()))
            {
                MessageBox.Show("Chưa kết luận");
                this.richKetQua.Focus();
                return;
            }
            if (them)
            {
                string sophieu = LaySoPhieuTuTang();
                
                if (pictureBox2.Image== null)
                {
                    phieuKetQua.ThemPhieuKhongHinh(sophieu, cbbTenDV.Text, richKetQua.Text, txtSoPhieu.Text);
                    MessageBox.Show("Lưu thành công", "Thông Báo");
                    phieuKetQua.CapNhatTrangThaiPhieu(txtSoPhieu.Text);
                    LoadData();
                }
                else
                {
                    byte[] b = ImagetoByte(pictureBox2.Image);
                    var str = Convert.ToBase64String(b);
                    phieuKetQua.ThemPhieuKQ(sophieu, cbbTenDV.Text, str, richKetQua.Text, txtSoPhieu.Text);
                    MessageBox.Show("Lưu thành công", "Thông Báo");
                    phieuKetQua.CapNhatTrangThaiPhieu(txtSoPhieu.Text);
                    LoadData();
                }
            }   
            else
            {
                byte[] b = ImagetoByte(pictureBox2.Image);
                var str = Convert.ToBase64String(b);
                phieuKetQua.SuaPhieuKQ(cbbTenDV.Text, str, richKetQua.Text, txtSoPhieu.Text);
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadData();
            }    
        }

        private void frmPhieuKetQuaDV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            txtSoPhieu.Text = SoPhieu;
            txtMaBN.Text = phieuKetQua.LayMaBN(SoPhieu);
            phieuKham.LayTTBenhNhan(txtMaBN.Text, txtMaThe, txtHoTen, txtGioiTinh, txtNgaySinh, txtDiaChi, txtDT, txtEmail);
            string sophieukham = phieuKetQua.LaySoPhieu(txtSoPhieu.Text);
            phieuKetQua.LayTTPhieuKham(sophieukham, txtChuanDoan, txtKetLuan, txtTieuDuong, txtHuyetAp, txtTim);
            phieuKetQua.LoadcbbTenDV(cbbTenDV, txtSoPhieu.Text);
            richKetQua.Enabled = false;
            btnThemFile.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            richKetQua.Enabled = true;
            richKetQua.ReadOnly = false;
            btnThemFile.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void cbbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            phieuKetQua.LayThongTinKetQua(cbbTenDV.Text, SoPhieu, richKetQua, pictureBox2);
            if(string.IsNullOrEmpty(richKetQua.Text.Trim()))
            {
                btnThucHien.Enabled = true;
                btnSua.Enabled = false;
                richKetQua.ReadOnly = true;

            }
            else
            {
                btnThucHien.Enabled = false;
                btnSua.Enabled = true;
                richKetQua.ReadOnly = false;
            }    
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            them = true;
            btnThemFile.Enabled = true;
            btnLuu.Enabled = true;
            richKetQua.ReadOnly = false;
            richKetQua.Enabled = true;
        }

        private void cbbTenDV_TextChanged(object sender, EventArgs e)
        {
            phieuKetQua.LayThongTinKetQua(cbbTenDV.Text, SoPhieu, richKetQua, pictureBox2);
            if (string.IsNullOrEmpty(richKetQua.Text.Trim()))
            {
                btnThucHien.Enabled = true;
                btnSua.Enabled = false;
                richKetQua.ReadOnly = true;
            }
            else
            {
                btnThucHien.Enabled = false;
                btnSua.Enabled = true;
                richKetQua.ReadOnly = false;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            phieuKetQua.CapNhatTrangThaiPhieu(txtSoPhieu.Text);
            int a = phieuKetQua.DemCTPhieuDV(txtSoPhieu.Text);
            int b = phieuKetQua.DemPhieuKQ(txtSoPhieu.Text);
            if(a == b)
                MessageBox.Show("OK");
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
