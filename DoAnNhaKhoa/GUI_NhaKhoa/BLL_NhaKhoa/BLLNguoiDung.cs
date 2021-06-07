using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        public void ThemNguoiDung(string pMaNV, string pTenDN, string pMatKhau, string pTrangThai)
        {
            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.MaNhanVien = pMaNV;
            nguoiDung.TenDangNhap = pTenDN;
            nguoiDung.MatKhau = pMatKhau;
            nguoiDung.TrangThai = pTrangThai;
            nhakhoa.NguoiDungs.InsertOnSubmit(nguoiDung);
            nhakhoa.SubmitChanges();
        }
        public bool XoaNguoiDung(string pTenDN)
        {
            NguoiDung nguoiDung = nhakhoa.NguoiDungs.Where(nd => nd.TenDangNhap == pTenDN).FirstOrDefault();
            if (nguoiDung != null)
            {
                nhakhoa.NguoiDungs.DeleteOnSubmit(nguoiDung);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public void SuaNguoiDung(string pMaNV, string pTenDN, string pMatKhau, string pTrangThai)
        {
            var td = (from a in nhakhoa.NguoiDungs where a.TenDangNhap == pTenDN select a).SingleOrDefault();
            if (td != null)
            {
                td.MatKhau = pMatKhau;
                td.TrangThai = pTrangThai;
                nhakhoa.SubmitChanges();
            }
        }
        public string LayMaNV(string Ten)
        {
            string b = "";          
            var Ma = (from p in nhakhoa.NhanViens
                      where p.HoTen.Trim() == Ten
                      select new
                      {
                          p.MaNhanVien
                      }).ToList();
            if (Ma.Count() != 0)
            {
                foreach (var a in Ma)
                    b = a.MaNhanVien;
            }
            return b;
        }
        public string LayMatKhau(string pTenDN)
        {
            string b = "";
            var Ma = (from p in nhakhoa.NguoiDungs
                      where p.TenDangNhap.Trim() == pTenDN
                      select new
                      {
                          p.MatKhau
                      }).ToList();
            if (Ma.Count() != 0)
            {
                foreach (var a in Ma)
                    b = a.MatKhau;
            }
            return b;
        }
        public void LoadcbbTenNV(ComboBoxEdit cbb)
        {
            for (int i = cbb.Properties.Items.Count - 1; i >= 0; i--)
            {
                cbb.Properties.Items.RemoveAt(i);
            }           
            var HT = from a in nhakhoa.NhanViens
                     select new
                     {
                         a.HoTen
                     };
            foreach (var x in HT)
            {
                cbb.Properties.Items.Add(x.HoTen.Trim());
            }
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
