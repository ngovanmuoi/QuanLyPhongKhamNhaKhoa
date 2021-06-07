using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_NhaKhoa.BLL_NhaKhoa
{
    public class BLLConfig
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.QuanLyNhaKhoaConn == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.QuanLyNhaKhoaConn);
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
            GUI_NhaKhoa.Properties.Settings.Default.QuanLyNhaKhoaConn = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + ""; GUI_NhaKhoa.Properties.Settings.Default.Save();
        }

    }
}
