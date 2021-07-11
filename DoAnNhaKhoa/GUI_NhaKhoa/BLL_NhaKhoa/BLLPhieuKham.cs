using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLPhieuKham
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
        public void LayTTBenhNhan(string pMaBN, TextBox txtMaThe, TextBox txtHoten, TextBox txtGioiTinh, TextBox txtNgaySinh, TextBox txtDiaChi, TextBox txtSDT, TextBox txtEmail)
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
                             p.DiaChi,
                             p.Email
                         }).ToList();
            if (Tennv.Count() != 0)
            {
                foreach (var a in Tennv)
                {
                    txtMaThe.Text = a.MaThe;
                    txtHoten.Text = a.HoTen;
                    txtNgaySinh.Text = DateTime.Parse(a.NgaySinh.ToString()).Date.ToShortDateString();
                    txtGioiTinh.Text = a.GioiTinh;
                    txtDiaChi.Text = a.DiaChi;
                    txtSDT.Text = a.SDT;
                    txtEmail.Text = a.Email;
                }
            }
        }
        public void LayThongTin(string pSoPhieu, string pNgayKham, TextBox txtBacSi, TextBox txtLyDo, ComboBox cbbTieuDuong, ComboBox cbbHuyetAp, ComboBox cbbTimMach)
        {
            var TT = (from p in nhakhoa.TiepDonBenhNhans
                         join q in nhakhoa.NhanViens on p.BacSi equals q.MaNhanVien                         
                         where p.SoPhieu.Trim() == pSoPhieu && p.NgayKham == DateTime.Parse(pNgayKham)
                         select new
                         {                             
                             q.HoTen,
                             p.LyDoKham,
                             p.TieuDuong,
                             p.HuyetAp,
                             p.BenhTimMach
                         }).ToList();
            if (TT.Count() != 0)
            {
                foreach (var a in TT)
                {
                    txtBacSi.Text = a.HoTen;
                    txtLyDo.Text = a.LyDoKham;
                    cbbTieuDuong.Text = a.TieuDuong;
                    cbbHuyetAp.Text = a.HuyetAp;
                    cbbTimMach.Text = a.BenhTimMach;
                }
            }
        }
        public void LayTTPhieuKham(string pSoPhieu, RichTextBox txtChuanDoan, RichTextBox txtKetLuan)
        {
            var TT = (from p in nhakhoa.PhieuKhamBenhs
                      where p.SoPhieu == pSoPhieu
                      select new
                      {
                          p.ChuanDoan,
                          p.KetLuan
                      }).ToList();
            if (TT.Count() != 0)
            {
                foreach (var a in TT)
                {
                    txtChuanDoan.Text = a.ChuanDoan;
                    txtKetLuan.Text = a.KetLuan;
                }
            }
        }
        public string LayMaBN(string pSoPhieu, string pNgayKham)
        {
            string ma = "";
            var MaBN = (from p in nhakhoa.TiepDonBenhNhans
                        where p.SoPhieu.Trim() == pSoPhieu && p.NgayKham == DateTime.Parse(pNgayKham)
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
        public string LayTiepDon(string pSoPhieu, string pNgayKham)
        {
            string tiepdon = "";
            var MaBN = (from p in nhakhoa.TiepDonBenhNhans
                        join q in nhakhoa.NhanViens on p.NhanVienTiepDon  equals q.MaNhanVien
                        where p.SoPhieu.Trim() == pSoPhieu && p.NgayKham == DateTime.Parse(pNgayKham)
                        select new
                        {
                            q.HoTen
                        }).ToList();
            if (MaBN.Count() != 0)
            {
                foreach (var a in MaBN)
                    tiepdon = a.HoTen;
            }
            return tiepdon;
        }
        public void CapNhatTrangThaiPhieu(string pSoPhieu)
        {
            var Phieu = (from a in nhakhoa.TiepDonBenhNhans
                       where a.SoPhieu == pSoPhieu
                       select a).SingleOrDefault();
            if (Phieu != null)
            {
                Phieu.TinhTrang = "Đã khám";
                nhakhoa.SubmitChanges();
            }
        }
        public void ThemPhieuKham(string pSoPhieu, string pChuanDoan, string pKetLuan)
        {
            PhieuKhamBenh phieuKhamBenh = new PhieuKhamBenh();
            phieuKhamBenh.SoPhieu = pSoPhieu;
            phieuKhamBenh.ChuanDoan = pChuanDoan;
            phieuKhamBenh.KetLuan = pKetLuan;
            nhakhoa.PhieuKhamBenhs.InsertOnSubmit(phieuKhamBenh);
            nhakhoa.SubmitChanges();
        }
        public void SuaPhieuKham(string pSoPhieu, string pChuanDoan, string pKetLuan)
        {
            var TT = (from a in nhakhoa.PhieuKhamBenhs where a.SoPhieu == pSoPhieu select a).SingleOrDefault();
            if (TT != null)
            {
                TT.ChuanDoan = pChuanDoan;
                TT.KetLuan = pKetLuan;
                nhakhoa.SubmitChanges();
            }
        }
    }
}
