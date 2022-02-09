﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class ShowWarehouseForm : Form
    {
        public ShowWarehouseForm()
        {
            InitializeComponent();

          
            string Text = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse`";
            System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text);
            //int y = 10;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < warehouses.Count - 3; i += 4)
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = warehouses[i].ToString();
                data[data.Count - 1][1] = warehouses[i + 1].ToString();
                data[data.Count - 1][2] = warehouses[i + 2].ToString();
                data[data.Count - 1][3] = warehouses[i + 3].ToString();
               
            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();

                string Text1 = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse` WHERE `Name` LIKE " + "'%" + textBox1.Text + "%' " + "ORDER BY name"; 
                System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text1);
                //int y = 10;
                List<string[]> data = new List<string[]>();
                for (int i = 0; i < warehouses.Count - 3; i += 4) 
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = warehouses[i].ToString();
                    data[data.Count - 1][1] = warehouses[i + 1].ToString();
                    data[data.Count - 1][2] = warehouses[i + 2].ToString();
                    data[data.Count - 1][3] = warehouses[i + 3].ToString();
                    

                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
                    
            }
        }

        private void ShowWarehouseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Text3 = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse`";
            System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text3);
            //int y = 10;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < warehouses.Count - 3; i += 4)
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = warehouses[i].ToString();
                data[data.Count - 1][1] = warehouses[i + 1].ToString();
                data[data.Count - 1][2] = warehouses[i + 2].ToString();
                data[data.Count - 1][3] = warehouses[i + 3].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
