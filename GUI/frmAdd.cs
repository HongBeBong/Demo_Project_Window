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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
            showCategory();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_EmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) dateTimePicker_BirthDate.Focus();
        }

        private void resetPanelEmployee()
        {
            textBox_EmployeeName.ResetText();
            textBox_Salary.ResetText();
            dateTimePicker_BirthDate.ResetText();
            radioButton_Admin.Checked = false;
            radioButton_Employee.Checked = false;
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;

            textBox_EmployeeName.Focus();
        }


       // ADD nhân viên

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string id = EmployeeBUS.Instance.createNextEmployeeId();

                string name = textBox_EmployeeName.Text;

                DateTime birth = dateTimePicker_BirthDate.Value;

                string gender;
                if (radioButton_Male.Checked == true)
                    gender = "Nam";
                else
                    gender = "Nữ";

                string role;
                if (radioButton_Admin.Checked == true)
                    role = "Admin";
                else
                    role = "Staff";

                int salary = Int32.Parse(textBox_Salary.Text);

                bool check = EmployeeBUS.Instance.addNewEmployee(id, role, name, gender, birth, salary);
                if (check == true)
                {
                    MessageBox.Show(String.Format("Nhân viên mới có mã số là {0}", id), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetPanelEmployee();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi !!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        // ADD MÓN ĂN

        // hàm đưa dữ liệu lên combobox
        private void showCategory()
        {
            comboBox_CategoryFood.DataSource = CategoryBUS.Instance.getListCategory();
            comboBox_CategoryFood.ValueMember = "CategoryId";
            comboBox_CategoryFood.DisplayMember = "CategoryName";

        }

        private void textBox_FoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) textBox_Price.Focus();
        }


        private void resetPanelAddFood()
        {
            textBox_FoodName.ResetText();
            textBox_Price.ResetText();
            textBox_FoodName.Focus();
        }

        private void button_AddFood_Click(object sender, EventArgs e)
        {

            try
            {
                // tạo id cho món mới
                string dishId = DishBUS.Instance.createNextDishId();

                // lấy giá trị trên combox
                string categoryId = (string)comboBox_CategoryFood.SelectedValue;

                // lấy tên món ăn
                string foodName = textBox_FoodName.Text;

                // lấy giá
                int price = Int32.Parse(textBox_Price.Text);

                // gọi hàm thêm món
                bool check = DishBUS.Instance.addNewDish(dishId, foodName, price, categoryId);
                if (check == true)
                {
                    MessageBox.Show(String.Format("Món mới có mã số {0}", dishId), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetPanelAddFood();
            }
            catch
            {
                MessageBox.Show("Có lỗi !!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
