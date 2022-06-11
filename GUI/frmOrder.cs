using BUS;
using GUI.Models;
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
            loadTableUpFlowLayoutPanel();
            loadTableUpComboBox();
            loadCategory();
        }
 //==============================================Method====================================================================
        public void loadTableUpFlowLayoutPanel()
        {
            flowLayoutPanel_Table.Controls.Clear();
            List<Table> listTable = new List<Table>();
            //TableBUS.Instance.updateTableWithCustomer();
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

        public void loadTableUpComboBox()
        {
            List<Table> listTable = new List<Table>();
            listTable = TableBUS.Instance.readTable();
            comboBox_Table.DataSource = listTable;
            comboBox_Table.DisplayMember = "tableId";
        }

        public void loadCategory()
        {
            List<Category> listCategory = CategoryBUS.Instance.getListCategory();
            if (listCategory != null)
            {
                comboBox_Category.DataSource = listCategory;
                comboBox_Category.DisplayMember = "CategoryName";
            }
            else
            {
                MessageBox.Show("List category is empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void loadFoodByCategory(string categoryId)
        {
            List<Dish> listDish = new List<Dish>();
            listDish = DishBUS.Instance.getListFoodByCategoryId(categoryId);
            if (listDish != null)
            {
                comboBox_FoodName.DataSource = listDish;
                comboBox_FoodName.DisplayMember = "dishName";
            }
            else
            {
                MessageBox.Show("List dish is empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void loadInfoOrder(DataGridView dtv, string tableId)
        {
            DishBUS.Instance.showInfoOrder(dtv, tableId);
        }
        //=======================================================================================================================

        //==============================================Event====================================================================
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Table).tableId;
            dataGridView_Order.Tag = (sender as Button).Tag;
            loadInfoOrder(dataGridView_Order, tableID);       
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryId = null;

            if (comboBox_Category.SelectedItem == null)
            {
                return;
            }

            Category category = comboBox_Category.SelectedItem as Category;
            categoryId = category.CategoryId;
            loadFoodByCategory(categoryId);
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            string dishId = null;
            int billId = 0;
            int quantity = 0;
            string tableID;

            //Lấy Id của bàn khi ấn vào 1 button 
            tableID = (dataGridView_Order.Tag as Table).tableId;
            //Lấy Id của món nào đó khi ấn chọn món đó
            Dish dish = comboBox_FoodName.SelectedItem as Dish;
            dishId = dish.dishId;
            //Lấy số lượng của món 
            quantity = Convert.ToInt32(numericUpDown_Quantity.Value);
            //Lấy billId thông qua tableId
            billId = BillBUS.Instance.getBillIDByTableId(tableID);

            //Cập nhật lại danh sách các món ăn đã được chọn
            BillDetailBUS.Instance.updateBillDetail(billId, dishId, quantity);
            loadTableUpFlowLayoutPanel();
            loadInfoOrder(dataGridView_Order, tableID);
        }

        private void button_SwicthTable_Click(object sender, EventArgs e)
        {
            string tableId1 = (dataGridView_Order.Tag as Table).tableId;
            string tableId2 = comboBox_Table.Text;
            int billId1 = BillBUS.Instance.getBillIDByTableId(tableId1);
            int billId2 = BillBUS.Instance.getBillIDByTableId(tableId2);

            TableBUS.Instance.switchTable(tableId1, tableId2, billId1, billId2);
            loadTableUpFlowLayoutPanel();
        }
        //=======================================================================================================================
    }
}
