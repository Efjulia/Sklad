﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class EditWarehouseForm : Form
    {
        public EditWarehouseForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditWarehouseForm_Load(object sender, EventArgs e)
        {
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox1.Items.AddRange(warehouses.ToArray());

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад"); 
            else
            {
                 string txt = "SELECT `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                 List<string> warehouses = SQLClass.Select(txt);
                 //comboBox1.Items.AddRange(warehouses.ToArray());
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Text = warehouses[0].ToString();
                textBox2.Text = warehouses[1].ToString();
                textBox3.Text = warehouses[2].ToString();
                textBox4.Text = warehouses[3].ToString();

                //MessageBox.Show(Convert.ToString(comboBox1.Text));
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}