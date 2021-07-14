using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLPhieuKetQua
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();

        public string LayMaBN(string pSoPhieu)
        {
            string maBN = "";
            var MaPhong = (from p in nhakhoa.PhieuDichVus
                           where p.SoPhieuDV.Trim() == pSoPhieu
                           select new
                           {
                               p.MaBenhNhan
                           }).ToList();
            if (MaPhong.Count() != 0)
            {
                foreach (var a in MaPhong)
                    maBN = a.MaBenhNhan;
            }
            return maBN;
        }
        public string LaySoPhieu(string pSoPhieu)
        {
            string maBN = "";
            var MaPhong = (from p in nhakhoa.PhieuDichVus
                           where p.SoPhieuDV.Trim() == pSoPhieu
                           select new
                           {
                               p.SoPhieu
                           }).ToList();
            if (MaPhong.Count() != 0)
            {
                foreach (var a in MaPhong)
                    maBN = a.SoPhieu;
            }
            return maBN;
        }
        public void LayTTPhieuKham(string pSoPhieu, RichTextBox txtChuanDoan, RichTextBox txtKetLuan, TextBox cbbTieuDuong, TextBox huyetAp, TextBox timmach)
        {
            var TT = (from p in nhakhoa.PhieuKhamBenhs
                      join q in nhakhoa.TiepDonBenhNhans on p.SoPhieu equals q.SoPhieu
                      where p.SoPhieu == pSoPhieu
                      select new
                      {
                          p.ChuanDoan,
                          p.KetLuan,
                          q.TieuDuong,
                          q.HuyetAp,
                          q.BenhTimMach
                      }).ToList();
            if (TT.Count() != 0)
            {
                foreach (var a in TT)
                {
                    txtChuanDoan.Text = a.ChuanDoan;
                    txtKetLuan.Text = a.KetLuan;
                    timmach.Text = a.BenhTimMach;
                    cbbTieuDuong.Text = a.TieuDuong;
                    huyetAp.Text = a.HuyetAp;
                }
            }
        }
        public void LoadcbbTenDV(ComboBox cbb, string pSoPhieu)
        {
            for (int i = cbb.Items.Count - 1; i >= 0; i--)
            {
                cbb.Items.RemoveAt(i);
            }
            var nhom = from a in nhakhoa.CTPhieuDichVus
                       join b in nhakhoa.DichVus on a.MaDV equals b.MaDV
                       where a.SoPhieuDV == pSoPhieu
                       select new
                       {
                           b.TenDV
                       };
            foreach (var x in nhom)
            {
                cbb.Items.Add(x.TenDV.Trim());
            }
        }
        public void ThemPhieuKQ(string pSoPhieu, string pTenDV, string pHinhAnh ,string pKetLuan, string pSoPhieuDV )
        {

            PhieuKetQua phieuKetQua = new PhieuKetQua();
            phieuKetQua.SoPhieuKQ = pSoPhieu;
            phieuKetQua.HinhAnh = pHinhAnh;
            phieuKetQua.KetLuan = pKetLuan;
            phieuKetQua.TenDV = pTenDV;
            phieuKetQua.SoPhieuDV = pSoPhieuDV;
            nhakhoa.PhieuKetQuas.InsertOnSubmit(phieuKetQua);
            nhakhoa.SubmitChanges();
        }
        public void ThemPhieuKhongHinh(string pSoPhieu, string pTenDV, string pKetLuan, string pSoPhieuDV)
        {

            PhieuKetQua phieuKetQua = new PhieuKetQua();
            phieuKetQua.SoPhieuKQ = pSoPhieu;
            phieuKetQua.KetLuan = pKetLuan;
            phieuKetQua.TenDV = pTenDV;
            phieuKetQua.SoPhieuDV = pSoPhieuDV;
            nhakhoa.PhieuKetQuas.InsertOnSubmit(phieuKetQua);
            nhakhoa.SubmitChanges();
        }
        public void SuaPhieuKQ(string pTenDV, string pHinhAnh, string pKetLuan, string pSoPhieuDV)
        {
            var kq = (from a in nhakhoa.PhieuKetQuas
                      where a.SoPhieuDV == pSoPhieuDV && a.TenDV == pTenDV
                      select a).SingleOrDefault();
            if (kq != null)
            {
                kq.KetLuan = pKetLuan;
                kq.HinhAnh = pHinhAnh;
                nhakhoa.SubmitChanges();
            }
        }
        public DataTable LayDanhPhieuKQ()
        {
            var ds = (from a in nhakhoa.PhieuKetQuas
                      select new
                      {
                          a.SoPhieuKQ
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.SoPhieuKQ.Trim());
            }
            return dt;
        }
        public void LayThongTinKetQua(string pTenDV, string pSoPhieu, RichTextBox rich, PictureBox img)
        {            
            var kq = (from a in nhakhoa.PhieuKetQuas
                       where a.SoPhieuDV == pSoPhieu && a.TenDV ==pTenDV
                       select new
                       {
                           a.KetLuan,
                           a.HinhAnh
                       }).SingleOrDefault();
            if(kq != null) 
            {
                 rich.Text = kq.KetLuan;
                if (kq.HinhAnh != null)
                {
                    img.Image = ByteToImg(kq.HinhAnh);
                }
                else { img.Image = null; }
            }
            else
            {
                rich.Text = null;
                img.Image = null;
            }    
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public int DemCTPhieuDV(string pSoPhieuDV)
        {
            int dem = 0;
            var ct = from a in nhakhoa.CTPhieuDichVus
                     where a.SoPhieuDV == pSoPhieuDV
                     select a;
            foreach (var x in ct)
            {
                dem++;
            }
            return dem;
        }
        public int DemPhieuKQ(string pSoPhieuDV)
        {
            int dem = 0;
            var ct = from a in nhakhoa.PhieuKetQuas
                     where a.SoPhieuDV == pSoPhieuDV
                     select a;
            foreach (var x in ct)
            {
                dem++;
            }
            return dem;
        }
        public void CapNhatTrangThaiPhieu(string pSoPhieu)
        {
            int a = DemCTPhieuDV(pSoPhieu);
            int b = DemPhieuKQ(pSoPhieu);
            if(a == b)
            {
                var Phieu = (from p in nhakhoa.PhieuDichVus
                             where p.SoPhieuDV == pSoPhieu
                             select p).SingleOrDefault();
                if (Phieu != null)
                {
                    Phieu.TinhTrang = "Đã thực hiện";
                    nhakhoa.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật trạng thái phiếu dịch vụ");
                }    
            }                         
        }
    }
}
