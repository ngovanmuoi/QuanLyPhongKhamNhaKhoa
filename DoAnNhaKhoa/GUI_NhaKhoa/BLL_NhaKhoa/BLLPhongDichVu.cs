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
    public class BLLPhongDichVu
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayPhongDichVu(ComboBoxEdit cbbPhongKham)
        {
            for (int i = cbbPhongKham.Properties.Items.Count - 1; i >= 0; i--)
            {
                cbbPhongKham.Properties.Items.RemoveAt(i);
            }
            var dc = from p in nhakhoa.PhongKhams where (p.MaPhong.Contains("PDV")) select new { p.TenPhong };
            foreach (var i in dc)
            {
                cbbPhongKham.Properties.Items.Add(i.TenPhong.Trim());
            }

        }
        public string LayMaPhong(string pTenPhong)
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
        public void LayThongTin(DataGridView dtgvTT, string pNgayKham, string pPhongKham, RadioButton choKham, RadioButton daKham, RadioButton tatCa)
        {
            if (choKham.Checked == true)
            {
                var td = (from p in nhakhoa.PhieuDichVus
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayLap == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham && p.TinhTrang == "Chờ thực hiện"
                          select new
                          {
                              p.SoPhieuDV,
                              q.HoTen,
                              p.ThanhToan
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ThanhToan");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieuDV.Trim(), TD.HoTen.Trim(), TD.ThanhToan.Trim());
                }
                dtgvTT.DataSource = dt;
            }
            if (daKham.Checked == true)
            {
                var td = (from p in nhakhoa.PhieuDichVus
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayLap == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham && p.TinhTrang == "Đã thực hiện"
                          select new
                          {
                              p.SoPhieuDV,
                              q.HoTen,
                              p.ThanhToan
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ThanhToan");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieuDV.Trim(), TD.HoTen.Trim(), TD.ThanhToan.Trim());
                }
                dtgvTT.DataSource = dt;
            }
            if (tatCa.Checked == true)
            {
                var td = (from p in nhakhoa.PhieuDichVus
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayLap == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham
                          select new
                          {
                              p.SoPhieuDV,
                              q.HoTen,
                              p.ThanhToan
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ThanhToan");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieuDV.Trim(), TD.HoTen.Trim(), TD.ThanhToan.Trim());
                }
                dtgvTT.DataSource = dt;
            }

        }       
    }
}
