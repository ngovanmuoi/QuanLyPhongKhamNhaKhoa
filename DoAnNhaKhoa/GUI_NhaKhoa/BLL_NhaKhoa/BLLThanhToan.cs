using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLThanhToan
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayThongTinDV(DataGridView dtgvTT)
        {
            var TT = (from a in nhakhoa.PhieuDichVus
                      join b in nhakhoa.BenhNhans on a.MaBenhNhan equals b.MaBenhNhan
                      join c in nhakhoa.PhongKhams on a.MaPhong equals c.MaPhong
                      where a.ThanhToan == "Chưa Thanh Toán"
                      select new
                      {
                          a.SoPhieuDV,
                          a.MaBenhNhan,
                          b.HoTen,
                          c.TenPhong,
                          a.NgayLap,
                          a.TinhTrang,
                          a.TongTien
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu");
            dt.Columns.Add("Mã Bệnh Nhân");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Tình Trạng");
            dt.Columns.Add("Tổng Tiền");
            foreach (var TD in TT)
            {
                dt.Rows.Add(TD.SoPhieuDV.Trim(), TD.MaBenhNhan.Trim(), TD.HoTen, TD.TenPhong.Trim(), DateTime.Parse(TD.NgayLap.ToString()).Date.ToShortDateString(), TD.TinhTrang.Trim(), TD.TongTien);
            }
            dtgvTT.DataSource = dt;
        }
        public void CapNhatThanhToan(string pSoPhieuDv)
        {
            var tt = (from a in nhakhoa.PhieuDichVus where a.SoPhieuDV == pSoPhieuDv select a).SingleOrDefault();
            if (tt != null)
            {
                tt.ThanhToan = "Đã Thanh Toán";
                nhakhoa.SubmitChanges();
            }
        }
        public DataTable RPHoaDon(string pSoPhieu)
        {
            var ds = (from a in nhakhoa.PhieuDichVus
                      join b in nhakhoa.BenhNhans on a.MaBenhNhan equals b.MaBenhNhan
                      join c in nhakhoa.PhongKhams on a.MaPhong equals c.MaPhong
                      join d in nhakhoa.CTPhieuDichVus on a.SoPhieuDV equals d.SoPhieuDV
                      join e in nhakhoa.DichVus on d.MaDV equals e.MaDV
                      where (a.SoPhieuDV == pSoPhieu)
                      select new
                      {
                          a.SoPhieuDV,
                          a.NgayLap,
                          b.HoTen,
                          b.GioiTinh,
                          b.NgaySinh,
                          b.MaThe,
                          b.DiaChi,
                          b.SDT,
                          b.Email,
                          c.TenPhong,
                          e.TenDV,
                          e.DonGia,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("SoPhieu");
            dt.Columns.Add("NgayLap");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("MaThe");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("TenPhong");
            dt.Columns.Add("TenDV");
            dt.Columns.Add("DonGia");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.SoPhieuDV.Trim(), DateTime.Parse(TD.NgayLap.ToString()).Date.ToShortDateString(), TD.HoTen.Trim(), TD.GioiTinh.Trim(),
                    DateTime.Parse(TD.NgaySinh.ToString()).Date.ToShortDateString(), TD.MaThe.Trim(), TD.DiaChi.Trim(), TD.SDT.Trim(), TD.Email.Trim(),
                    TD.TenPhong.Trim(), TD.TenDV.Trim(), TD.DonGia);
            }
            return dt;
        }
        public DataTable RPCTDV(string pSoPhieu)
        {
            var ds = (from b in nhakhoa.CTPhieuDichVus
                      join c in nhakhoa.DichVus on b.MaDV equals c.MaDV
                      where (b.SoPhieuDV == pSoPhieu)
                      select new
                      {
                          c.TenDV,
                          c.DonGia,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenDV");
            dt.Columns.Add("DonGia");

            foreach (var TD in ds)
            {
                dt.Rows.Add(
                    TD.TenDV.Trim(), TD.DonGia);
            }
            return dt;
        }
    }

}
