using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLTiepDonBenhNhan
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public DataTable LayBenhNhan()
        {
            var bn = (from a in nhakhoa.BenhNhans
                      select new
                      {
                          a.MaBenhNhan,
                          a.MaThe,
                          a.HoTen,
                          a.GioiTinh,
                          a.NgaySinh,
                          a.DiaChi,
                          a.SDT,
                          a.Email
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaBenhNhan");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("SDT");
            DateTime.Now.Date.ToShortDateString();
            foreach (var bn1 in bn)
            {
                dt.Rows.Add(bn1.MaBenhNhan.Trim(), bn1.HoTen.Trim(), bn1.GioiTinh.Trim(), DateTime.Parse(bn1.NgaySinh.ToString()).Date.ToShortDateString(), bn1.SDT.Trim());
            }
            return dt;
        }
        public string LayHoTen(string pMaBN)
        {
            string ten = "";
            var Tennv = (from p in nhakhoa.BenhNhans
                         where p.MaBenhNhan.Trim() == pMaBN
                         select new
                         {
                             p.HoTen
                         }).ToList();
            if (Tennv.Count() != 0)
            {
                foreach (var a in Tennv)
                    ten = a.HoTen;
            }
            return ten;
        }
        public void LayTTBenhNhan(string pMaBN, TextBox txtMaThe, TextBox txtHoten, ComboBox cbbGioiTinh, TextBox txtNgaySinh, TextBox txtDiaChi, TextBox txtSDT)
        {
            var Tennv = (from p in nhakhoa.BenhNhans
                         where p.MaBenhNhan.Trim() == pMaBN
                         select new
                         {
                             p.MaThe,
                             p.HoTen,
                             p.NgaySinh,
                             p.GioiTinh,
                             p.SDT,
                             p.DiaChi
                         }).ToList();
            if (Tennv.Count() != 0)
            {
                foreach (var a in Tennv)
                {
                    txtMaThe.Text = a.MaThe;
                    txtHoten.Text = a.HoTen;
                    txtNgaySinh.Text = DateTime.Parse(a.NgaySinh.ToString()).Date.ToShortDateString();
                    cbbGioiTinh.Text = a.GioiTinh;
                    txtDiaChi.Text = a.DiaChi;
                    txtSDT.Text = a.SDT;
                }    
                    
                
            }
        }
    }
}
