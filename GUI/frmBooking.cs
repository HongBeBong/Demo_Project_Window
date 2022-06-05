using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
            handleFrmBooking();
        }


        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // hàm lấy thông tin lên combobox
        private void displayComboboxTypeTables()
        {
            comboBox_Table.DataSource = TableTypeBUS.Instance.getAllTableTypes();
            comboBox_Table.DisplayMember = "TypeName";
            comboBox_Table.ValueMember = "tableTypeId";

        }

        private void handleFrmBooking()
        {
            // không cho ghi sổ thông tin khách hàng khi chưa kiểm tra bàn
            panelCustomer.Enabled = false;
            // kéo dữ liệu lên combobox
            displayComboboxTypeTables();
        }

        private void button_CheckTable_Click_1(object sender, EventArgs e)
        {
            // lấy id của loại bàn
            string tableTypeId = (string)comboBox_Table.SelectedValue;

            // kiểm tra loại bàn đó còn không
            string tableId = TableBUS.Instance.getAvailableTableId(tableTypeId);

            if (tableId != null)
                panelCustomer.Enabled = true;
            else
                MessageBox.Show("Hết bàn! Quý khách vui lòng chọn loại bàn khác", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
