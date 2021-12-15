using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewDepartment : Form
    {
        public NewDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type_department = 1; //внутренний

            if (comboBox1.SelectedIndex == 0)
            {
                type_department = 1;
               // MessageBox.Show("Внутренний!");

            }
            if (comboBox1.SelectedIndex == 1)
            {
                type_department = 2;
            }
                          
                string registered = SQLClass.Select(
                    "SELECT COUNT(*) FROM `department` WHERE `name` = '" + textBox1.Text + "'")[0];

                if (registered != "0")
                {
                    MessageBox.Show("Такой контрагент уже существует!");
                    return;
                }

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                if (comboBox1.SelectedIndex == 0)
             {
                    type_department = 1;
                }
             if (comboBox1.SelectedIndex == 1)
                {
                    type_department = 2;
                }

                SQLClass.Insert("INSERT INTO `department`( `name`,`type`, `address`,  `phone`, `fio`) VALUES(" +
                      "'" + textBox1.Text + "', '" + type_department + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')");
                MessageBox.Show("ok");

                Close();
            } 
        }

        private void NewDepartment_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }
    }
}
