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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
            timer_Load.Start();
        }
        int startPoint = 0;
        private void timer_Load_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            bunifuProgressBar_Load.Value = startPoint;
            if (bunifuProgressBar_Load.Value == 100)
            {
                bunifuProgressBar_Load.Value = 0;
                timer_Load.Stop();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }
    }
}
