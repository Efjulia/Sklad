
namespace Sklad
{
    partial class FormSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonewarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizewarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseName,
            this.WarehouseAddress,
            this.Phonewarehouse,
            this.sizewarehouse,
            this.warehouse,
            this.location,
            this.number,
            this.Cell});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 425);
            this.dataGridView1.TabIndex = 4;
            // 
            // WarehouseName
            // 
            this.WarehouseName.HeaderText = "Деталь";
            this.WarehouseName.MinimumWidth = 20;
            this.WarehouseName.Name = "WarehouseName";
            this.WarehouseName.Width = 300;
            // 
            // WarehouseAddress
            // 
            this.WarehouseAddress.HeaderText = "Материал";
            this.WarehouseAddress.MinimumWidth = 20;
            this.WarehouseAddress.Name = "WarehouseAddress";
            this.WarehouseAddress.Width = 200;
            // 
            // Phonewarehouse
            // 
            this.Phonewarehouse.HeaderText = "Количество";
            this.Phonewarehouse.MinimumWidth = 6;
            this.Phonewarehouse.Name = "Phonewarehouse";
            this.Phonewarehouse.Width = 125;
            // 
            // sizewarehouse
            // 
            this.sizewarehouse.HeaderText = "Ед. измерения";
            this.sizewarehouse.MinimumWidth = 6;
            this.sizewarehouse.Name = "sizewarehouse";
            this.sizewarehouse.Width = 125;
            // 
            // warehouse
            // 
            this.warehouse.HeaderText = "Склад";
            this.warehouse.MinimumWidth = 6;
            this.warehouse.Name = "warehouse";
            this.warehouse.Width = 125;
            // 
            // location
            // 
            this.location.HeaderText = "Ряд";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.Width = 125;
            // 
            // number
            // 
            this.number.HeaderText = "Стеллаж";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // Cell
            // 
            this.Cell.HeaderText = "Ячейка";
            this.Cell.MinimumWidth = 6;
            this.Cell.Name = "Cell";
            this.Cell.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(829, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название детали";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Введите название детали";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Показать все детали";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormSearch";
            this.Text = "Поиск деталей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonewarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizewarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}