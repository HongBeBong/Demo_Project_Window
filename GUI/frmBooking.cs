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
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }


        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button_CheckTable_Click(object sender, EventArgs e)
        {

            /*comboBox_Table.DataSource = TableTypeBUS.Instance.getlistTableTypeBUS();
            comboBox_Table.DisplayMember = "TypeName";
            comboBox_Table.ValueMember = "tableTypeId";
            textBox_CustomerName.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            textBox_PhoneNumber.ReadOnly = true;
            checkBox_FeMale.Enabled = true;
            checkBox_Male.Enabled = true;

            string tableTypeId = comboBox_Table.ValueMember;

            bool check = */
            


        }
    }
}
