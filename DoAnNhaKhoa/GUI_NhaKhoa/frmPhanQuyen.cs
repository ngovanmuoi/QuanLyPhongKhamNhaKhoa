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
    public partial class frmPhanQuyen : Form
    {
        BLLPhanQuyen phanQuyen = new BLLPhanQuyen();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            phanQuyen.LayDanhSachNhomND(dtgvDS);
        }
        
        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string manhom = dtgvDS.CurrentRow.Cells[0].Value.ToString();            
            phanQuyen.LayDanhSachPhanQuyen(dtgvQuyen, manhom);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {          
            try
            {
                string nhomnguoidung = dtgvDS.CurrentRow.Cells[0].Value.ToString();
                string mamh = dtgvQuyen.CurrentRow.Cells[0].Value.ToString();
                bool quyen = Convert.ToBoolean(dtgvQuyen.CurrentRow.Cells[2].Value.ToString());
                foreach (DataGridViewRow item in dtgvQuyen.Rows)
                {                 
                    try
                    {
                        if (phanQuyen.LuuPhanQuyen(nhomnguoidung, mamh, quyen))
                        {
                            //MessageBox.Show("Lưu thành công", "Thông báo");
                            phanQuyen.LayDanhSachPhanQuyen(dtgvQuyen, nhomnguoidung);
                        }
                        else
                            //MessageBox.Show("Lưu thất bại", "Thông báo");
                            phanQuyen.LayDanhSachPhanQuyen(dtgvQuyen, nhomnguoidung);
                    }
                    catch
                    {
                        //MessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void dtgvQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
