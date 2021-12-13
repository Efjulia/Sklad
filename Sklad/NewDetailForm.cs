using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewDetailForm : Form
    {
        public NewDetailForm()
        {
            InitializeComponent();
        }

        private void NewDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                //SQLClass.Insert("INSERT INTO `warehouse`( `name`, `address`, `phone`, `size`) VALUES(" +
                //      "'" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + Convert.ToInt32(textBox1.Text) + "')");
                MessageBox.Show("ok");

                Close();
            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }

        private void NewDetailForm_Load_1(object sender, EventArgs e)
        {
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox3.Items.AddRange(warehouses.ToArray());
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt);
                int id = Convert.ToInt32(warehouses[0].ToString());
               
            }
        }
    }
}
