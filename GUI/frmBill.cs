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
            pushDataComboBoxStaffName();
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
                    btn.Click += btn_Click;
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


        public void loadBill(DataGridView dtv, int billId)
        {
            try
            {
                BillBUS.Instance.loadInfoBill(dtv, billId);
            }
            catch
            {
                MessageBox.Show("Lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy id của table
                string tableID = ((sender as Button).Tag as Table).tableId;
                int customerId = BillBUS.Instance.getCustomerId(tableID, -1);
                int billId = 0;

                // lấy iD khách hàng tương ứng với bàn trong sổ đặt bàn và chưa thanh toán
                Customer cus = CustomerBUS.Instance.getCustomer(customerId);
                if (cus == null)
                    MessageBox.Show("Vui lòng kiểm tra lại bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    billId = BillBUS.Instance.getBillId(cus.customerId, tableID);
                    if (billId != -1)
                    {
                        txtBill_Id.Text = billId.ToString();
                        txtCustomerName.Text = cus.fullName;
                        txtAddress.Text = cus.address;
                        txtTableID.Text = tableID;
                        loadBill(dataGridView_CheckBill, billId);
                    }
                    else
                        MessageBox.Show("Chưa có thông tin bill!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Kéo data lên datagridview


            }
            catch (Exception error)
            {
               
                MessageBox.Show( String.Format("Lỗi {0}!!!", error), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=======================================================================================================================

        //==============================================Event====================================================================

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pushDataComboBoxStaffName()
        {
            cbStaffName.DataSource = EmployeeBUS.Instance.getListEmployees();
            cbStaffName.ValueMember = "employeeId";
            cbStaffName.DisplayMember = "fullName";
        }

        private void btnTotalMoney_Click(object sender, EventArgs e)
        {
            try
            {
                // tính tổng bill
                int tong = 0;
                foreach (DataGridViewRow row in dataGridView_CheckBill.Rows)
                {
                    tong = tong  +  (int)row.Cells[3].Value;
                }
                int percent_discount = (int)numericUpDown_Quantity.Value;
                int discount = (percent_discount * tong) / 100;

                tong = tong - discount;

                string totalPrice = tong.ToString() + "VND";

                // cập nhật ngày tạo và tên nhân viên xuất bill
                int billId = Int32.Parse(txtBill_Id.Text);
                string employeeId = (string)cbStaffName.SelectedValue;

                bool check = BillBUS.Instance.updateEmployeeAndTime(billId, employeeId, tong);
                if (check == true)
                {
                    Bill bill = BillBUS.Instance.getBillById(billId);
                    txtTotalMoney.Text = totalPrice;
                    txtDate.Text = bill.createAt.ToString();
                  
                    TableBUS.Instance.updateTableStatus(bill.tableId, "ON");
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Chưa cập nhật hóa đơn được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
//=======================================================================================================================
}
