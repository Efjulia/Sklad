
namespace Sklad
{
    partial class ShowDetail
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridView1.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowDetail";
            this.Text = "Обзор деталей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
    }
}