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

        int id;
        int location_id;

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
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox1.Enabled = false;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                comboBox4.Enabled = true;
                /*
                comboBox2.Enabled = true;
                string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt);
                id = Convert.ToInt32(warehouses[0].ToString());


                string txt2 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt2);
                if (shelfs.Count == 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Задайте ряды для склада ");
                }
                else
                {
                    comboBox4.Items.Clear();
                    location_id = Convert.ToInt32(shelfs[0].ToString());
                    comboBox4.Items.AddRange(shelfs.ToArray());
                }*/
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            id = Convert.ToInt32(warehouses[0].ToString());

            
            string txt2 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
            List<string> shelfs = SQLClass.Select(txt2);
            if (shelfs.Count == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Задайте ряды для склада ");
            }
            else
            {
                comboBox2.Items.Clear();
                location_id = Convert.ToInt32(shelfs[0].ToString());
                comboBox2.Items.AddRange(shelfs.ToArray());
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
