
namespace GUI
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_FoodName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flowLayoutPanel_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_SwicthTable = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_Order = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Quantity,
            this.Price});
            this.dataGridView_Order.Location = new System.Drawing.Point(357, 124);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(729, 472);
            this.dataGridView_Order.TabIndex = 1;
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
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(526, 9);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(214, 28);
            this.comboBox_Category.TabIndex = 2;
            // 
            // comboBox_FoodName
            // 
            this.comboBox_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FoodName.FormattingEnabled = true;
            this.comboBox_FoodName.Location = new System.Drawing.Point(526, 47);
            this.comboBox_FoodName.Name = "comboBox_FoodName";
            this.comboBox_FoodName.Size = new System.Drawing.Size(214, 28);
            this.comboBox_FoodName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Food:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Quantity:";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(526, 91);
            this.numericUpDown_Quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(214, 27);
            this.numericUpDown_Quantity.TabIndex = 7;
            this.numericUpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Garam", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose Table:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(957, 607);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.pictureBox_Exit;
            // 
            // flowLayoutPanel_Table
            // 
            this.flowLayoutPanel_Table.AutoScroll = true;
            this.flowLayoutPanel_Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel_Table.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanel_Table.Name = "flowLayoutPanel_Table";
            this.flowLayoutPanel_Table.Size = new System.Drawing.Size(339, 693);
            this.flowLayoutPanel_Table.TabIndex = 19;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button_SwicthTable
            // 
            this.button_SwicthTable.ActiveBorderThickness = 1;
            this.button_SwicthTable.ActiveCornerRadius = 20;
            this.button_SwicthTable.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_SwicthTable.ActiveForecolor = System.Drawing.Color.White;
            this.button_SwicthTable.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_SwicthTable.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_SwicthTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SwicthTable.BackgroundImage")));
            this.button_SwicthTable.ButtonText = "Swicth Table";
            this.button_SwicthTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SwicthTable.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SwicthTable.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_SwicthTable.IdleBorderThickness = 1;
            this.button_SwicthTable.IdleCornerRadius = 20;
            this.button_SwicthTable.IdleFillColor = System.Drawing.Color.White;
            this.button_SwicthTable.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_SwicthTable.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_SwicthTable.Location = new System.Drawing.Point(833, 658);
            this.button_SwicthTable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_SwicthTable.Name = "button_SwicthTable";
            this.button_SwicthTable.Size = new System.Drawing.Size(253, 43);
            this.button_SwicthTable.TabIndex = 23;
            this.button_SwicthTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Order
            // 
            this.button_Order.ActiveBorderThickness = 1;
            this.button_Order.ActiveCornerRadius = 20;
            this.button_Order.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_Order.ActiveForecolor = System.Drawing.Color.White;
            this.button_Order.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_Order.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Order.BackgroundImage")));
            this.button_Order.ButtonText = "ADD";
            this.button_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Order.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Order.IdleBorderThickness = 1;
            this.button_Order.IdleCornerRadius = 20;
            this.button_Order.IdleFillColor = System.Drawing.Color.White;
            this.button_Order.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_Order.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Order.Location = new System.Drawing.Point(857, 70);
            this.button_Order.Margin = new System.Windows.Forms.Padding(5);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(86, 43);
            this.button_Order.TabIndex = 22;
            this.button_Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = global::GUI.Properties.Resources.Exit;
            this.pictureBox_Exit.Location = new System.Drawing.Point(1040, 9);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 14;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Cart;
            this.pictureBox1.Location = new System.Drawing.Point(857, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.button_SwicthTable);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.flowLayoutPanel_Table);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_FoodName);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.dataGridView_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_FoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Order;
        private Bunifu.Framework.UI.BunifuThinButton2 button_SwicthTable;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}