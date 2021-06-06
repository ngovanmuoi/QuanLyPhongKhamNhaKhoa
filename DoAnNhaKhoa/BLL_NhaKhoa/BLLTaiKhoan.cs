using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NhaKhoa;
using System.Data;
namespace BLL_NhaKhoa
{
    public class BLLTaiKhoan
    {
        DALTaiKhoan dal = new DALTaiKhoan();
        public BLLTaiKhoan()
        { }

        public int LayTaiKhoan(string taikhoan, string matkhau)
        {
            return dal.LayTaiKhoan(taikhoan, matkhau);
        }

        public bool? LayTrangThai(string taikhoan, string matkhau)
        {
            return dal.LayTrangThai(taikhoan, matkhau);
        }
    }
}
