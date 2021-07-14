using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using GUI_NhaKhoa.BLL_NhaKhoa;

namespace GUI_NhaKhoa
{
    public partial class frmQuanLyNhanVien : Form
    {
        BLLNhanVien nhanVien = new BLLNhanVien();

        bool them = false;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.txtHoTen.Enabled = true;
            this.cbbGioiTinh.Enabled = true;
            this.cbbNgaySinh.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.cbbNgayVL.Enabled = true;
            this.txtLuongCB.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
        }
        void LoadData()
        {
            nhanVien.LayNhanVien(dtgvDS);
            nhanVien.LoadDiaChi(cbbDiaChi);
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = false;

            this.txtHoTen.Enabled = false;
            this.cbbGioiTinh.Enabled = false;
            this.cbbNgaySinh.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtSDT.Enabled = false;
            this.cbbNgayVL.Enabled = false;
            this.txtLuongCB.Enabled = false;

            this.txtDiaChi.ResetText();
            this.txtHoTen.ResetText();
            this.txtLuongCB.ResetText();
            this.txtMaNV.ResetText();
            this.cbbNgaySinh.ResetText();
            this.cbbNgayVL.ResetText();
            this.cbbGioiTinh.ResetText();
            this.txtSDT.ResetText();
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvDS.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dtgvDS.CurrentRow.Cells[1].Value.ToString();
            cbbGioiTinh.Text = dtgvDS.CurrentRow.Cells[2].Value.ToString();
            cbbNgaySinh.Text = dtgvDS.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dtgvDS.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dtgvDS.CurrentRow.Cells[5].Value.ToString();
            cbbNgayVL.Text = dtgvDS.CurrentRow.Cells[6].Value.ToString();
            txtLuongCB.Text = dtgvDS.CurrentRow.Cells[7].Value.ToString();

            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtTimKiem.ResetText();
            this.cbbLocGT.Text = "Tất Cả";
            this.cbbDiaChi.Text = "Tất Cả";
        }

        public string LayMaNVTuTang()
        {
            int count = dtgvDS.Rows.Count;
            string ma = "";
            string mamoi = "";
            int manv = 0;
            ma = Convert.ToString(dtgvDS.Rows[count -1].Cells[0].Value);
            manv = Convert.ToInt32((ma.Remove(0, 2)));
            if (manv + 1 < 10)
            {
                mamoi = "NV00" + (manv + 1).ToString();
            }
            else if (manv + 1 < 100)
            {
                mamoi = "NV0" + (manv + 1).ToString();
            }
            else if (manv + 1 < 1000)
            {
                mamoi = "NV" + (manv + 1).ToString();
            }
            return mamoi;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            string manvmoi = LayMaNVTuTang();
            txtMaNV.Text = manvmoi;

            
            this.txtHoTen.ResetText();
            this.cbbGioiTinh.ResetText();
            this.cbbNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.cbbNgayVL.ResetText();
            this.txtLuongCB.ResetText();
            this.txtSDT.ResetText();
            this.txtHoTen.Focus();

            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtHoTen.Enabled = true;
            this.cbbGioiTinh.Enabled = true;
            this.cbbNgaySinh.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.cbbNgayVL.Enabled = true;
            this.txtLuongCB.Enabled = true;
            this.cbbNgayVL.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa;
            xoa = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (nhanVien.XoaNV(txtMaNV.Text))
                    {
                        LoadData();
                        nhanVien.LayNhanVien(dtgvDS);
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại", "Thông Báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi", "Thông báo");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try 
            {
                if (them)
                {
                    try
                    {
                        nhanVien.ThemNV(txtMaNV.Text, txtHoTen.Text, cbbGioiTinh.Text, cbbNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, cbbNgayVL.Text, txtLuongCB.Text);
                        LoadData();
                        nhanVien.LayNhanVien(dtgvDS);
                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }

                }
                else
                {
                    try
                    {
                        nhanVien.SuaNV(txtMaNV.Text, txtHoTen.Text, cbbGioiTinh.Text, cbbNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, cbbNgayVL.Text, txtLuongCB.Text);
                        LoadData();
                        nhanVien.LayNhanVien(dtgvDS);
                        MessageBox.Show("Sửa thông tin nhân viên thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nhanVien.Loc(cbbDiaChi, cbbLocGT, txtTimKiem, dtgvDS);
                if (txtTimKiem.Text == "" && cbbDiaChi.Text == "Tất Cả" && cbbLocGT.Text == "Tất Cả")
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
                nhanVien.Loc(cbbDiaChi, cbbLocGT, txtTimKiem, dtgvDS);
                if (txtTimKiem.Text == "" && cbbDiaChi.Text == "Tất Cả" && cbbLocGT.Text == "Tất Cả")
                {
                    LoadData();
                }
            }
            catch
            {

            }
        }

        private void cbbDiaChi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nhanVien.Loc(cbbDiaChi, cbbLocGT, txtTimKiem, dtgvDS);
                if (txtTimKiem.Text == "" && cbbDiaChi.Text == "Tất Cả" && cbbLocGT.Text == "Tất Cả")
                {
                    LoadData();
                }
            }
            catch
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtTimKiem.ResetText();
            this.cbbLocGT.Text = "Tất Cả";
            this.cbbDiaChi.Text = "Tất Cả";
        }
        private bool exportExcel(DataGridView dtgv, string plink, string pFileName)
        {
            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < dtgv.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = dtgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv.Columns.Count; j++)
                    {
                        if (dtgv.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(plink + pFileName + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            bool xuat = exportExcel(dtgvDS, @"E:\Phat Trien Phan Mem\QuanLyPhongKhamNhaKhoa\", "DanhSachNhanVien");
            if (xuat)
            {
                MessageBox.Show("Xuất file thàng công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xuất file thất bại", "Thông báo");
            }    
        }
    }
}
