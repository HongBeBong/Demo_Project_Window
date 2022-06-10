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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            LoadTable();
        }
 //==============================================Method====================================================================
        public void LoadTable()
        {
            flowLayoutPanel_Table.Controls.Clear();

            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button() { Width = 110, Height = 110 };
                btn.Font = new Font("Times New Roman",(float)8.2);
                // Tạo Event xử lí Click
                // Tạo thẻ Tag để lưu trữ và xử lí thông tin
                if (i % 2 == 0)
                {
                    btn.Text = "Bàn " + (i + 1).ToString() + "\n" + "Trống";
                    btn.BackColor = Color.BlanchedAlmond;
                }
                else
                {
                    btn.Text = "Bàn " + (i + 1).ToString() + "\n" + "Có người";
                    btn.BackColor = Color.Gray;
                }
                flowLayoutPanel_Table.Controls.Add(btn);
            }
        }

//=======================================================================================================================

//==============================================Event====================================================================
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//=======================================================================================================================
    }
}
