
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Введите название склада";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название склада";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Показать все склады";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Показать все склады";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowWarehouseForm";
            this.Text = "Обзор склада";
            this.Load += new System.EventHandler(this.ShowWarehouseForm_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}