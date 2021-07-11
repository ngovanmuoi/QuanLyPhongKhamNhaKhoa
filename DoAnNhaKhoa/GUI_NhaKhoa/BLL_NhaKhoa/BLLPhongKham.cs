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
    public class BLLPhongKham
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayThongTin(DataGridView dtgvTT, string pNgayKham, string pPhongKham, RadioButton choKham, RadioButton daKham, RadioButton tatCa)
        {               
            if(choKham.Checked == true)
            {
                var td = (from p in nhakhoa.TiepDonBenhNhans
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayKham == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham && p.TinhTrang == "Chờ khám"
                          select new
                          {
                              p.SoPhieu,
                              q.HoTen,
                              p.LoaiKham
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ChiDinh");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieu.Trim(), TD.HoTen.Trim(), TD.LoaiKham.Trim());
                }
                dtgvTT.DataSource = dt;
            }
            if (daKham.Checked == true)
            {
                var td = (from p in nhakhoa.TiepDonBenhNhans
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayKham == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham && p.TinhTrang == "Đã khám"
                          select new
                          {
                              p.SoPhieu,
                              q.HoTen,
                              p.LoaiKham
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ChiDinh");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieu.Trim(), TD.HoTen.Trim(), TD.LoaiKham.Trim());
                }
                dtgvTT.DataSource = dt;
            }
            if (tatCa.Checked == true)
            {
                var td = (from p in nhakhoa.TiepDonBenhNhans
                          join q in nhakhoa.BenhNhans on p.MaBenhNhan equals q.MaBenhNhan
                          where p.NgayKham == DateTime.Parse(pNgayKham) && p.MaPhong == pPhongKham
                          select new
                          {
                              p.SoPhieu,
                              q.HoTen,
                              p.LoaiKham
                          }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("SoPhieu");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("ChiDinh");
                foreach (var TD in td)
                {
                    dt.Rows.Add(TD.SoPhieu.Trim(), TD.HoTen.Trim(), TD.LoaiKham.Trim());
                }
                dtgvTT.DataSource = dt;
            }

        }
        public void LayPhongKham(ComboBoxEdit cbbPhongKham)
        {
            for (int i = cbbPhongKham.Properties.Items.Count - 1; i >= 0; i--)
            {
                cbbPhongKham.Properties.Items.RemoveAt(i);
            }
            var dc = from p in nhakhoa.PhongKhams where (p.MaPhong.Contains("PK")) select new { p.TenPhong };
            foreach (var i in dc)
            {
                cbbPhongKham.Properties.Items.Add(i.TenPhong.Trim());
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
    }
}
