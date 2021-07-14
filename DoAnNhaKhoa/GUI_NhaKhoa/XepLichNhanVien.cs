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
    public partial class XepLichNhanVien : Form
    {
        public static List<string> Thu2 = new List<string>();
        public static List<string> Thu3 = new List<string>();
        public static List<string> Thu4 = new List<string>();
        public static List<string> Thu5 = new List<string>();
        public static List<string> Thu6 = new List<string>();
        public static List<string> Thu7 = new List<string>();
        public static List<string> CN = new List<string>();
        public static int[] DanhSachSLTheoNgay = new int[7];
        public static int[] DanhSachSLTheoCa = new int[14];
        public string[] dstendinh = new string[14];
        public static string linkfile = null;
        string[] ds = new string[14];
        public string header = "Danh sách ca làm việc nhân viên";

        BLLXepLich xuli = new BLLXepLich();
        public XepLichNhanVien()
        {
            InitializeComponent();
        }

        private void btn_chooseEX_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFileSteam = new OpenFileDialog();
            linkfile = "";
            if (uploadFileSteam.ShowDialog() == DialogResult.OK)
            {
                uploadFileSteam.InitialDirectory = "d:\\";
                uploadFileSteam.Filter = "Excel(*.xls;*.xlsx)|*.xls;*.xlsx)";
                uploadFileSteam.FilterIndex = 1;
                linkfile = uploadFileSteam.FileName;
            }
            if (!linkfile.Contains("xls") || !linkfile.Contains("xlsx"))
            {
                MessageBox.Show("Mời chọn file Excel");
                return;
            }
        }
        public void docExcel3()
        {
            Dinh[] d = new Dinh[100];
            //Thu2 = new List<string>();
            int sl = 0;
            if (string.IsNullOrEmpty(linkfile))
            {
                MessageBox.Show("Chưa có link");
                return;
            }
            if (!linkfile.Contains("xls") || !linkfile.Contains("xlsx"))
            {
                MessageBox.Show("Mời chọn file Excel");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_SL.Text))
                {
                    MessageBox.Show("Mời nhập số lượng");
                    return;
                }
                sl = int.Parse(txt_SL.Text);
                //string link = txt_link.Text;

                string xl = xuli.ktraDuLieu(sl, linkfile);
                if (xl.Contains("Số người làm"))
                {
                    MessageBox.Show(xuli.ktraDuLieu(sl, linkfile));
                    return;
                }
                if (xl.Contains("Không tồn tại file"))
                {
                    MessageBox.Show("Không tồn tại file");
                    return;
                }
                if (xl.Contains("Đủ số lượng người cần thiết"))
                {
                    MessageBox.Show("Đủ số lượng người cần thiết");
                }
                //int[,] dothi = xuli.taoDoThiThu(3);
                //string [] dsDinh=xuli.layDanhSachDinh(3);
                for (int i = 1; i <= 4; i++)
                {
                    Thu2 = xuli.LayThongTin(sl, 3);
                    Thu3 = xuli.LayThongTin(sl, 5);
                    Thu4 = xuli.LayThongTin(sl, 7);
                    Thu5 = xuli.LayThongTin(sl, 9);
                    Thu6 = xuli.LayThongTin(sl, 11);
                    Thu7 = xuli.LayThongTin(sl, 13);
                    CN = xuli.LayThongTin(sl, 15);
                }
            }
        }

        private void XepLichNhanVien_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            for (int i = 0; i < 7; i++)
                DanhSachSLTheoNgay[i] = 0;
            for (int i = 0; i < 14; i++)
                DanhSachSLTheoCa[i] = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông Báo", "Bạn có muốn thoát ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                this.Close();
            }
        }
        public void taoLich1(List<string> Thu)
        {
            List<string> thu = Thu;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < thu.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = thu[i];
                dataGridView1.Rows.Add(row);
            }
        }

        private void lblThu2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 2 " + "[ " + dstendinh[0] + " " + dstendinh[1] + " ]";
            taoLich1(Thu2);
        }

        private void lblThu3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 3 " + "[ " + dstendinh[2] + " " + dstendinh[3] + " ]";
            taoLich1(Thu3);
        }

        private void lblThu4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 4 " + "[ " + dstendinh[4] + " " + dstendinh[5] + " ]";
            taoLich1(Thu4);
        }

        private void lblThu5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 5 " + "[ " + dstendinh[6] + " " + dstendinh[7] + " ]";
            taoLich1(Thu5);
        }

        private void lblThu6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 6 " + "[ " + dstendinh[8] + " " + dstendinh[9] + " ]";
            taoLich1(Thu6);
        }

        private void lblThu7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Thứ 7 " + "[ " + dstendinh[10] + " " + dstendinh[11] + " ]";
            taoLich1(Thu7);
        }

        private void lblCN_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = header + " Chủ nhật " + "[ " + dstendinh[12] + " " + dstendinh[13] + " ]";
            taoLich1(CN);
        }

        private void btn_excute_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            docExcel3();
            panel2.Enabled = true;
            dstendinh = xuli.layDanhSachTenCa(3, 3);
            ds = xuli.layDanhSachTenCa(3, 3);
        }            
    }
}
