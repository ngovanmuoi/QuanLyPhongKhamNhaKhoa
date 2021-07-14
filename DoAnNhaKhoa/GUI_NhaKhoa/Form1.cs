using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_NhaKhoa.BLL_NhaKhoa;
namespace GUI_NhaKhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
            
            var nhom = from a in nhakhoa.PhieuKetQuas
                       where a.SoPhieuKQ == textBox1.Text
                       select new
                       {
                           a.HinhAnh
                       };
            foreach (var x in nhom)
            {
                pictureBox1.Image = ByteToImg(x.HinhAnh);
            }
        }
    }
}
