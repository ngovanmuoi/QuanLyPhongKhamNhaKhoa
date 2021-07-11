using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLPhieuDichVu
    {
        QuanLyNhaKhoaDataContext nhakhoa = new QuanLyNhaKhoaDataContext();
        public string LayMaBN(string pSoPhieu)
        {
            string ma = "";
            var MaBN = (from p in nhakhoa.TiepDonBenhNhans
                        where p.SoPhieu.Trim() == pSoPhieu
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
        public void LayTTBenhNhan(string pMaBN, TextBox txtHoten, TextBox txtGioiTinh, TextBox txtNgaySinh, TextBox txtDiaChi, TextBox txtSDT)
        {
            var TT = (from p in nhakhoa.BenhNhans
                         where p.MaBenhNhan.Trim() == pMaBN
                         select new
                         {
                             p.HoTen,
                             p.NgaySinh,
                             p.GioiTinh,
                             p.SDT,
                             p.DiaChi                             
                         }).ToList();
            if (TT.Count() != 0)
            {
                foreach (var a in TT)
                {                  
                    txtHoten.Text = a.HoTen;
                    txtNgaySinh.Text = DateTime.Parse(a.NgaySinh.ToString()).Date.ToShortDateString();
                    txtGioiTinh.Text = a.GioiTinh;
                    txtDiaChi.Text = a.DiaChi;
                    txtSDT.Text = a.SDT;
                }
            }
        }
        public void LayTTKham(string pSoPhieu, TextBox txtTieuDuong, TextBox txtHuyetAp, TextBox txtTimMach, RichTextBox txtChuanDoan, RichTextBox txtKetLuan)
        {
            var TT = (from p in nhakhoa.PhieuKhamBenhs
                      join q in nhakhoa.TiepDonBenhNhans on p.SoPhieu equals q.SoPhieu
                         where p.SoPhieu.Trim() == pSoPhieu
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
                    txtTieuDuong.Text = a.TieuDuong;
                    txtHuyetAp.Text = a.HuyetAp;
                    txtTimMach.Text = a.BenhTimMach;
                    txtChuanDoan.Text = a.ChuanDoan;
                    txtKetLuan.Text = a.KetLuan;
                }
            }
        }
        public DataTable LayLoaiDichVu()
        {
            var loaidv = (from a in nhakhoa.LoaiDichVus
                      select new
                      {
                          a.MaLoai,
                          a.TenLoai                         
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaLoai");
            dt.Columns.Add("TenLoai");
            foreach (var LDV in loaidv)
            {
                dt.Rows.Add(LDV.MaLoai.Trim(), LDV.TenLoai.Trim());
            }
            return dt;
        }
        public void LayThongTinDV(DataGridView dtgvTT, string pMaLoai)
        {
            var TT = (from p in nhakhoa.DichVus                           
                             where p.MaLoai == pMaLoai
                             select new
                             {
                                 p.MaDV,
                                 p.TenDV,
                                 p.DonGia,
                                 p.DonViTinh
                             }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã DV");
            dt.Columns.Add("Tên DV");
            dt.Columns.Add("Giá DV");
            dt.Columns.Add("ĐVT");          
            foreach (var TD in TT)
            {
                dt.Rows.Add(TD.MaDV.Trim(), TD.TenDV.Trim(), TD.DonGia, TD.DonViTinh.Trim());
            }
            dtgvTT.DataSource = dt;
        }
        public string LayMaLoaiDV(string pDichVu)
        {
            string ma = "";
            var MaDV = (from p in nhakhoa.LoaiDichVus
                        where p.TenLoai.Trim() == pDichVu
                        select new
                        {
                            p.MaLoai
                        }).ToList();
            if (MaDV.Count() != 0)
            {
                foreach (var a in MaDV)
                    ma = a.MaLoai;
            }
            return ma;
        }
        public DataTable LayDanhSachDV(string pPhong)
        {
            var ds = (from a in nhakhoa.PhieuDichVus
                      where a.MaPhong == pPhong
                      select new
                      {
                          a.SoPhieuDV
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu");
            dt.Columns.Add("Ma Phong");
            foreach (var TD in ds)
            {
                dt.Rows.Add(TD.SoPhieuDV.Trim());
            }
            return dt;
        }
        public void LayPhongDV(ComboBox ccbPhong)
        {
            for (int i = ccbPhong.Items.Count - 1; i >= 0; i--)
            {
                ccbPhong.Items.RemoveAt(i);
            }
            var dc = from p in nhakhoa.PhongKhams where (p.MaPhong.Contains("PDV")) select new { p.TenPhong };
            foreach (var i in dc)
            {
                ccbPhong.Items.Add(i.TenPhong.Trim());
            }
        }
        public string LayMaPhongDV(string pTenPhong)
        {
            string maphong = "";
            var Phong = (from p in nhakhoa.PhongKhams
                         where p.TenPhong == pTenPhong
                         select new
                         {
                             p.MaPhong
                         }).ToList();
            if (Phong.Count() != 0)
            {
                foreach (var a in Phong)
                    maphong = a.MaPhong;
            }
            return maphong;
        }
        public void DanhSachDV(DataGridView dtgv, string pSoPhieuDV)
        {
            var TT = (from p in nhakhoa.CTPhieuDichVus
                      join q in nhakhoa.DichVus on p.MaDV equals q.MaDV
                      where p.SoPhieuDV == pSoPhieuDV
                      select new
                      {
                          p.SoPhieuDV,
                          p.MaDV,
                          q.TenDV,
                          q.DonGia,
                          q.DonViTinh
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu DV");
            dt.Columns.Add("Mã Dịch Vụ");
            dt.Columns.Add("Tên Dịch Vụ");
            dt.Columns.Add("Giá Dịch Vụ");
            dt.Columns.Add("Đơn Vị Tính");
            foreach (var TD in TT)
            {
                dt.Rows.Add(TD.SoPhieuDV.Trim(), TD.MaDV.Trim(), TD.TenDV.Trim(), TD.DonGia, TD.DonViTinh.Trim());
            }
            dtgv.DataSource = dt;
        }
        public bool KTSoPhieuDV(string pSoPhieuDV)
        {
            PhieuDichVu phieuDichVu = nhakhoa.PhieuDichVus.Where(sp => sp.SoPhieuDV == pSoPhieuDV).FirstOrDefault();
            if (phieuDichVu != null)
            {               
                return false;
            }
            else
                return true;
        }
        public void ThemPhieuDichVu(string pSoPhieuDV, string pMaBN, string pMaPhong, string pNgayLap)
        {
            PhieuDichVu phieuDichVu = new PhieuDichVu();
            phieuDichVu.SoPhieuDV = pSoPhieuDV;
            phieuDichVu.MaBenhNhan = pMaBN;
            phieuDichVu.MaPhong = pMaPhong;
            phieuDichVu.NgayLap = DateTime.Parse(pNgayLap);
            phieuDichVu.TinhTrang = "Chờ thực hiện";
            phieuDichVu.TongTien = 0;
            nhakhoa.PhieuDichVus.InsertOnSubmit(phieuDichVu);
            nhakhoa.SubmitChanges();
        }
        public void ThemCTDV(string pSoPhieuDV, string pMaDV)
        {
            CTPhieuDichVu cTPhieuDichVu = new CTPhieuDichVu();
            cTPhieuDichVu.SoPhieuDV = pSoPhieuDV;
            cTPhieuDichVu.MaDV = pMaDV;
            nhakhoa.CTPhieuDichVus.InsertOnSubmit(cTPhieuDichVu);
            nhakhoa.SubmitChanges();
        }
        public void CapNhatTongTien(string pSoPhieuDv, int Gia)
        {
            var tt = (from a in nhakhoa.PhieuDichVus where a.SoPhieuDV == pSoPhieuDv select a).SingleOrDefault();
            if (tt != null)
            {
                tt.TongTien = tt.TongTien + Gia;              
                nhakhoa.SubmitChanges();
            }
        }
        public string LayTongTien(string pSoPhieu)
        {
            string tt = "0";
            var TT = (from p in nhakhoa.PhieuDichVus
                         where p.SoPhieuDV == pSoPhieu
                         select new
                         {
                             p.TongTien
                         }).ToList();
            if (TT.Count() != 0)
            {
                foreach (var a in TT)
                    tt = a.TongTien.ToString();
            }
            return tt;
        }
        public string ChuyenSo_chu(double pSo)
        {
            if (pSo == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(pSo, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            if (pSo < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng.";
            return lso_chu.ToString().Trim();
        }
        public string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }
            return Ktach;
        }
        public string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }

        public string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }
    }
}
