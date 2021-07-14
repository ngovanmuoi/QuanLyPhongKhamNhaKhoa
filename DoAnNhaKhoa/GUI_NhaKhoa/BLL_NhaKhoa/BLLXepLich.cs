using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public struct dothi
    {
        public string flag;
        public int n;
        public int e;
        public int[,] a;

        public dothi(string flag, int n, int e, int[,] a)
        {
            this.flag = flag;
            this.n = n;
            this.e = e;
            this.a = a;
        }
    };

    public struct Dinh
    {
        public string ten;
        public int v;
        public int bac, mau;
        public Dinh(int v, int bac, int mau, string ten)
        {
            this.ten = ten;
            this.v = v;
            this.bac = bac;
            this.mau = mau;
        }
    };
    public class BLLXepLich
    {
        DocExcel doc = new DocExcel();
        private static string[,] mangDoc;
        private static int rowsMangDoc;
        private static int colsMangDoc;
        private static int max = 100;
        private static dothi doThi = new dothi();
        private static Dinh dinh = new Dinh();
        public static int mau;

        //kiểm tra dữ liệu tất cả các ca có đủ số lượng hay ko (số lượng cho cả tuần)
        public string ktraDuLieu(int dulieuNgToiThieu, string link)
        {
            mangDoc = doc.read(link);
            if (mangDoc == null)
                return "Không tồn tại file";
            rowsMangDoc = doc.dongMang();
            colsMangDoc = doc.cotMang();
            //Mang doc nhan vien          
            for (int colum = 3; colum < colsMangDoc; colum++)
            {
                int dem = 0;
                for (int row = 4; row < rowsMangDoc; ++row)
                {

                    String doituongCa;
                    try
                    {
                        doituongCa = mangDoc[row, colum].ToString();
                    }
                    catch
                    {
                        doituongCa = "";
                    }
                    if (String.IsNullOrEmpty(doituongCa) == false && doituongCa.Contains("x"))
                    {
                        dem++;
                    }
                }
                if (dem < dulieuNgToiThieu)
                {
                    String thu;
                    if (colum % 2 == 0)
                    {
                        thu = mangDoc[2, colum - 1].ToString();
                    }
                    else
                    {
                        thu = mangDoc[2, colum].ToString();
                    }
                    String ca = mangDoc[3, colum].ToString();
                    string a = ("Số người làm " + thu + " " + ca + " chưa đủ số lượng : chỉ có " + dem + " người");
                    return a;
                }
            }
            return "Đủ số lượng người cần thiết";
        }       
        //input: rowChuaCa: dòng chứa thông tin "Ca", colChuaCa: cột chứa thông tin "Ca", mảng chứa thông tin Ca
        //handing: Đếm danh sách ca làm việc, điều kiện chứa chữ "Ca"
        //output: số lượng ca làm
        public int demCa(int rowChuaCa, int colChuaCa)
        {
            int demca = 0;
            for (int col = colChuaCa; col <= colsMangDoc; ++col)
            {
                String doituongCa;
                try
                {
                    doituongCa = mangDoc[rowChuaCa, col].ToString();
                }
                catch
                {
                    doituongCa = "";
                }
                if (String.IsNullOrEmpty(doituongCa) == false && doituongCa.Contains("Ca"))
                {
                    if (String.IsNullOrEmpty(doituongCa) == true)
                        break;
                    demca++;
                }
            }
            return demca;
        }

        //Lấy danh sách các ca trong mảng
        public string[] layDanhSachTenCa(int rowChuaCa, int colChuaCa)
        {
            string[] ds = new string[14];
            int a = 0;
            for (int col = colChuaCa; col <= 16; ++col)
            {
                String doituongCa;
                try
                {
                    doituongCa = mangDoc[rowChuaCa, col].ToString();
                }
                catch
                {
                    doituongCa = "";
                }
                if (String.IsNullOrEmpty(doituongCa) == false && doituongCa.Contains("Ca"))
                {
                    ds[a] = doituongCa;
                    a++;
                }
            }
            return ds;
        }

        //Tạo đồ thị đọc từ dữ liệu mảng dữ liệu đã lọc từ excel
        public int[,] taoDoThiThu(int colThu)
        {
            int colsMang = colThu;
            int rowsMang = rowsMangDoc - 4;
            int start = 4;
            int[,] mang = new int[rowsMang, rowsMang];
            for (int row = 4; row < rowsMangDoc; ++row)
            {
                String giatri;
                String giatri1;
                try
                {
                    giatri = mangDoc[row, colThu].ToString();
                    giatri1 = mangDoc[row, colThu + 1].ToString();
                }
                catch
                {
                    giatri = "";
                    giatri1 = "";
                }
                for (int rowXet = 4; rowXet < rowsMangDoc; ++rowXet)
                {
                    if (rowXet == start)
                    {
                        mang[row - 4, rowXet - 4] = 0;
                    }
                    else
                    {
                        String giatriXet;
                        String giatriXet1;
                        try
                        {
                            giatriXet = mangDoc[rowXet, colThu].ToString();
                            giatriXet1 = mangDoc[rowXet, colThu + 1].ToString();
                        }
                        catch
                        {
                            giatriXet = "";
                            giatriXet1 = "";
                        }
                        if ((giatri.Contains("x") != giatriXet.Contains("x")) || (giatri1.Contains("x") != giatriXet1.Contains("x")))
                            mang[row - 4, rowXet - 4] = 1;
                        else
                            mang[row - 4, rowXet - 4] = 0;
                    }
                }
                start++;
            }
            return mang;
        }

        //Tạo đồ thị đọc từ dữ liệu mảng dữ liệu đã lọc từ excel
        public int[,] taoDoThiThu2(int colThu, int rows)
        {
            int colsMang = colThu;
            int rowsMang = rowsMangDoc - rows;
            int start = rows;
            int[,] mang = new int[rowsMang, rowsMang];
            for (int row = 4; row < rowsMangDoc; ++row)
            {
                String giatri;
                String giatri1;
                try
                {
                    giatri = mangDoc[row, colThu].ToString();
                    giatri1 = mangDoc[row, colThu + 1].ToString();
                }
                catch
                {
                    giatri = "";
                    giatri1 = "";
                }
                for (int rowXet = 4; rowXet < rowsMangDoc; ++rowXet)
                {
                    if (rowXet == start)
                    {
                        mang[row - 4, rowXet - 4] = 0;
                    }
                    else
                    {
                        String giatriXet;
                        String giatriXet1;
                        try
                        {
                            giatriXet = mangDoc[rowXet, colThu].ToString();
                            giatriXet1 = mangDoc[rowXet, colThu + 1].ToString();
                        }
                        catch
                        {
                            giatriXet = "";
                            giatriXet1 = "";
                        }
                        if ((giatri.Contains("x") == giatriXet.Contains("x")) || (giatri1.Contains("x") == giatriXet1.Contains("x")))
                            mang[row - 4, rowXet - 4] = 1;
                        else
                            mang[row - 4, rowXet - 4] = 0;
                    }
                }
                start++;
            }
            return mang;
        }

        //gán mảng vào đồ thị
        //public dothi ganDothi(int [,] mang, int n,dothi dt)
        //{
        //    dt.a = mang;
        //    dt.n = n;
        //    return dt;
        //}

        public void ganDothi1(int[,] mang, int n)
        {
            doThi.a = mang;
            doThi.n = n;
        }

        //tinh bac cua dinh
        public int tinhBacDoThi(int[,] mangDoThi, int dinh)
        {
            int so_bac = 0;
            for (int i = 1; i < mangDoThi.GetLength(0); i++)
            {
                if (mangDoThi[dinh, i] != 0)
                    so_bac++;
            }
            return so_bac;
        }

        public int tinhBacDoThi1(int dinh)
        {
            int so_bac = 0;
            for (int i = 0; i < doThi.n; i++)
            {
                if (doThi.a[dinh, i] != 0)
                    so_bac++;
            }
            return so_bac;
        }

        //Doi vi tri mang
        public void swap(int[] x, int a, int b)
        {
            int temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }

        public void swapString(string[] x, int a, int b)
        {
            string temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }

        //Lay danh sach dinh
        public string[] layDanhSachDinh(int colThu)
        {
            string[] mangDinh = new string[rowsMangDoc - 4];
            for (int i = 4; i < rowsMangDoc; i++)
            {
                string dinh = mangDoc[i, 1];
                mangDinh[i - 4] = dinh;
            }
            return mangDinh;
        }

        public string[] layDanhSachDinhThu(int colThu, int row)
        {
            string[] mangDinh = new string[rowsMangDoc - 4];
            for (int i = 4; i < rowsMangDoc; i++)
            {
                string dinh = mangDoc[i, 1];
                string ca = mangDoc[i, colThu];
                string ca2 = mangDoc[i, colThu + 1];
                if (ca.Contains("x"))
                    dinh += " Ca1";
                if (ca2.Contains("x"))
                    dinh += " Ca2";
                mangDinh[i - 4] = dinh;
            }
            return mangDinh;
        }

        public string[] layDanhSachCa(int colThu, int rowNV)
        {
            string[] mangCa = new string[2];
            mangCa[0] = mangCa[1] = "";
            String doituongCa;
            String doituongCa1;
            try
            {
                doituongCa = mangDoc[rowNV, colThu].ToString();
                doituongCa1 = mangDoc[rowNV, colThu + 1].ToString();
            }
            catch
            {
                doituongCa = "";
                doituongCa1 = "";
            }
            if (String.IsNullOrEmpty(doituongCa) == false && doituongCa.Contains("x"))
            {
                mangCa[0] = mangDoc[3, colThu];
            }
            if (String.IsNullOrEmpty(doituongCa1) == false && doituongCa1.Contains("x"))
            {
                mangCa[1] = mangDoc[3, colThu + 1];
            }
            return mangCa;
        }

        public Dinh[] toMauDoThi(int cols, int rows)
        {
            ganDothi1(taoDoThiThu(cols), rowsMangDoc - rows);
            //Buoc 1: Khoi tao mang 1 chieu chua dinh,bac va cau truc Dinh
            Dinh[] d = new Dinh[doThi.n];
            int[] dsbac = new int[doThi.n];
            //string []dsdinh = layDanhSachDinh(cols);
            string[] dsdinh = layDanhSachDinhThu(cols, rows);
            int[] dsdinhAo = new int[doThi.n];

            for (int i = 0; i < doThi.n; i++)
                dsdinhAo[i] = i;

            //Buoc 2:tinh bac tung dinh luu vao dsbac va them tung dinh vao dsdinh
            for (int i = 0; i < doThi.n; i++)
            {
                dsbac[i] = tinhBacDoThi1(i);
            }

            //Buoc 3:sap xep danh sach bac giam dan
            for (int i = 0; i < doThi.n - 1; i++)
            {
                for (int j = i + 1; j < doThi.n; j++)
                {
                    if (dsbac[i] < dsbac[j])
                    {
                        swap(dsbac, i, j);
                        swapString(dsdinh, i, j);
                        swap(dsdinhAo, i, j);
                    }
                }
            }

            //Buoc 4:Gan bac cua dsbac vao cau Dinh(bac),Mau cua tung dinh la 0, va dinh vao v
            for (int i = 0; i < doThi.n; i++)
            {
                d[i].bac = dsbac[i];
                d[i].mau = 0;
                d[i].v = dsdinhAo[i];
                d[i].ten = dsdinh[i];
            }

            //Buoc 5:Khoi tao mau dau tien la 1,mang 1 chieu tapdinhto, va bien dem = 0
            int mau_to = 1;
            int[] tap_dinh_to = new int[max];
            int n;
            int dem = 0;

            while (dem < doThi.n)
            {
                int i = 0;
                n = 0;
                while (d[i].mau != 0) i++;
                d[i].mau = mau_to;
                dem++;
                tap_dinh_to[n] = d[i].v;

                for (int j = 0; j < doThi.n; j++)
                {
                    if (d[j].mau == 0)
                    {
                        int k;
                        for (k = 0; k <= n; k++)
                        {
                            if (doThi.a[d[j].v, tap_dinh_to[k]] != 0) break;
                        }
                        if (k > n)
                        {
                            d[j].mau = mau_to;
                            dem++;
                            n++;
                            tap_dinh_to[n] = d[j].v;
                        }
                    }
                }
                mau_to++;
            }
            mau = mau_to - 1;

            for (int i = 0; i < doThi.n - 1; i++)
            {
                for (int j = i + 1; j < doThi.n; j++)
                {

                    string ai = "";
                    string aj = "";
                    string ai1 = "";
                    string aj1 = "";
                    string[] arChar = { "Ca" };
                    string[] arrListStr = d[i].ten.Split(arChar, StringSplitOptions.None);
                    string[] arrListStr1 = d[j].ten.Split(arChar, StringSplitOptions.None);
                    try
                    {
                        ai = arrListStr[1];
                    }
                    catch
                    {
                        ai = "";
                    }
                    try
                    {
                        aj = arrListStr[2];
                    }
                    catch
                    {
                        aj = "";
                    }
                    try
                    {
                        ai1 = arrListStr1[1];
                    }
                    catch
                    {
                        ai1 = "";
                    }
                    try
                    {
                        aj1 = arrListStr1[2];
                    }
                    catch
                    {
                        aj1 = "";
                    }

                    string length1 = ai + aj;
                    string length2 = ai1 + aj1;
                    if (length1.Length > length2.Length && d[i].mau < d[j].mau)
                    {
                        int maua = d[i].mau;
                        int maub = d[j].mau;
                        for (int m = 0; m < doThi.n; m++)
                        {
                            if (d[m].mau == maua)
                            {
                                d[m].mau = maub;
                            }
                            else
                                if (d[m].mau == maub)
                            {
                                d[m].mau = maua;
                            }
                        }
                    }
                }
            }
            return d;
        }

        public int mauLonNhat(Dinh[] a)
        {
            int mau = 0;
            for (int i = 0; i < doThi.n; i++)
                if (a[i].mau > mau)
                    mau = a[i].mau;
            return mau;
        }

        public List<string> LayThongTin(int sl, int col)
        {
            List<string> a = new List<string>();
            Dinh[] d = toMauDoThi(col, 4);
            int demca1 = 0;
            int demca2 = 0;
            mau = mauLonNhat(d);
            while (mau != 0)
            {
                for (int i = doThi.n - 1; i >= 0; i--)
                {

                    if (demca1 == sl && demca2 == sl)
                        return a;
                    string mangCa;
                    if (d[i].mau == mau)
                    {
                        mangCa = d[i].ten;
                        if (mangCa.Contains("Ca1") && mangCa.Contains("Ca2"))
                        {
                            if (demca1 < sl && demca2 < sl)
                            {
                                a.Add(d[i].ten);
                                demca1 += 1;
                                demca2 += 1;
                            }
                        }

                        if (mangCa.Contains("Ca1") && !mangCa.Contains("Ca2"))
                        {
                            if (demca1 < sl)
                            {
                                a.Add(d[i].ten);
                                demca1 += 1;
                            }
                        }
                        if (mangCa.Contains("Ca2") && !mangCa.Contains("Ca1"))
                        {
                            if (demca2 < sl)
                            {
                                a.Add(d[i].ten);
                                demca2 += 1;
                            }
                        }
                    }
                }
                mau--;
            }
            return a;
        }

        public List<string> LayThongTinCa(int sl1, int sl2, int col)
        {
            List<string> a = new List<string>();
            Dinh[] d = toMauDoThi(col, 4);
            int demca1 = 0;
            int demca2 = 0;
            mau = mauLonNhat(d);
            while (mau != 0)
            {
                for (int i = doThi.n - 1; i >= 0; i--)
                {

                    if (demca1 == sl1 && demca2 == sl2)
                        return a;
                    string mangCa;
                    if (d[i].mau == mau)
                    {
                        mangCa = d[i].ten;
                        if (mangCa.Contains("Ca1") && mangCa.Contains("Ca2"))
                        {
                            if (demca1 < sl1 && demca2 < sl2)
                            {
                                a.Add(d[i].ten);
                                demca1 += 1;
                                demca2 += 1;
                            }
                            else
                            {
                                if (demca1 < sl1 && demca2 == sl2)
                                {
                                    string tam = d[i].ten;
                                    tam = tam.Replace("Ca2", "");
                                    a.Add(tam);
                                    demca1 += 1;
                                }
                                else
                                {
                                    if (demca1 == sl1 && demca2 < sl2)
                                    {
                                        string tam = d[i].ten;
                                        tam = tam.Replace("Ca1", "");
                                        a.Add(tam);
                                        demca2 += 1;
                                    }
                                }
                            }
                        }

                        if (mangCa.Contains("Ca1") && !mangCa.Contains("Ca2"))
                        {
                            if (demca1 < sl1)
                            {
                                a.Add(d[i].ten);
                                demca1 += 1;
                            }
                        }
                        if (mangCa.Contains("Ca2") && !mangCa.Contains("Ca1"))
                        {
                            if (demca2 < sl2)
                            {
                                a.Add(d[i].ten);
                                demca2 += 1;
                            }
                        }
                    }
                }
                mau--;
            }
            return a;
        }
    }
}
