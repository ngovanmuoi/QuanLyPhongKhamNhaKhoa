using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLPhanQuyen
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayDanhSachNhomND(DataGridView dtgvTT)
        {
            var nd = (from p in nhakhoa.NhomNguoiDungs
                      select new
                      {
                          p.MaNhom,
                          p.TenNhom,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhóm Người Dùng");
            dt.Columns.Add("Tên Nhóm Người Dùng");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.MaNhom.Trim(), TD.TenNhom.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public void LayDanhSachPhanQuyen(DataGridView dtgv)
        {
            var quyen = (from p in nhakhoa.ManHinhs
                         join q in nhakhoa.PhanQuyens on p.MaManHinh equals q.MaManHinh
                         select new
                      {
                          p.MaManHinh,
                          p.TenManHinh,
                          q.CoQuyen,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaManHinh");
            dt.Columns.Add("TenManHinh");
            dt.Columns.Add("CoQuyen");
            foreach (var TD in quyen)
            {
                dt.Rows.Add(TD.MaManHinh.Trim(), TD.TenManHinh.Trim(), TD.CoQuyen.Trim());
            }
            dtgv.DataSource = dt;
        }
    }
}
