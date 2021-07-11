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
        public string LayMaBenhNhan(string pHoTen)
        {
            string ma = "";
            var MaBN = (from p in nhakhoa.BenhNhans
                         where p.HoTen.Trim() == pHoTen
                         select new
                         {
                             p.MaBenhNhan
                         }).ToList();
            if (MaBN.Count() != 0)
            {
                foreach (var a in MaBN)
                    ma = a.MaBenhNhan;
            }
            return ma;
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
        public void LayPhongKham(ComboBox cbbPhongKham)
        {
            for (int i = cbbPhongKham.Items.Count - 1; i >= 0; i--)
            {
                cbbPhongKham.Items.RemoveAt(i);
            }
            var dc = from p in nhakhoa.PhongKhams where( p.MaPhong.Contains("PK")) select new { p.TenPhong};
            foreach (var i in dc)
            {
                cbbPhongKham.Items.Add(i.TenPhong.Trim());
            }
            
        }
        public string LayMaPhongKham(string pTenPhong)
        {
            string maPhong = "";
            var MaPhong = (from p in nhakhoa.PhongKhams
                         where p.TenPhong.Trim() == pTenPhong
                         select new
                         {
                             p.MaPhong
                         }).ToList();
            if (MaPhong.Count() != 0)
            {
                foreach (var a in MaPhong)
                    maPhong = a.MaPhong;
            }
            return maPhong;
        }
        public string LayMaNV(string pTenNV)
        {
            string maNV = "";
            var TenNV = (from p in nhakhoa.NhanViens
                           where p.HoTen.Trim() == pTenNV
                           select new
                           {
                               p.MaNhanVien
                           }).ToList();
            if (TenNV.Count() != 0)
            {
                foreach (var a in TenNV)
                    maNV = a.MaNhanVien;
            }
            return maNV;
        }
        public string LayTenBS(string pSoPhieu, string pNgayKham)
        {
            string tenNV = "";
            var TenNV = (from p in nhakhoa.NhanViens
                         join q in nhakhoa.TiepDonBenhNhans on p.MaNhanVien equals q.BacSi
                         where q.SoPhieu.Trim() == pSoPhieu && q.NgayKham == DateTime.Parse(pNgayKham)
                         select new
                         {
                             p.HoTen
                         }).ToList();
            if (TenNV.Count() != 0)
            {
                foreach (var a in TenNV)
                    tenNV = a.HoTen;
            }
            return tenNV;
        }
        public void LayBacSi(ComboBox cbbBacSi)
        {
            for (int i = cbbBacSi.Items.Count - 1; i >= 0; i--)
            {
                cbbBacSi.Items.RemoveAt(i);
            }
            var TenBS = (from p in nhakhoa.NhanViens
                         join r in nhakhoa.NguoiDungs on p.MaNhanVien equals r.MaNhanVien
                         join q in nhakhoa.NguoiDungNhomNguoiDungs on r.TenDangNhap equals q.TenDangNhap
                         where q.MaNhom == "BS"
                         select new
                         {
                             p.HoTen
                         }).ToList();
            foreach (var i in TenBS)
            {
                cbbBacSi.Items.Add(i.HoTen.Trim());
            }

        }
        public void LayThongTin(DataGridView dtgvTT, string pNgayKham)
        {
            var dstiepdon = (from td in nhakhoa.TiepDonBenhNhans
                      join bn in nhakhoa.BenhNhans on td.MaBenhNhan equals bn.MaBenhNhan
                      join p in nhakhoa.PhongKhams on td.MaPhong equals p.MaPhong
                      where td.NgayKham == DateTime.Parse(pNgayKham)
                      select new
                      {
                          td.SoPhieu,
                          bn.HoTen,
                          p.TenPhong,
                          td.NgayKham,
                          td.LoaiKham,
                          td.LyDoKham,
                          td.TieuDuong,
                          td.BenhTimMach,
                          td.HuyetAp
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu");
            dt.Columns.Add("Bệnh Nhân");
            dt.Columns.Add("Phòng Khám");
            dt.Columns.Add("Ngày Khám");
            dt.Columns.Add("Loại Khám");
            dt.Columns.Add("Lý Do Khám");
            dt.Columns.Add("Tiểu Đường");
            dt.Columns.Add("Bệnh Tim Mạch");
            dt.Columns.Add("Huyết Áp");
            foreach (var TD in dstiepdon)
            {
                dt.Rows.Add(TD.SoPhieu.Trim(), TD.HoTen.Trim(), TD.TenPhong.Trim(), DateTime.Parse(TD.NgayKham.ToString()).Date.ToShortDateString(), TD.LoaiKham.Trim(), TD.LyDoKham.Trim(), TD.TieuDuong.Trim(), TD.BenhTimMach.Trim(), TD.HuyetAp.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public DataTable LayDSTiepDonTheoPhong(string pPhong)
        {
            var ds = (from a in nhakhoa.TiepDonBenhNhans
                        where (a.MaPhong == pPhong)
                        select new
                        {
                            a.SoPhieu,
                            a.MaPhong
                        }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu");
            dt.Columns.Add("Ma Phong");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.SoPhieu.Trim(), TD.MaPhong.Trim());
            }
            return dt;
        }
        public DataTable RPPhieuDangKyKham(string pSoPhieu, string pNgay)
        {
            var ds = (from a in nhakhoa.TiepDonBenhNhans
                      join b in nhakhoa.BenhNhans on a.MaBenhNhan equals b.MaBenhNhan
                      join c in nhakhoa.NhanViens on a.NhanVienTiepDon equals c.MaNhanVien
                      where (a.NgayKham == DateTime.Parse(pNgay) && a.SoPhieu == pSoPhieu)
                      select new
                      {                          
                          a.MaBenhNhan,
                          a.NgayKham,
                          b.HoTen,
                          b.GioiTinh,
                          b.NgaySinh,
                          b.MaThe,
                          b.DiaChi,
                          b.SDT,
                          b.Email,
                          a.LyDoKham,
                          a.TieuDuong,
                          a.BenhTimMach,
                          a.HuyetAp,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaBenhNhan");
            dt.Columns.Add("NgayKham");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("MaThe");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Email");
            dt.Columns.Add("LyDoKham");
            dt.Columns.Add("TieuDuong");
            dt.Columns.Add("BenhTimMach");
            dt.Columns.Add("HuyetAp");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.MaBenhNhan.Trim(), DateTime.Parse(TD.NgayKham.ToString()).Date.ToShortDateString(), TD.HoTen.Trim(), TD.GioiTinh.Trim(),
                    DateTime.Parse(TD.NgaySinh.ToString()).Date.ToShortDateString(), TD.MaThe.Trim(), TD.DiaChi.Trim(), TD.SDT.Trim(), TD.Email.Trim(),
                    TD.LyDoKham.Trim(), TD.TieuDuong.Trim(), TD.BenhTimMach.Trim(), TD.HuyetAp.Trim());
            }
            return dt;
        }
        public DataTable RPSoPhieu(string pSoPhieu, string pNgay)
        {
            var ds = (from a in nhakhoa.TiepDonBenhNhans
                      join b in nhakhoa.BenhNhans on a.MaBenhNhan equals b.MaBenhNhan
                      join c in nhakhoa.PhongKhams on a.MaPhong equals c.MaPhong
                      where (a.NgayKham == DateTime.Parse(pNgay) && a.SoPhieu == pSoPhieu)
                      select new
                      {
                          a.SoPhieu,
                          a.MaBenhNhan,
                          a.NgayKham,
                          b.HoTen,
                          c.TenPhong
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("SoPhieu");
            dt.Columns.Add("MaBenhNhan");
            dt.Columns.Add("NgayKham");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("TenPhong");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.SoPhieu.Trim(), TD.MaBenhNhan.Trim(), DateTime.Parse(TD.NgayKham.ToString()).Date.ToShortDateString(), TD.HoTen.Trim(), TD.TenPhong.Trim());
            }
            return dt;
        }
        public void ThemTiepDon(string pSoPhieu, string pNgayKham, string pLoaiKham, string pLyDoKham, string pTieuDuong, string pTimMach, string pHuyetHap, string pTinhTrang, string pMaBN, string pMaPhong, string pNVTiepDon, string pBacSi)
        {
            TiepDonBenhNhan tiepDonBenhNhan = new TiepDonBenhNhan();
            tiepDonBenhNhan.SoPhieu = pSoPhieu;
            tiepDonBenhNhan.NgayKham = DateTime.Parse(pNgayKham);
            tiepDonBenhNhan.LoaiKham = pLoaiKham;
            tiepDonBenhNhan.LyDoKham = pLyDoKham;
            tiepDonBenhNhan.TieuDuong = pTieuDuong;
            tiepDonBenhNhan.BenhTimMach = pTimMach;
            tiepDonBenhNhan.HuyetAp = pHuyetHap;
            tiepDonBenhNhan.TinhTrang = pTinhTrang;
            tiepDonBenhNhan.MaBenhNhan = pMaBN;
            tiepDonBenhNhan.MaPhong = pMaPhong;
            tiepDonBenhNhan.NhanVienTiepDon = pNVTiepDon;
            tiepDonBenhNhan.BacSi = pBacSi;
            nhakhoa.TiepDonBenhNhans.InsertOnSubmit(tiepDonBenhNhan);
            nhakhoa.SubmitChanges();
        }
        public bool XoaTiepDon(string pSoPhieu)
        {
            TiepDonBenhNhan tiepDonBenhNhan = nhakhoa.TiepDonBenhNhans.Where(nd => nd.SoPhieu == pSoPhieu).FirstOrDefault();
            if (tiepDonBenhNhan != null)
            {
                nhakhoa.TiepDonBenhNhans.DeleteOnSubmit(tiepDonBenhNhan);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public void SuaTiepDon(string pSoPhieu, string pNgayKham, string pLoaiKham, string pLyDoKham, string pTieuDuong, string pTimMach, string pHuyetHap, string pTinhTrang, string pMaBN, string pMaPhong, string pNVTiepDon, string pBacSi)
        {
            var tiepDonBenhNhan = (from a in nhakhoa.TiepDonBenhNhans where a.SoPhieu == pSoPhieu && a.NgayKham == DateTime.Parse(pNgayKham) select a).SingleOrDefault();
            if (tiepDonBenhNhan != null)
            {
                tiepDonBenhNhan.NgayKham = DateTime.Parse(pNgayKham);
                tiepDonBenhNhan.LoaiKham = pLoaiKham;
                tiepDonBenhNhan.LyDoKham = pLyDoKham;
                tiepDonBenhNhan.TieuDuong = pTieuDuong;
                tiepDonBenhNhan.BenhTimMach = pTimMach;
                tiepDonBenhNhan.HuyetAp = pHuyetHap;
                tiepDonBenhNhan.TinhTrang = pTinhTrang;
                tiepDonBenhNhan.MaBenhNhan = pMaBN;
                tiepDonBenhNhan.MaPhong = pMaPhong;
                tiepDonBenhNhan.NhanVienTiepDon = pNVTiepDon;
                tiepDonBenhNhan.BacSi = pBacSi;               
                nhakhoa.SubmitChanges();
            }
        }
    }
}
