using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLPhanQuyen
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public void LayDanhSachNhomND(DataGridView dtgvTT)
        {
            var nd = (from p in nhakhoa.NhomNguoiDungs
                      select new
                      {
                          p.MaNhom,
                          p.TenNhom,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhóm Người Dùng");
            dt.Columns.Add("Tên Nhóm Người Dùng");
            foreach (var TD in nd)
            {
                dt.Rows.Add(TD.MaNhom.Trim(), TD.TenNhom.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public void LayDanhSachPhanQuyen(DataGridView dtgv, string pMaNhom)
        {
            var quyen = (from p in nhakhoa.ManHinhs
                         join q in nhakhoa.PhanQuyens on p.MaManHinh equals q.MaManHinh where (q.MaNhom == pMaNhom)
                         select new
                      {
                          p.MaManHinh,
                          p.TenManHinh,
                          q.CoQuyen,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaManHinh");
            dt.Columns.Add("TenManHinh");
            dt.Columns.Add("CoQuyen");
            foreach (var TD in quyen)
            {
                dt.Rows.Add(TD.MaManHinh.Trim(), TD.TenManHinh.Trim(), TD.CoQuyen);
            }
            dtgv.DataSource = dt;
        }

        public DataTable GetMaManHinh(string pMaNhom)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-NJSH0L1\\SQLEXPRESS;Initial Catalog=QuanLyNhaKhoa;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhanQuyen where MaNhom ='"+pMaNhom +"'",cnn);
            da.Fill(dt);
            return dt;
        }

        public List<string> GetMaNhomNguoiDung(string tenDN)
        {
            List<string> kqMNND = new List<string>();
            var quyen = (from p in nhakhoa.NguoiDungNhomNguoiDungs
                         where (p.TenDangNhap == tenDN)
                         select new
                         {
                             p.TenDangNhap,
                             p.MaNhom,
                         }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Đăng Nhập");
            dt.Columns.Add("Mã Nhóm Người Dùng");
            foreach (var TD in quyen)
            {
                dt.Rows.Add(TD.TenDangNhap.Trim(), TD.MaNhom.Trim());
            }
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                kqMNND.Add(dt.Rows[i].ItemArray[1].ToString());
            }    
            return kqMNND;
        }

        public bool LuuPhanQuyen(string pMaNhom, string pMaMH, bool pCoQuyen)
        {
            try 
            {
                var quen = (from a in nhakhoa.PhanQuyens where (a.MaNhom.Trim() == pMaNhom && a.MaManHinh == pMaMH.Trim())
                            select a).SingleOrDefault();
                if (quen != null)
                {
                    quen.MaNhom = pMaNhom;
                    quen.MaManHinh = pMaMH;
                    quen.CoQuyen = pCoQuyen;
                    nhakhoa.SubmitChanges();
                    return true;
                }
                else
                    return false;
                
            }
            catch { return false; }
        }


    }
}
