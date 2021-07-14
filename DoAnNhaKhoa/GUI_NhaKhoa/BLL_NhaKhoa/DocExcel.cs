using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class DocExcel
    {
        //rows cols excecl
        private static int rows;
        private static int cols;

        //mang excel lọc, cols rows mang lọc
        private static string[,] mangDoc;
        private static int colsMangDoc;
        private static int rowsMangDoc;

        public string[,] read(string linkexcel)
        {
            //Đánh dấu batdau
            string link = linkexcel;

            if (!System.IO.File.Exists(link))
            {
                //Nếu đường link k chính xác thì....
                //MessageBox.Show("Không tồn tại file excel " + link);
                return null;
            }
            else
            {
                //Create COM Objects. Create a COM object for everything that is referenced
                // chạy file Excel theo đường dẫn
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(link);

                // Lấy Sheet 
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);

                // Lấy phạm vi dữ liệu
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                // Tạo mảng lưu trữ dữ liệu
                object[,] valueArray = (object[,])xlRange.get_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault);

                //tao mang do thi                        
                rows = xlWorksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;

                //Doc so dong do thi (ket thuc tu khoa "end")
                int demDong = 0;
                for (int row = 1; row <= rows; ++row)//đọc row hiện có trong Excel
                {
                    String doituongDong;
                    try
                    {
                        doituongDong = valueArray[row, 1].ToString();
                    }
                    catch
                    {
                        doituongDong = "";
                    }
                    if (doituongDong.Contains("end"))
                    {
                        break;
                    }
                    else if (doituongDong.Contains("end") == false)
                    {
                        demDong++;
                    }
                }

                //Doc so cot do thi (ket thuc tu khoa "end")
                int demCot = 0;
                //int cols = xlWorksheet.UsedRange.Columns.Count;
                cols = xlRange.Columns.Count;
                for (int col = 1; col <= cols; ++col)
                {
                    String doituongCot;
                    try
                    {
                        doituongCot = valueArray[3, col].ToString();
                    }
                    catch
                    {
                        doituongCot = "";
                    }
                    if (doituongCot.Contains("end"))
                    {
                        break;
                    }
                    if (doituongCot.Contains("end") == false)
                    {
                        demCot++;
                    }
                }

                //Mang chua du lieu qui dinh ket thuc dong[3] la end cot[1] la end
                //Phuong thuc lay mang tu [0][0] dữ liệu trên excel bắt đầu từ [1][1] nên tạo mảng tăng thêm 1 đơn vị
                mangDoc = new string[demDong + 1, demCot + 1];

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int row = 1; row <= demDong; ++row)//đọc row hiện có trong Excel
                {
                    for (int colum = 1; colum <= demCot; colum++)//đọc colum trong Excel
                    {
                        {
                            String giatri;
                            try
                            {
                                giatri = valueArray[row, colum].ToString();
                            }
                            catch
                            {
                                giatri = "";
                            }
                            mangDoc[row, colum] = giatri;
                        }
                    }
                }

                colsMangDoc = demCot + 1;
                rowsMangDoc = demDong + 1;
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                // Đóng Workbook, khử hết đối tượng
                xlWorkbook.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                // Đóng application
                xlApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }
            return mangDoc;
        }

        //dong mang read
        public int dongMang()
        {
            return rowsMangDoc;
        }

        //cot mang read
        public int cotMang()
        {
            return colsMangDoc;
        }

        //loc ra mang su dung
        public int[,] DocMang()
        {
            int colsMang = rowsMangDoc - 3;
            int rowsMang = colsMangDoc - 2;
            int[,] mang = new int[rowsMang, colsMang];
            for (int row = 4; row < rows; ++row)//đọc row hiện có trong Excel
            {
                for (int colum = 3; colum < cols; colum++)//đọc colum trong Excel
                {
                    {
                        String giatri;
                        try
                        {
                            giatri = mangDoc[row, colum].ToString();
                        }
                        catch
                        {
                            giatri = "";
                        }
                        if (String.IsNullOrEmpty(giatri) == false && giatri.Contains("x"))
                            mang[row - 4, colum - 3] = 1;
                        else
                            mang[row - 4, colum - 3] = 0;
                    }
                }
            }
            return mang;
        }
    }
}
