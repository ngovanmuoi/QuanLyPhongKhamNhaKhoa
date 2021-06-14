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
    public class BLLBenhNhan
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayBenhNhan(DataGridView dtgvNV)
        {
            var bn = from p in nhakhoa.BenhNhans
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã BN");
            dt.Columns.Add("Mã Thẻ");
            dt.Columns.Add("Họ Tên");
            dt.Columns.Add("Giới Tính");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Email");
            DateTime.Now.Date.ToShortDateString();
            foreach (var bn1 in bn)
            {
                dt.Rows.Add(bn1.MaBenhNhan.Trim(), bn1.MaThe.Trim(), bn1.HoTen.Trim(), bn1.GioiTinh.Trim(), DateTime.Parse(bn1.NgaySinh.ToString()).Date.ToShortDateString(), bn1.DiaChi.Trim(), bn1.SDT.Trim(), bn1.Email.Trim());
            }
            dtgvNV.DataSource = dt;
        }
        public bool KTTrungMaThe(string pMaThe)
        {
            BenhNhan benhNhan = nhakhoa.BenhNhans.Where(nd => nd.MaThe == pMaThe).FirstOrDefault();
            if (benhNhan != null)
            {                
                return true;
            }
            else
                return false;
        }
        public void ThemBN(string pMABN, string pMaThe, string pHoTen, string pGioiTinh, string pNgaySinh, string pDiaChi, string pSDT, string pEmail)
        {
            BenhNhan bn = new BenhNhan();
            bn.MaBenhNhan = pMABN;
            bn.MaThe = pMaThe;
            bn.HoTen = pHoTen;
            bn.GioiTinh = pGioiTinh;
            bn.NgaySinh = DateTime.Parse(pNgaySinh);
            bn.DiaChi = pDiaChi;
            bn.SDT = pSDT;
            bn.Email = pEmail;
            nhakhoa.BenhNhans.InsertOnSubmit(bn);
            nhakhoa.SubmitChanges();
        }

        public void SuaBN(string pMABN, string pMaThe, string pHoTen, string pGioiTinh, string pNgaySinh, string pDiaChi, string pSDT, string pEmail)
        {
            var bn = (from a in nhakhoa.BenhNhans where a.MaBenhNhan == pMABN select a).SingleOrDefault();
            if (bn != null)
            {
                bn.MaBenhNhan = pMABN;
                bn.MaThe = pMaThe;
                bn.HoTen = pHoTen;
                bn.GioiTinh = pGioiTinh;
                bn.NgaySinh = DateTime.Parse(pNgaySinh);
                bn.DiaChi = pDiaChi;
                bn.SDT = pSDT;
                bn.Email = pEmail;
                nhakhoa.SubmitChanges();
            }
        }

        public bool XoaBN(string pMaBN)
        {
            BenhNhan benhNhan = nhakhoa.BenhNhans.Where(nd => nd.MaBenhNhan == pMaBN).FirstOrDefault();
            if (benhNhan != null)
            {
                nhakhoa.BenhNhans.DeleteOnSubmit(benhNhan);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public void Loc(ComboBoxEdit cbbGT, ButtonEdit txtTKiem, DataGridView dtgvtt)
        {
            try
            {
                if (cbbGT.Text == "Tất Cả")
                {
                    try
                    {
                        var tim = (from p in nhakhoa.BenhNhans
                                   where p.HoTen.Contains(txtTKiem.Text)
                                   select new
                                   {
                                       p.MaBenhNhan,
                                       p.MaThe,
                                       p.HoTen,
                                       p.GioiTinh,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.Email
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã BN");
                        dt.Columns.Add("Mã Thẻ");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Giới Tính");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Email");
                        DateTime.Now.Date.ToShortDateString();
                        foreach (var bn1 in tim)
                        {
                            dt.Rows.Add(bn1.MaBenhNhan.Trim(), bn1.MaThe.Trim(), bn1.HoTen.Trim(), bn1.GioiTinh.Trim(), DateTime.Parse(bn1.NgaySinh.ToString()).Date.ToShortDateString(), bn1.DiaChi.Trim(), bn1.SDT.Trim(), bn1.Email.Trim());
                        }
                        dtgvtt.DataSource = dt;
                    }
                    catch
                    {

                    }

                }
                else if (cbbGT.Text != "Tất Cả")
                {
                    try
                    {
                        var tim = (from p in nhakhoa.BenhNhans
                                   where p.HoTen.Contains(txtTKiem.Text) && p.GioiTinh.Trim() == cbbGT.Text
                                   select new
                                   {
                                       p.MaBenhNhan,
                                       p.MaThe,
                                       p.HoTen,
                                       p.GioiTinh,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.Email
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã BN");
                        dt.Columns.Add("Mã Thẻ");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Giới Tính");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Email");
                        foreach (var bn1 in tim)
                        {
                            dt.Rows.Add(bn1.MaBenhNhan.Trim(), bn1.MaThe.Trim(), bn1.HoTen.Trim(), bn1.GioiTinh.Trim(), DateTime.Parse(bn1.NgaySinh.ToString()).Date.ToShortDateString(), bn1.DiaChi.Trim(), bn1.SDT.Trim(), bn1.Email.Trim());
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
                        var tim = (from p in nhakhoa.BenhNhans
                                   where p.HoTen.Contains(txtTKiem.Text) && p.GioiTinh == cbbGT.Text
                                   select new
                                   {
                                       p.MaBenhNhan,
                                       p.MaThe,
                                       p.HoTen,
                                       p.GioiTinh,
                                       p.NgaySinh,
                                       p.DiaChi,
                                       p.SDT,
                                       p.Email
                                   }).ToList();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã BN");
                        dt.Columns.Add("Mã Thẻ");
                        dt.Columns.Add("Họ Tên");
                        dt.Columns.Add("Giới Tính");
                        dt.Columns.Add("Ngày Sinh");
                        dt.Columns.Add("Địa Chỉ");
                        dt.Columns.Add("SĐT");
                        dt.Columns.Add("Email");
                        foreach (var bn1 in tim)
                        {
                            dt.Rows.Add(bn1.MaBenhNhan.Trim(), bn1.MaThe.Trim(), bn1.HoTen.Trim(), bn1.GioiTinh.Trim(), DateTime.Parse(bn1.NgaySinh.ToString()).Date.ToShortDateString(), bn1.DiaChi.Trim(), bn1.SDT.Trim(), bn1.Email.Trim());
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
