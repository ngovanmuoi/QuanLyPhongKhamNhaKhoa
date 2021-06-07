using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLNguoiDung
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayThongTin(DataGridView dtgvTT)
        {            
            var nv = (from p in nhakhoa.NguoiDungs
                      join q in nhakhoa.NhanViens on p.MaNhanVien equals q.MaNhanVien
                      select new
                      {
                          p.MaNhanVien,
                          q.HoTen,
                          p.TenDangNhap,
                          p.TrangThai
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhân Viên");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Tên Đăng Nhập");
            dt.Columns.Add("Trạng Thái");
            foreach (var TD in nv)
            {
                dt.Rows.Add(TD.MaNhanVien.Trim(), TD.HoTen.Trim(), TD.TenDangNhap.Trim(), TD.TrangThai.Trim());
            }
            dtgvTT.DataSource = dt;
        }
    }
}
