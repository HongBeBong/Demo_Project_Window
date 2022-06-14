
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
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtBill_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.btnTotalMoney = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTabbleID = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.cbStaffName = new System.Windows.Forms.ComboBox();
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
            this.Total});
            this.dataGridView_CheckBill.Location = new System.Drawing.Point(357, 218);
            this.dataGridView_CheckBill.Name = "dataGridView_CheckBill";
            this.dataGridView_CheckBill.RowHeadersWidth = 51;
            this.dataGridView_CheckBill.RowTemplate.Height = 24;
            this.dataGridView_CheckBill.Size = new System.Drawing.Size(729, 395);
            this.dataGridView_CheckBill.TabIndex = 21;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodName.DataPropertyName = "dishName";
            this.FoodName.Frozen = true;
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Retaurant Management App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Staff\'s name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(817, 78);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(255, 27);
            this.txtCustomerName.TabIndex = 25;
            // 
            // txtBill_Id
            // 
            this.txtBill_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill_Id.Location = new System.Drawing.Point(475, 74);
            this.txtBill_Id.Name = "txtBill_Id";
            this.txtBill_Id.ReadOnly = true;
            this.txtBill_Id.Size = new System.Drawing.Size(73, 27);
            this.txtBill_Id.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bill ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(624, 81);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(150, 20);
            this.lblCustomerName.TabIndex = 34;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Discount;
            this.pictureBox1.Location = new System.Drawing.Point(357, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = global::GUI.Properties.Resources.Exit;
            this.pictureBox_Exit.Location = new System.Drawing.Point(1026, 12);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 22;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(421, 632);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(114, 20);
            this.lblDiscount.TabIndex = 37;
            this.lblDiscount.Text = "Discount(%)";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(424, 662);
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
            // btnTotalMoney
            // 
            this.btnTotalMoney.ActiveBorderThickness = 1;
            this.btnTotalMoney.ActiveCornerRadius = 20;
            this.btnTotalMoney.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTotalMoney.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalMoney.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalMoney.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTotalMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalMoney.BackgroundImage")));
            this.btnTotalMoney.ButtonText = "Total Money";
            this.btnTotalMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalMoney.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTotalMoney.IdleBorderThickness = 1;
            this.btnTotalMoney.IdleCornerRadius = 20;
            this.btnTotalMoney.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalMoney.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTotalMoney.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalMoney.Location = new System.Drawing.Point(696, 621);
            this.btnTotalMoney.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotalMoney.Name = "btnTotalMoney";
            this.btnTotalMoney.Size = new System.Drawing.Size(168, 68);
            this.btnTotalMoney.TabIndex = 39;
            this.btnTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTotalMoney.Click += new System.EventHandler(this.btnTotalMoney_Click);
            // 
            // lblTabbleID
            // 
            this.lblTabbleID.AutoSize = true;
            this.lblTabbleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabbleID.Location = new System.Drawing.Point(357, 128);
            this.lblTabbleID.Name = "lblTabbleID";
            this.lblTabbleID.Size = new System.Drawing.Size(86, 20);
            this.lblTabbleID.TabIndex = 34;
            this.lblTabbleID.Text = "Table ID:";
            // 
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(475, 124);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(73, 27);
            this.txtTableID.TabIndex = 35;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(434, 170);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(174, 27);
            this.txtDate.TabIndex = 25;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(364, 173);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(817, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(255, 27);
            this.txtAddress.TabIndex = 35;
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(872, 632);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(186, 38);
            this.txtTotalMoney.TabIndex = 40;
            // 
            // cbStaffName
            // 
            this.cbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffName.FormattingEnabled = true;
            this.cbStaffName.Location = new System.Drawing.Point(817, 118);
            this.cbStaffName.Name = "cbStaffName";
            this.cbStaffName.Size = new System.Drawing.Size(255, 30);
            this.cbStaffName.TabIndex = 41;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.cbStaffName);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.btnTotalMoney);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblTabbleID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBill_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblDate);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBill_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTotalMoney;
        private System.Windows.Forms.Label lblTabbleID;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbStaffName;
    }
}