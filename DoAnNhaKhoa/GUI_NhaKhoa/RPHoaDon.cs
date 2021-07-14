using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI_NhaKhoa
{
    public partial class RPHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public string TongTien { get; set; }
        public string ThanhToan { get; set; }
        public RPHoaDon()
        {
            InitializeComponent();
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTongTien.Text = TongTien;
            lblThanhToan.Text = ThanhToan;
        }
        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTongTien.Text = TongTien;
            lblThanhToan.Text = ThanhToan;
        }
    }
}
