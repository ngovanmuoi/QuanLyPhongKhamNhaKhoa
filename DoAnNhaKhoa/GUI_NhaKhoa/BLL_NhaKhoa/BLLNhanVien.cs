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
    public class BLLNhanVien
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayNhanVien(DataGridView dtgvNV)
        {
            var nv = from p in nhakhoa.NhanViens
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NV");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Ngày Vào Làm");
            dt.Columns.Add("Lương Cơ Bản");
            DateTime.Now.Date.ToShortDateString();
            foreach (var nv1 in nv)
            {
                dt.Rows.Add(nv1.MaNhanVien.Trim(), nv1.HoTen.Trim(), nv1.Phai.Trim(), DateTime.Parse(nv1.NgaySinh.ToString()).Date.ToShortDateString(), nv1.DiaChi.Trim(), nv1.SDT.Trim(), DateTime.Parse(nv1.NgayVaoLam.ToString()).Date.ToShortDateString(), nv1.LuongCoBan.ToString());
            }
            dtgvNV.DataSource = dt;
        }
        public void ThemNV(string pMANV, string pHoTen, string pGioiTinh, string pNgaySinh, string pDiaChi, string pSDT, string pNVL, string pLCB)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = pMANV;
            nv.HoTen = pHoTen;
            nv.Phai = pGioiTinh;
            nv.NgaySinh = DateTime.Parse(pNgaySinh);
            nv.DiaChi = pDiaChi;
            nv.SDT = pSDT;
            nv.NgayVaoLam = DateTime.Parse(pNVL);
            nv.LuongCoBan = int.Parse(pLCB);
            nhakhoa.NhanViens.InsertOnSubmit(nv);
            nhakhoa.SubmitChanges();
        }

        public void SuaNV(string pMANV, string pHoTen, string pGioiTinh, string pNgaySinh, string pDiaChi, string pSDT, string pNVL, string pLCB)
        {
            var nv = (from a in nhakhoa.NhanViens where a.MaNhanVien == pMANV select a).SingleOrDefault();
            if (nv != null)
            {
                nv.HoTen = pHoTen;
                nv.Phai = pGioiTinh;
                nv.NgaySinh = DateTime.Parse(pNgaySinh);
                nv.DiaChi = pDiaChi;
                nv.SDT = pSDT;
                nv.NgayVaoLam = DateTime.Parse(pNVL);
                nv.LuongCoBan = int.Parse(pLCB);
                nhakhoa.SubmitChanges();
            }
        }

        public bool XoaNV(string pMaNV)
        {
            NhanVien nhanVien = nhakhoa.NhanViens.Where(nd => nd.MaNhanVien == pMaNV).FirstOrDefault();
            if (nhanVien != null)
            {
                nhakhoa.NhanViens.DeleteOnSubmit(nhanVien);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public void LoadDiaChi(ComboBoxEdit cbbDC)
        {
            for (int i = cbbDC.Properties.Items.Count - 1; i >= 0; i--)
            {
                cbbDC.Properties.Items.RemoveAt(i);
            }
            cbbDC.Properties.Items.Add("Tất Cả");
            var dc = from p in nhakhoa.NhanViens group p by p.DiaChi into g select new { dc = g.Key };
            foreach (var i in dc)
            {
                cbbDC.Properties.Items.Add(i.dc.Trim());
            }
        }
        public void Loc(ComboBoxEdit cbbDC, ComboBoxEdit cbbGT, ButtonEdit txtTKiem, DataGridView dtgvtt)
        {
            try
            {
                if (cbbDC.Text == "Tất Cả" && cbbGT.Text == "Tất Cả")
                {
                    try
                    {
                        var tim = (from p in nhakhoa.NhanViens
                                   where p.HoTen.Contains(txtTKiem.Text)
                                   select new
                                   {
                                       p.MaNhanVien,
                                       p.HoTen,
                                       p.Phai,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.NgayVaoLam,
                                       p.LuongCoBan
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã NV");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Phái");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Ngày Vào");
                        dt.Columns.Add("Lương CB");

                        foreach (var i in tim)
                        {
                            dt.Rows.Add(i.MaNhanVien.Trim(), i.HoTen.Trim(), i.Phai.Trim(), i.NgaySinh.ToString().Substring(0, 10), i.DiaChi.Trim(), i.SDT.Trim(), i.NgayVaoLam.ToString().Substring(0, 10), i.LuongCoBan.ToString());
                        }
                        dtgvtt.DataSource = dt;
                    }
                    catch
                    {

                    }

                }
                else if (cbbDC.Text == "Tất Cả" && cbbGT.Text != "Tất Cả")
                {
                    try
                    {
                        var tim = (from p in nhakhoa.NhanViens
                                   where p.HoTen.Contains(txtTKiem.Text) && p.Phai.Trim() == cbbGT.Text
                                   select new
                                   {
                                       p.MaNhanVien,
                                       p.HoTen,
                                       p.Phai,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.NgayVaoLam,
                                       p.LuongCoBan
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã NV");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Phái");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Ngày Vào");
                        dt.Columns.Add("Lương CB");

                        foreach (var i in tim)
                        {
                            dt.Rows.Add(i.MaNhanVien.Trim(), i.HoTen.Trim(), i.Phai.Trim(), i.NgaySinh.ToString().Substring(0, 10), i.DiaChi.Trim(), i.SDT.Trim(), i.NgayVaoLam.ToString().Substring(0, 10), i.LuongCoBan.ToString());
                        }
                        dtgvtt.DataSource = dt;
                    }
                    catch
                    {

                    }
                }
                else if (cbbDC.Text != "Tất Cả" && cbbGT.Text == "Tất Cả")
                {
                    try
                    {
                        var tim = (from p in nhakhoa.NhanViens
                                   where p.HoTen.Contains(txtTKiem.Text) && p.DiaChi == cbbDC.Text
                                   select new
                                   {
                                       p.MaNhanVien,
                                       p.HoTen,
                                       p.Phai,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.NgayVaoLam,
                                       p.LuongCoBan
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã NV");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Phái");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Ngày Vào");
                        dt.Columns.Add("Lương CB");

                        foreach (var i in tim)
                        {
                            dt.Rows.Add(i.MaNhanVien.Trim(), i.HoTen.Trim(), i.Phai.Trim(), i.NgaySinh.ToString().Substring(0, 10), i.DiaChi.Trim(), i.SDT.Trim(), i.NgayVaoLam.ToString().Substring(0, 10), i.LuongCoBan.ToString());
                        }
                        dtgvtt.DataSource = dt;
                    }
                    catch
                    {

                    }
                }

                else
                {
                    try
                    {
                        var tim = (from p in nhakhoa.NhanViens
                                   where p.HoTen.Contains(txtTKiem.Text) && p.DiaChi == cbbDC.Text && p.Phai == cbbGT.Text
                                   select new
                                   {
                                       p.MaNhanVien,
                                       p.HoTen,
                                       p.Phai,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.NgayVaoLam,
                                       p.LuongCoBan
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã NV");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Phái");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Ngày Vào");
                        dt.Columns.Add("Lương CB");

                        foreach (var i in tim)
                        {
                            dt.Rows.Add(i.MaNhanVien.Trim(), i.HoTen.Trim(), i.Phai.Trim(), i.NgaySinh.ToString().Substring(0, 10), i.DiaChi.Trim(), i.SDT.Trim(), i.NgayVaoLam.ToString().Substring(0, 10), i.LuongCoBan.ToString());
                        }
                        dtgvtt.DataSource = dt;
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }
    }
}
