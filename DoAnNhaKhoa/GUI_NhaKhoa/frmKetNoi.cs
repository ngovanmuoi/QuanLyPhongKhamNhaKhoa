using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_NhaKhoa.BLL_NhaKhoa;

namespace GUI_NhaKhoa
{
    public partial class frmKetNoi : Form
    {
        BLLConfig bLLConfig = new BLLConfig();

        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bLLConfig.SaveConfig(cbbServer.Text, txtUseName.Text, txtPass.Text, cbbDB.Text);
            this.Close();
        }

        private void cbbServer_DropDown(object sender, EventArgs e)
        {
            cbbServer.DataSource = bLLConfig.GetServerName();
            cbbServer.DisplayMember = "ServerName";
        }

        private void cbbDB_DropDown(object sender, EventArgs e)
        {
            cbbDB.DataSource = bLLConfig.GetDBName(cbbServer.Text, txtUseName.Text, txtPass.Text);
            cbbDB.DisplayMember = "name";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
