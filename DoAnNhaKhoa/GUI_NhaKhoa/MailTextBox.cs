using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhaKhoa
{
    public partial class MailTextBox : UserControl
    {
        public MailTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!this.Text.Contains('@') || !this.Text.Contains('.'))
            {
                errorProvider1.SetError(this, "Please enter your user name!");
            }
            else
            {
                errorProvider1.SetError(this, null);
            }
        }
    }
}
