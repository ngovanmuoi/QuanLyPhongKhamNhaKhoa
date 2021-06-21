using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI_NhaKhoa
{
    public partial class RPPhieuDangKyKham : DevExpress.XtraReports.UI.XtraReport
    {
        public string NguoiLap { get; set; }
        public RPPhieuDangKyKham()
        {
            InitializeComponent();
        }        
        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblNguoiLap.Text = NguoiLap;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblNguoiLap.Text = NguoiLap;
        }
    }
}
