
namespace GUI
{
    partial class frmStatistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistical));
            this.tabControl_Statistial = new System.Windows.Forms.TabControl();
            this.tabPage_Turnover = new System.Windows.Forms.TabPage();
            this.panel_ShowChart = new System.Windows.Forms.Panel();
            this.dataGridView_Turnover = new System.Windows.Forms.DataGridView();
            this.DateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Statistial = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.tabPage_Foods = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Statistial_Foods = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTimePicker_To_Foods = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From_Foods = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Statistial.SuspendLayout();
            this.tabPage_Turnover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Turnover)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage_Foods.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Statistial
            // 
            this.tabControl_Statistial.Controls.Add(this.tabPage_Turnover);
            this.tabControl_Statistial.Controls.Add(this.tabPage_Foods);
            this.tabControl_Statistial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl_Statistial.Location = new System.Drawing.Point(0, 65);
            this.tabControl_Statistial.Name = "tabControl_Statistial";
            this.tabControl_Statistial.SelectedIndex = 0;
            this.tabControl_Statistial.Size = new System.Drawing.Size(1094, 637);
            this.tabControl_Statistial.TabIndex = 0;
            // 
            // tabPage_Turnover
            // 
            this.tabPage_Turnover.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabPage_Turnover.Controls.Add(this.panel_ShowChart);
            this.tabPage_Turnover.Controls.Add(this.dataGridView_Turnover);
            this.tabPage_Turnover.Controls.Add(this.panel2);
            this.tabPage_Turnover.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Turnover.Name = "tabPage_Turnover";
            this.tabPage_Turnover.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Turnover.Size = new System.Drawing.Size(1086, 608);
            this.tabPage_Turnover.TabIndex = 0;
            this.tabPage_Turnover.Text = "Turnover";
            // 
            // panel_ShowChart
            // 
            this.panel_ShowChart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_ShowChart.Location = new System.Drawing.Point(11, 267);
            this.panel_ShowChart.Name = "panel_ShowChart";
            this.panel_ShowChart.Size = new System.Drawing.Size(1066, 335);
            this.panel_ShowChart.TabIndex = 2;
            // 
            // dataGridView_Turnover
            // 
            this.dataGridView_Turnover.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Turnover.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Turnover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Turnover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCheckIn,
            this.DateCheckOut,
            this.CustomerName,
            this.TableName,
            this.Discount,
            this.TotalMoney});
            this.dataGridView_Turnover.Location = new System.Drawing.Point(11, 60);
            this.dataGridView_Turnover.Name = "dataGridView_Turnover";
            this.dataGridView_Turnover.RowHeadersWidth = 51;
            this.dataGridView_Turnover.RowTemplate.Height = 24;
            this.dataGridView_Turnover.Size = new System.Drawing.Size(1066, 201);
            this.dataGridView_Turnover.TabIndex = 1;
            // 
            // DateCheckIn
            // 
            this.DateCheckIn.HeaderText = "Date Check In";
            this.DateCheckIn.MinimumWidth = 6;
            this.DateCheckIn.Name = "DateCheckIn";
            // 
            // DateCheckOut
            // 
            this.DateCheckOut.HeaderText = "Date Check Out";
            this.DateCheckOut.MinimumWidth = 6;
            this.DateCheckOut.Name = "DateCheckOut";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Tabel";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            // 
            // TotalMoney
            // 
            this.TotalMoney.HeaderText = "Total Money";
            this.TotalMoney.MinimumWidth = 6;
            this.TotalMoney.Name = "TotalMoney";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button_Statistial);
            this.panel2.Controls.Add(this.dateTimePicker_To);
            this.panel2.Controls.Add(this.dateTimePicker_From);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 48);
            this.panel2.TabIndex = 0;
            // 
            // button_Statistial
            // 
            this.button_Statistial.ActiveBorderThickness = 1;
            this.button_Statistial.ActiveCornerRadius = 20;
            this.button_Statistial.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial.ActiveForecolor = System.Drawing.Color.White;
            this.button_Statistial.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Statistial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Statistial.BackgroundImage")));
            this.button_Statistial.ButtonText = "Statistial";
            this.button_Statistial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Statistial.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Statistial.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial.IdleBorderThickness = 1;
            this.button_Statistial.IdleCornerRadius = 20;
            this.button_Statistial.IdleFillColor = System.Drawing.Color.White;
            this.button_Statistial.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_Statistial.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial.Location = new System.Drawing.Point(445, -4);
            this.button_Statistial.Margin = new System.Windows.Forms.Padding(6);
            this.button_Statistial.Name = "button_Statistial";
            this.button_Statistial.Size = new System.Drawing.Size(182, 52);
            this.button_Statistial.TabIndex = 24;
            this.button_Statistial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(807, 12);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker_To.TabIndex = 1;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(3, 12);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker_From.TabIndex = 0;
            // 
            // tabPage_Foods
            // 
            this.tabPage_Foods.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage_Foods.Controls.Add(this.panel3);
            this.tabPage_Foods.Controls.Add(this.panel4);
            this.tabPage_Foods.Controls.Add(this.dataGridView1);
            this.tabPage_Foods.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Foods.Name = "tabPage_Foods";
            this.tabPage_Foods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Foods.Size = new System.Drawing.Size(1086, 608);
            this.tabPage_Foods.TabIndex = 1;
            this.tabPage_Foods.Text = "Foods";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.button_Statistial_Foods);
            this.panel3.Controls.Add(this.dateTimePicker_To_Foods);
            this.panel3.Controls.Add(this.dateTimePicker_From_Foods);
            this.panel3.Location = new System.Drawing.Point(7, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 48);
            this.panel3.TabIndex = 3;
            // 
            // button_Statistial_Foods
            // 
            this.button_Statistial_Foods.ActiveBorderThickness = 1;
            this.button_Statistial_Foods.ActiveCornerRadius = 20;
            this.button_Statistial_Foods.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial_Foods.ActiveForecolor = System.Drawing.Color.White;
            this.button_Statistial_Foods.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial_Foods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Statistial_Foods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Statistial_Foods.BackgroundImage")));
            this.button_Statistial_Foods.ButtonText = "Statistial";
            this.button_Statistial_Foods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Statistial_Foods.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Statistial_Foods.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial_Foods.IdleBorderThickness = 1;
            this.button_Statistial_Foods.IdleCornerRadius = 20;
            this.button_Statistial_Foods.IdleFillColor = System.Drawing.Color.White;
            this.button_Statistial_Foods.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_Statistial_Foods.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_Statistial_Foods.Location = new System.Drawing.Point(445, -4);
            this.button_Statistial_Foods.Margin = new System.Windows.Forms.Padding(6);
            this.button_Statistial_Foods.Name = "button_Statistial_Foods";
            this.button_Statistial_Foods.Size = new System.Drawing.Size(182, 52);
            this.button_Statistial_Foods.TabIndex = 24;
            this.button_Statistial_Foods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_To_Foods
            // 
            this.dateTimePicker_To_Foods.Location = new System.Drawing.Point(807, 12);
            this.dateTimePicker_To_Foods.Name = "dateTimePicker_To_Foods";
            this.dateTimePicker_To_Foods.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker_To_Foods.TabIndex = 1;
            // 
            // dateTimePicker_From_Foods
            // 
            this.dateTimePicker_From_Foods.Location = new System.Drawing.Point(3, 12);
            this.dateTimePicker_From_Foods.Name = "dateTimePicker_From_Foods";
            this.dateTimePicker_From_Foods.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker_From_Foods.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(7, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1069, 330);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Quantity,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.FoodName});
            this.dataGridView1.Location = new System.Drawing.Point(8, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 201);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date Check In";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quanntity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Check Out";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tabel";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "FoodName";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 47);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Image = global::GUI.Properties.Resources.Exit;
            this.pictureBox_Exit.Location = new System.Drawing.Point(1033, 3);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit.TabIndex = 27;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Retaurant Management App";
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl_Statistial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrouble";
            this.tabControl_Statistial.ResumeLayout(false);
            this.tabPage_Turnover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Turnover)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage_Foods.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Statistial;
        private System.Windows.Forms.TabPage tabPage_Turnover;
        private System.Windows.Forms.TabPage tabPage_Foods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Statistial;
        private System.Windows.Forms.Panel panel_ShowChart;
        private System.Windows.Forms.DataGridView dataGridView_Turnover;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Statistial_Foods;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To_Foods;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From_Foods;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
    }
}