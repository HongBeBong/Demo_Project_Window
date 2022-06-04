
namespace GUI
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.flowLayoutPanel_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView_CheckBill = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_StaffName = new System.Windows.Forms.TextBox();
            this.textBID_BillID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_StaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Address_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.button_Order = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CheckBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Table
            // 
            this.flowLayoutPanel_Table.AutoScroll = true;
            this.flowLayoutPanel_Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel_Table.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanel_Table.Name = "flowLayoutPanel_Table";
            this.flowLayoutPanel_Table.Size = new System.Drawing.Size(339, 693);
            this.flowLayoutPanel_Table.TabIndex = 20;
            // 
            // dataGridView_CheckBill
            // 
            this.dataGridView_CheckBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CheckBill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_CheckBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CheckBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Quantity,
            this.Price,
            this.TotalMoney});
            this.dataGridView_CheckBill.Location = new System.Drawing.Point(357, 218);
            this.dataGridView_CheckBill.Name = "dataGridView_CheckBill";
            this.dataGridView_CheckBill.RowHeadersWidth = 51;
            this.dataGridView_CheckBill.RowTemplate.Height = 24;
            this.dataGridView_CheckBill.Size = new System.Drawing.Size(729, 395);
            this.dataGridView_CheckBill.TabIndex = 21;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // TotalMoney
            // 
            this.TotalMoney.HeaderText = "Total Money";
            this.TotalMoney.MinimumWidth = 6;
            this.TotalMoney.Name = "TotalMoney";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Retaurant Management App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Staff\'s name:";
            // 
            // textBox_StaffName
            // 
            this.textBox_StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StaffName.Location = new System.Drawing.Point(477, 175);
            this.textBox_StaffName.Name = "textBox_StaffName";
            this.textBox_StaffName.Size = new System.Drawing.Size(192, 27);
            this.textBox_StaffName.TabIndex = 25;
            // 
            // textBID_BillID
            // 
            this.textBID_BillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBID_BillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBID_BillID.Location = new System.Drawing.Point(477, 84);
            this.textBID_BillID.Name = "textBID_BillID";
            this.textBID_BillID.Size = new System.Drawing.Size(192, 27);
            this.textBID_BillID.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bill ID:";
            // 
            // textBox_StaffID
            // 
            this.textBox_StaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StaffID.Location = new System.Drawing.Point(477, 127);
            this.textBox_StaffID.Name = "textBox_StaffID";
            this.textBox_StaffID.Size = new System.Drawing.Size(192, 27);
            this.textBox_StaffID.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Staff\'s ID:";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(900, 127);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(186, 27);
            this.textBox_CustomerName.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Customet Name:";
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerID.Location = new System.Drawing.Point(900, 84);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(186, 27);
            this.textBox_CustomerID.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(745, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customer ID:";
            // 
            // Address_Address
            // 
            this.Address_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Address.Location = new System.Drawing.Point(900, 175);
            this.Address_Address.Name = "Address_Address";
            this.Address_Address.Size = new System.Drawing.Size(186, 27);
            this.Address_Address.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Discount;
            this.pictureBox1.Location = new System.Drawing.Point(357, 645);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = global::GUI.Properties.Resources.Exit;
            this.pictureBox_Exit.Location = new System.Drawing.Point(1040, 9);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 22;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Discount(%)";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(424, 675);
            this.numericUpDown_Quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(111, 27);
            this.numericUpDown_Quantity.TabIndex = 38;
            this.numericUpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Order
            // 
            this.button_Order.ActiveBorderThickness = 1;
            this.button_Order.ActiveCornerRadius = 20;
            this.button_Order.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_Order.ActiveForecolor = System.Drawing.Color.White;
            this.button_Order.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_Order.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Order.BackgroundImage")));
            this.button_Order.ButtonText = "Total Money";
            this.button_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Order.Font = new System.Drawing.Font("VNI-Boston Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Order.IdleBorderThickness = 1;
            this.button_Order.IdleCornerRadius = 20;
            this.button_Order.IdleFillColor = System.Drawing.Color.White;
            this.button_Order.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_Order.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Order.Location = new System.Drawing.Point(918, 632);
            this.button_Order.Margin = new System.Windows.Forms.Padding(5);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(168, 68);
            this.button_Order.TabIndex = 39;
            this.button_Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Address_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_StaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBID_BillID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_StaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.dataGridView_CheckBill);
            this.Controls.Add(this.flowLayoutPanel_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CheckBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Table;
        private System.Windows.Forms.DataGridView dataGridView_CheckBill;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_StaffName;
        private System.Windows.Forms.TextBox textBID_BillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_StaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Address_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Order;
    }
}