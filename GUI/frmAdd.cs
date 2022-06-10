using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_EmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) dateTimePicker_BirthDate.Focus();
        }
    }
}
