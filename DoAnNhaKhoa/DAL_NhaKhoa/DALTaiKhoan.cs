using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NhaKhoa
{
    public class DALTaiKhoan
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        
        public DALTaiKhoan()
        { }

        public int LayTaiKhoan(string taikhoan, string matkhau)
        {
            var tk = (from x in nhakhoa.QL_NguoiDungs
                            where x.TenDangNhap.Trim() == taikhoan && x.MatKhau.Trim() == matkhau
                            select x).ToList();
            return tk.Count();
        }

        public bool? LayTrangThai(string taikhoan, string matkhau)
        {
            bool? trangthai = false;
            var tk = (from x in nhakhoa.QL_NguoiDungs
                      where x.TenDangNhap.Trim() == taikhoan && x.MatKhau.Trim() == matkhau
                      select new
                      {
                          x.HoatDong
                      }).ToList();
            if (tk.Count() != 0)
            {
                foreach (var item in tk)
                    trangthai = item.HoatDong;
            }
            return trangthai;
        }

    }
}
