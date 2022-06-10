
namespace GUI
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_AddEmployee = new System.Windows.Forms.Panel();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.button_AddEmployee = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Employee = new System.Windows.Forms.RadioButton();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_Genner = new System.Windows.Forms.Panel();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_AddFood = new System.Windows.Forms.Panel();
            this.button_AddFood = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_FoodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_CategoryFood = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_AddEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_Genner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel_AddFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Retaurant Management App";
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(1050, 4);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 38;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_AddEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 633);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // panel_AddEmployee
            // 
            this.panel_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_AddEmployee.Controls.Add(this.dateTimePicker_BirthDate);
            this.panel_AddEmployee.Controls.Add(this.button_AddEmployee);
            this.panel_AddEmployee.Controls.Add(this.textBox_Salary);
            this.panel_AddEmployee.Controls.Add(this.label4);
            this.panel_AddEmployee.Controls.Add(this.panel1);
            this.panel_AddEmployee.Controls.Add(this.panel_Genner);
            this.panel_AddEmployee.Controls.Add(this.label6);
            this.panel_AddEmployee.Controls.Add(this.textBox_EmployeeName);
            this.panel_AddEmployee.Controls.Add(this.label3);
            this.panel_AddEmployee.Location = new System.Drawing.Point(3, 34);
            this.panel_AddEmployee.Name = "panel_AddEmployee";
            this.panel_AddEmployee.Size = new System.Drawing.Size(515, 599);
            this.panel_AddEmployee.TabIndex = 40;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(226, 148);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker_BirthDate.TabIndex = 72;
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.ActiveBorderThickness = 1;
            this.button_AddEmployee.ActiveCornerRadius = 20;
            this.button_AddEmployee.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_AddEmployee.ActiveForecolor = System.Drawing.Color.White;
            this.button_AddEmployee.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddEmployee.BackgroundImage")));
            this.button_AddEmployee.ButtonText = "Add";
            this.button_AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddEmployee.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddEmployee.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_AddEmployee.IdleBorderThickness = 1;
            this.button_AddEmployee.IdleCornerRadius = 20;
            this.button_AddEmployee.IdleFillColor = System.Drawing.Color.White;
            this.button_AddEmployee.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_AddEmployee.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_AddEmployee.Location = new System.Drawing.Point(355, 429);
            this.button_AddEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(140, 61);
            this.button_AddEmployee.TabIndex = 71;
            this.button_AddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Salary.Location = new System.Drawing.Point(229, 384);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(268, 27);
            this.textBox_Salary.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Salary:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Employee);
            this.panel1.Controls.Add(this.radioButton_Admin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(33, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 80);
            this.panel1.TabIndex = 68;
            // 
            // radioButton_Employee
            // 
            this.radioButton_Employee.AutoSize = true;
            this.radioButton_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Employee.ForeColor = System.Drawing.Color.White;
            this.radioButton_Employee.Location = new System.Drawing.Point(304, 29);
            this.radioButton_Employee.Name = "radioButton_Employee";
            this.radioButton_Employee.Size = new System.Drawing.Size(151, 33);
            this.radioButton_Employee.TabIndex = 71;
            this.radioButton_Employee.TabStop = true;
            this.radioButton_Employee.Text = "Employee";
            this.radioButton_Employee.UseVisualStyleBackColor = true;
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Admin.ForeColor = System.Drawing.Color.White;
            this.radioButton_Admin.Location = new System.Drawing.Point(67, 31);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(107, 33);
            this.radioButton_Admin.TabIndex = 70;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(241, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // panel_Genner
            // 
            this.panel_Genner.Controls.Add(this.radioButton_Female);
            this.panel_Genner.Controls.Add(this.radioButton_Male);
            this.panel_Genner.Controls.Add(this.pictureBox2);
            this.panel_Genner.Controls.Add(this.pictureBox3);
            this.panel_Genner.Location = new System.Drawing.Point(33, 199);
            this.panel_Genner.Name = "panel_Genner";
            this.panel_Genner.Size = new System.Drawing.Size(461, 80);
            this.panel_Genner.TabIndex = 67;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.ForeColor = System.Drawing.Color.White;
            this.radioButton_Female.Location = new System.Drawing.Point(304, 29);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(122, 33);
            this.radioButton_Female.TabIndex = 71;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.Color.White;
            this.radioButton_Male.Location = new System.Drawing.Point(67, 31);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(91, 33);
            this.radioButton_Male.TabIndex = 70;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.male;
            this.pictureBox2.Location = new System.Drawing.Point(4, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.Female;
            this.pictureBox3.Location = new System.Drawing.Point(241, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "Birth Date:";
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmployeeName.Location = new System.Drawing.Point(229, 76);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.Size = new System.Drawing.Size(268, 27);
            this.textBox_EmployeeName.TabIndex = 56;
            this.textBox_EmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_EmployeeName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Employee Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_AddFood);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(564, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 633);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Food";
            // 
            // panel_AddFood
            // 
            this.panel_AddFood.Controls.Add(this.button_AddFood);
            this.panel_AddFood.Controls.Add(this.textBox_Price);
            this.panel_AddFood.Controls.Add(this.label9);
            this.panel_AddFood.Controls.Add(this.textBox_FoodName);
            this.panel_AddFood.Controls.Add(this.label8);
            this.panel_AddFood.Controls.Add(this.comboBox_CategoryFood);
            this.panel_AddFood.Controls.Add(this.label7);
            this.panel_AddFood.Location = new System.Drawing.Point(2, 34);
            this.panel_AddFood.Name = "panel_AddFood";
            this.panel_AddFood.Size = new System.Drawing.Size(519, 599);
            this.panel_AddFood.TabIndex = 41;
            // 
            // button_AddFood
            // 
            this.button_AddFood.ActiveBorderThickness = 1;
            this.button_AddFood.ActiveCornerRadius = 20;
            this.button_AddFood.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_AddFood.ActiveForecolor = System.Drawing.Color.White;
            this.button_AddFood.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_AddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddFood.BackgroundImage")));
            this.button_AddFood.ButtonText = "Add";
            this.button_AddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddFood.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddFood.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_AddFood.IdleBorderThickness = 1;
            this.button_AddFood.IdleCornerRadius = 20;
            this.button_AddFood.IdleFillColor = System.Drawing.Color.White;
            this.button_AddFood.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_AddFood.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_AddFood.Location = new System.Drawing.Point(358, 429);
            this.button_AddFood.Margin = new System.Windows.Forms.Padding(6);
            this.button_AddFood.Name = "button_AddFood";
            this.button_AddFood.Size = new System.Drawing.Size(140, 61);
            this.button_AddFood.TabIndex = 72;
            this.button_AddFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Price
            // 
            this.textBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.Location = new System.Drawing.Point(220, 218);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(268, 27);
            this.textBox_Price.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 59;
            this.label9.Text = "Price:";
            // 
            // textBox_FoodName
            // 
            this.textBox_FoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FoodName.Location = new System.Drawing.Point(220, 161);
            this.textBox_FoodName.Name = "textBox_FoodName";
            this.textBox_FoodName.Size = new System.Drawing.Size(268, 27);
            this.textBox_FoodName.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 29);
            this.label8.TabIndex = 57;
            this.label8.Text = "Food Name:";
            // 
            // comboBox_CategoryFood
            // 
            this.comboBox_CategoryFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CategoryFood.FormattingEnabled = true;
            this.comboBox_CategoryFood.Location = new System.Drawing.Point(220, 104);
            this.comboBox_CategoryFood.Name = "comboBox_CategoryFood";
            this.comboBox_CategoryFood.Size = new System.Drawing.Size(268, 30);
            this.comboBox_CategoryFood.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Category:";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel_AddEmployee.ResumeLayout(false);
            this.panel_AddEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_Genner.ResumeLayout(false);
            this.panel_Genner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel_AddFood.ResumeLayout(false);
            this.panel_AddFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_AddEmployee;
        private Bunifu.Framework.UI.BunifuThinButton2 button_AddEmployee;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Employee;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel_Genner;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_EmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel_AddFood;
        private Bunifu.Framework.UI.BunifuThinButton2 button_AddFood;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_FoodName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_CategoryFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
    }
}