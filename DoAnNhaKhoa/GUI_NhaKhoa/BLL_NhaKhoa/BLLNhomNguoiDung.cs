using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLNhomNguoiDung
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();

        public void LayThongTin(DataGridView dtgvTT)
        {
            var nd = (from p in nhakhoa.NhomNguoiDungs                     
                      select new
                      {
                          p.MaNhom,
                          p.TenNhom,
                          p.GhiChu
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhóm Người Dùng");
            dt.Columns.Add("Tên Nhóm Người Dùng");
            dt.Columns.Add("Ghi Chú");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.MaNhom.Trim(), TD.TenNhom.Trim(), TD.GhiChu.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public void ThemNhomNguoiDung(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            NhomNguoiDung nhomNguoiDung = new NhomNguoiDung();
            nhomNguoiDung.MaNhom = pMaNhom;
            nhomNguoiDung.TenNhom = pTenNhom;
            nhomNguoiDung.GhiChu = pGhiChu;           
            nhakhoa.NhomNguoiDungs.InsertOnSubmit(nhomNguoiDung);
            nhakhoa.SubmitChanges();
        }
        public bool XoaNhomNguoiDung(string pMaNhom)
        {
            NhomNguoiDung nhomNguoiDung = nhakhoa.NhomNguoiDungs.Where(nnd => nnd.MaNhom == pMaNhom).FirstOrDefault();
            if (nhomNguoiDung != null)
            {
                nhakhoa.NhomNguoiDungs.DeleteOnSubmit(nhomNguoiDung);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public void SuaNhomNguoiDung(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            var td = (from a in nhakhoa.NhomNguoiDungs where a.MaNhom == pMaNhom select a).SingleOrDefault();
            if (td != null)
            {
                td.TenNhom = pTenNhom;
                td.GhiChu = pGhiChu;
                nhakhoa.SubmitChanges();
            }
        }
        public void LoadcbbTenNhom(ComboBoxEdit cbb)
        {
            for (int i = cbb.Properties.Items.Count - 1; i >= 0; i--)
            {
                cbb.Properties.Items.RemoveAt(i);
            }
            var nhom = from a in nhakhoa.NhomNguoiDungs
                     select new
                     {
                         a.TenNhom
                     };
            foreach (var x in nhom)
            {
                cbb.Properties.Items.Add(x.TenNhom.Trim());
            }
        }
        public void LayDanhSachNguoiDung(DataGridView dtgvTT)
        {
            var nd = (from p in nhakhoa.NguoiDungs
                      select new
                      {
                          p.TenDangNhap,
                          p.TrangThai,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Đăng Nhập");
            dt.Columns.Add("Trạng Thái");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.TenDangNhap.Trim(), TD.TrangThai.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public void LayDanhSachNguoiDungNhomNguoiDung(DataGridView dtgvTT, string pMaNhom)
        {            
            var nd = (from x in nhakhoa.NguoiDungNhomNguoiDungs
                      where x.MaNhom.Trim() == pMaNhom
                      select new
                      {
                          x.TenDangNhap,
                          x.MaNhom,
                          x.GhiChu,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Đăng Nhập");
            dt.Columns.Add("Mã Nhóm");
            dt.Columns.Add("Ghi Chú");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.TenDangNhap.Trim(), TD.MaNhom.Trim(), TD.GhiChu.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public string LayMaNhomNguoiDung(string pTenNhom)
        {
            string b = "";
            var Ma = (from p in nhakhoa.NhomNguoiDungs
                      where p.TenNhom.Trim() == pTenNhom
                      select new
                      {
                          p.MaNhom
                      }).ToList();
            if (Ma.Count() != 0)
            {
                foreach (var a in Ma)
                    b = a.MaNhom;
            }
            return b;
        }
        public bool KTTrung(string pTenDN, string pMaNhom)
        {
            var Ma = (from p in nhakhoa.NguoiDungNhomNguoiDungs
                      where p.TenDangNhap.Trim() == pTenDN && p.MaNhom.Trim() == pMaNhom.Trim()
                      select new
                      {
                          p.MaNhom
                      }).ToList();
            if (Ma.Count() != 0)
            {
                return true;
            }
            return false;
        }
        public void ThemNguoiDung(string pTenDN, string pMaNhom, string pGhiChu)
        {
            NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung = new NguoiDungNhomNguoiDung();
            nguoiDungNhomNguoiDung.TenDangNhap = pTenDN;
            nguoiDungNhomNguoiDung.MaNhom = pMaNhom;
            nguoiDungNhomNguoiDung.GhiChu = pGhiChu;
            nhakhoa.NguoiDungNhomNguoiDungs.InsertOnSubmit(nguoiDungNhomNguoiDung);
            nhakhoa.SubmitChanges();
        }
        public bool XoaNguoiDung(string pTenDN, string pMaNhom)
        {
            NguoiDungNhomNguoiDung dungNhomNguoiDung = nhakhoa.NguoiDungNhomNguoiDungs.Where(nd => nd.TenDangNhap == pTenDN && nd.MaNhom == pMaNhom).FirstOrDefault();
            if (dungNhomNguoiDung != null)
            {
                nhakhoa.NguoiDungNhomNguoiDungs.DeleteOnSubmit(dungNhomNguoiDung);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
    }
}
