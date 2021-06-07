using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLDangNhap
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public int LayTaiKhoan(string user, string password)
        {           
            
            var tk = (from x in nhakhoa.NguoiDungs
                      where x.TenDangNhap.Trim() == user && x.MatKhau.Trim() == password
                      select x).ToList();
            int a = tk.Count();
            return a;
        }
        public string LayTrangThai(string user, string password)
        {
            string b = "";
            var Tennv = (from p in nhakhoa.NguoiDungs
                         where p.TenDangNhap.Trim() == user && p.MatKhau.Trim() == password
                         select new
                         {
                             p.TrangThai
                         }).ToList();
            if (Tennv.Count() != 0)
            {
                foreach (var a in Tennv)
                    b = a.TrangThai;
            }
            return b;
        }
    }
}
