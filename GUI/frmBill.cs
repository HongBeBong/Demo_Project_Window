using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;
using BUS;

namespace GUI
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
            LoadTable();
        }
//==============================================Method====================================================================       }
        public void LoadTable()
        {
            flowLayoutPanel_Table.Controls.Clear();
            List<Table> listTable = new List<Table>();
            listTable = TableBUS.Instance.readTable();

            if (listTable != null)
            {
                foreach (Table table in listTable)
                {
                    Button btn = new Button() { Width = 110, Height = 110 };
                    btn.Text = table.tableId + Environment.NewLine + "\n" + table.status;
                    btn.Font = new Font("Arial", (float)10.5);
                   // btn.Click += btn_Click;
                    btn.Tag = table;

                    if (table.status.Equals("ON"))
                    {
                        btn.BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = Color.White;
                    }
                    flowLayoutPanel_Table.Controls.Add(btn);
                }
            }
            else
            {
                MessageBox.Show("List table is empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
//=======================================================================================================================

//==============================================Event====================================================================

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
//=======================================================================================================================
}
