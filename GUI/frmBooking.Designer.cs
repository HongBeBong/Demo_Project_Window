
namespace GUI
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panel_Genner = new System.Windows.Forms.Panel();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Book = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTimePicker_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_CheckTable = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_Table = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.panel_Genner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panelCustomer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox_Exit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 690);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.Background_booking_form;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(464, 687);
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.panel_Genner);
            this.panelCustomer.Controls.Add(this.button_Book);
            this.panelCustomer.Controls.Add(this.dateTimePicker_CheckIn);
            this.panelCustomer.Controls.Add(this.label6);
            this.panelCustomer.Controls.Add(this.textBox_Address);
            this.panelCustomer.Controls.Add(this.label4);
            this.panelCustomer.Controls.Add(this.textBox_PhoneNumber);
            this.panelCustomer.Controls.Add(this.label3);
            this.panelCustomer.Controls.Add(this.textBox_CustomerName);
            this.panelCustomer.Controls.Add(this.label1);
            this.panelCustomer.Location = new System.Drawing.Point(507, 309);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(493, 358);
            this.panelCustomer.TabIndex = 55;
            // 
            // panel_Genner
            // 
            this.panel_Genner.Controls.Add(this.radioButton_Female);
            this.panel_Genner.Controls.Add(this.radioButton_Male);
            this.panel_Genner.Controls.Add(this.pictureBox2);
            this.panel_Genner.Controls.Add(this.pictureBox3);
            this.panel_Genner.Location = new System.Drawing.Point(16, 149);
            this.panel_Genner.Name = "panel_Genner";
            this.panel_Genner.Size = new System.Drawing.Size(461, 80);
            this.panel_Genner.TabIndex = 66;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.ForeColor = System.Drawing.Color.White;
            this.radioButton_Female.Location = new System.Drawing.Point(328, 31);
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
            this.pictureBox3.Location = new System.Drawing.Point(265, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // button_Book
            // 
            this.button_Book.ActiveBorderThickness = 1;
            this.button_Book.ActiveCornerRadius = 20;
            this.button_Book.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_Book.ActiveForecolor = System.Drawing.Color.White;
            this.button_Book.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.button_Book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Book.BackgroundImage")));
            this.button_Book.ButtonText = "BOOK";
            this.button_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Book.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Book.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Book.IdleBorderThickness = 1;
            this.button_Book.IdleCornerRadius = 20;
            this.button_Book.IdleFillColor = System.Drawing.Color.White;
            this.button_Book.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_Book.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Book.Location = new System.Drawing.Point(283, 297);
            this.button_Book.Margin = new System.Windows.Forms.Padding(6);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(199, 48);
            this.button_Book.TabIndex = 65;
            this.button_Book.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // dateTimePicker_CheckIn
            // 
            this.dateTimePicker_CheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_CheckIn.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker_CheckIn.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker_CheckIn.Location = new System.Drawing.Point(214, 255);
            this.dateTimePicker_CheckIn.Name = "dateTimePicker_CheckIn";
            this.dateTimePicker_CheckIn.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker_CheckIn.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Date Check In:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Address.Location = new System.Drawing.Point(228, 106);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(249, 27);
            this.textBox_Address.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Address:";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(228, 55);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(249, 27);
            this.textBox_PhoneNumber.TabIndex = 56;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PhoneNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Phone Number:";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(228, 3);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(249, 27);
            this.textBox_CustomerName.TabIndex = 54;
            this.textBox_CustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CustomerName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_CheckTable);
            this.panel2.Controls.Add(this.comboBox_Table);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(507, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 100);
            this.panel2.TabIndex = 54;
            // 
            // button_CheckTable
            // 
            this.button_CheckTable.ActiveBorderThickness = 1;
            this.button_CheckTable.ActiveCornerRadius = 20;
            this.button_CheckTable.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_CheckTable.ActiveForecolor = System.Drawing.Color.White;
            this.button_CheckTable.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_CheckTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.button_CheckTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CheckTable.BackgroundImage")));
            this.button_CheckTable.ButtonText = "CHECK TABLE";
            this.button_CheckTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CheckTable.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckTable.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_CheckTable.IdleBorderThickness = 1;
            this.button_CheckTable.IdleCornerRadius = 20;
            this.button_CheckTable.IdleFillColor = System.Drawing.Color.White;
            this.button_CheckTable.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_CheckTable.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_CheckTable.Location = new System.Drawing.Point(274, 39);
            this.button_CheckTable.Margin = new System.Windows.Forms.Padding(6);
            this.button_CheckTable.Name = "button_CheckTable";
            this.button_CheckTable.Size = new System.Drawing.Size(199, 45);
            this.button_CheckTable.TabIndex = 52;
            this.button_CheckTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CheckTable.Click += new System.EventHandler(this.button_CheckTable_Click_1);
            // 
            // comboBox_Table
            // 
            this.comboBox_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Table.FormattingEnabled = true;
            this.comboBox_Table.Location = new System.Drawing.Point(227, 3);
            this.comboBox_Table.Name = "comboBox_Table";
            this.comboBox_Table.Size = new System.Drawing.Size(249, 30);
            this.comboBox_Table.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Table:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo_nha_hang;
            this.pictureBox1.Location = new System.Drawing.Point(507, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(514, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Retaurant Management App";
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(1007, 20);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 17;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panel_Genner.ResumeLayout(false);
            this.panel_Genner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Book;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CheckTable;
        private System.Windows.Forms.ComboBox comboBox_Table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Genner;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}