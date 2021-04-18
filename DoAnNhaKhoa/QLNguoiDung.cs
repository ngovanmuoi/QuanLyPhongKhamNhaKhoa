using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhaKhoa
{
    class QLNguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.LTWNCConn == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.LTWNCConn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed) _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.LTWNCConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 10;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 20;
            }
            return 30;
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
            pPass + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            DoAnNhaKhoa.Properties.Settings.Default.LTWNCConn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + ""; THTuan4.Properties.Settings.Default.Save();
        }
        public const string PUBLIC_KEY = "05DHLTH";
        /// <summary>
        /// Encrypts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string Encrypt(string value, string publickKey)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            byte[] bytesIn = Encoding.UTF8.GetBytes(value);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(publickKey);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateEncryptor();
            CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt,
            CryptoStreamMode.Write);
            cryptStreem.Write(bytesIn, 0, bytesIn.Length);
            cryptStreem.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();
            cryptStreem.Close();
            msOut.Close();
            return Convert.ToBase64String(bytesOut);
        }
    }
}
