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
    }
}
