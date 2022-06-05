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
    public partial class frmFeature : Form
    {
        public frmFeature()
        {
            InitializeComponent();
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            if (panel_Contain.Controls.Count == 0)
            {
                frmOrder frmOrder = new frmOrder();
                frmOrder.TopLevel = false;
                panel_Contain.Controls.Add(frmOrder);
                frmOrder.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng tắt Form hiện tại để có thể thao tác với Form mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFeature_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button_CheckBill_Click(object sender, EventArgs e)
        {
            if (panel_Contain.Controls.Count == 0)
            {
                frmBill frmBill = new frmBill();
                frmBill.TopLevel = false;
                panel_Contain.Controls.Add(frmBill);
                frmBill.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng tắt Form hiện tại để có thể thao tác với Form mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Statistical_Click(object sender, EventArgs e)
        {
            if (panel_Contain.Controls.Count == 0)
            {
                frmStatistical frmStatistical = new frmStatistical();
                frmStatistical.TopLevel = false;
                panel_Contain.Controls.Add(frmStatistical);
                frmStatistical.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng tắt Form hiện tại để có thể thao tác với Form mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Booking_Click(object sender, EventArgs e)
        {
            if (panel_Contain.Controls.Count == 0)
            {
                frmBooking frmBooking = new frmBooking();
                frmBooking.TopLevel = false;
                panel_Contain.Controls.Add(frmBooking);
                frmBooking.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng tắt Form hiện tại để có thể thao tác với Form mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Trouble_Click(object sender, EventArgs e)
        {
            if (panel_Contain.Controls.Count == 0)
            {
                frmAdd frmAdd = new frmAdd();
                frmAdd.TopLevel = false;
                panel_Contain.Controls.Add(frmAdd);
                frmAdd.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng tắt Form hiện tại để có thể thao tác với Form mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
