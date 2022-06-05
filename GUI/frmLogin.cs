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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
//=========================================Method=======================================================================
        public void HandleButtonLogin()
        {
            string userName = textBox_UserName.Text;
            string passWord = textBox_Password.Text;

            if (AccountBUS.Instance.ShowAccount(userName, passWord) == true)
            {
                this.Hide();
                frmFeature frmFeature = new frmFeature();
                frmFeature.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
//======================================================================================================================

//==========================================Event=======================================================================

        private void button_Login_Click(object sender, EventArgs e)
        {
            HandleButtonLogin();
        }

        private void textBox_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_Password.Focus();
            }
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                HandleButtonLogin();
            }
        }

        private void pbPassWord_Click(object sender, EventArgs e)
        {
            if (textBox_Password.UseSystemPasswordChar == true)
            {
                textBox_Password.UseSystemPasswordChar = false;

                Image image = global::GUI.Properties.Resources.Show_password;
                pbShowPassword.Image = image;

               // Image img = global::name_space_of_project.Properties.Resources.test_image;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;

                Image image = global::GUI.Properties.Resources.Show_password;
                pbShowPassword.Image = image;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HandleButtonLogin();
        }
        //======================================================================================================================
    }
}
