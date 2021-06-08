using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLManHinh
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();

        public void LayThongTin(DataGridView dtgvTT)
        {
            var nd = (from p in nhakhoa.ManHinhs
                      select new
                      {
                          p.MaManHinh,
                          p.TenManHinh
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Màn Hình");
            dt.Columns.Add("Tên Màn Hình");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.MaManHinh.Trim(), TD.TenManHinh.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public void ThemManHinh(string pMaMH, string pTenMH)
        {
            ManHinh manHinh = new ManHinh();
            manHinh.MaManHinh = pMaMH;
            manHinh.TenManHinh = pTenMH;
            nhakhoa.ManHinhs.InsertOnSubmit(manHinh);
            nhakhoa.SubmitChanges();
        }
        public bool XoaManHinh(string pMaMH)
        {
            ManHinh manHinh = nhakhoa.ManHinhs.Where(mh => mh.MaManHinh == pMaMH).FirstOrDefault();
            if (manHinh != null)
            {
                nhakhoa.ManHinhs.DeleteOnSubmit(manHinh);
                nhakhoa.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public void SuaManHinh(string pMaMH, string pTenMH)
        {
            var mh = (from a in nhakhoa.ManHinhs where a.MaManHinh == pMaMH select a).SingleOrDefault();
            if (mh != null)
            {
                mh.MaManHinh = pMaMH;
                mh.TenManHinh = pTenMH;
                nhakhoa.SubmitChanges();
            }
        }
    }
}
