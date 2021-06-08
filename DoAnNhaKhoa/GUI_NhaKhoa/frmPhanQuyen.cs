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
            phanQuyen.LayDanhSachPhanQuyen(dtgvQuyen);
        }
    }
}
