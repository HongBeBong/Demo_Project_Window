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
            {
                panelCustomer.Enabled = true;
                resetPanelCustomer();
            }
            else
                MessageBox.Show("Hết bàn! Quý khách vui lòng chọn loại bàn khác", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void textBox_CustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) textBox_PhoneNumber.Focus();
        }

        private void textBox_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) textBox_Address.Focus();
        }

        private int getInsertedCustomer()
        {
            // lấy thông tin từ giao diện
            string customerName = textBox_CustomerName.Text;
            string phone = textBox_PhoneNumber.Text;
            string address = textBox_Address.Text;
            string gender;
            if (radioButton_Female.Checked == true)
                gender = "Female";
            else 
                gender = "Male";
            // trả về true nếu thêm thành công, ngược lại: trả về false
            return CustomerBUS.Instance.addCustomer(customerName, phone, address, gender);
        }

        // hàm xóa panel
        private void resetPanelCustomer()
        {
            textBox_CustomerName.ResetText();
            textBox_PhoneNumber.ResetText();
            textBox_Address.ResetText();
            radioButton_Female.Checked = false;
            radioButton_Male.Checked = false;
        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            // lấy id khách hàng
            int customerId = getInsertedCustomer();

            // lấy id của loại bàn
            string tableTypeId = (string)comboBox_Table.SelectedValue;

            // lấy id của bàn 
            string tableId = TableBUS.Instance.getAvailableTableId(tableTypeId);

            // lấy thời gian tới
            DateTime date = dateTimePicker_CheckIn.Value;

            if (customerId != -1)
            {
                // kiểm tra xem add thông tin đặt bàn chưa
                bool check = ReservationBUS.Instance.addReservation(customerId, tableId, date);

                if (check == true)
                {
                    // khóa panel
                    panelCustomer.Enabled = false;

                    // đổi trạng thái đặt bàng thành trống
                    TableBUS.Instance.updateTableStatus(tableId, "ON");

                    // thêm bill trống
                    addBill(customerId, tableId);

                    // xuất thông báo
                    MessageBox.Show(String.Format("Đặt bàn {0} thàng công", tableId), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // thêm bill sau khi đặt bàn thành công
        private void addBill(int customerId, string tableId)
        {
            BillBUS.Instance.addBill(customerId, tableId);
        }

    }
}
