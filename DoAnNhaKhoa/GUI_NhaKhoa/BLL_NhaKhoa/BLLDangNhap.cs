using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLDangNhap
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public int LayTaiKhoan(string user, string password)
        {
            password = MaHoa(password);
            var tk = (from x in nhakhoa.NguoiDungs
                      where x.TenDangNhap.Trim() == user && x.MatKhau.Trim() == password
                      select x).ToList();
            int a = tk.Count();
            return a;
        }
        public string LayTrangThai(string user, string password)
        {
            password = MaHoa(password);
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
        public string MaHoa(string MK)
        {
            string str = "";
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(MK);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            str = hasPass.Substring(0, 8);
            return str;
        }
    }
}
