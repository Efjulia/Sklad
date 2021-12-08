
namespace Sklad
{
    partial class ShowWarehouseForm
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
            this.sizewarehouse});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // WarehouseName
            // 
            this.WarehouseName.HeaderText = "Склад";
            this.WarehouseName.MinimumWidth = 20;
            this.WarehouseName.Name = "WarehouseName";
            this.WarehouseName.Width = 300;
            // 
            // WarehouseAddress
            // 
            this.WarehouseAddress.HeaderText = "Адрес склада";
            this.WarehouseAddress.MinimumWidth = 20;
            this.WarehouseAddress.Name = "WarehouseAddress";
            this.WarehouseAddress.Width = 300;
            // 
            // Phonewarehouse
            // 
            this.Phonewarehouse.HeaderText = "Телефон";
            this.Phonewarehouse.MinimumWidth = 6;
            this.Phonewarehouse.Name = "Phonewarehouse";
            this.Phonewarehouse.Width = 200;
            // 
            // sizewarehouse
            // 
            this.sizewarehouse.HeaderText = "Размер";
            this.sizewarehouse.MinimumWidth = 6;
            this.sizewarehouse.Name = "sizewarehouse";
            this.sizewarehouse.Width = 200;
            // 
            // ShowWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowWarehouseForm";
            this.Text = "Обзор склада";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonewarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizewarehouse;
    }
}