using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewShelf : Form
    {
       // public static int new_shelf;
        public NewShelf()
        {
            InitializeComponent();
        }

        private void NewShelf_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBox1;
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox1.Items.AddRange(warehouses.ToArray());
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            /*if (new_shelf == 0)
            {
                button1.Text = "Создать стеллаж";

            }
            else
            {
                button1.Text = "Редактировать стеллаж";

            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt);
                int id = Convert.ToInt32(warehouses[0].ToString());

                int number = Convert.ToInt32(textBox7.Text);
                int location = Convert.ToInt32(textBox6.Text);
                int size = Convert.ToInt32(textBox8.Text);
                string registered = SQLClass.Select(
                "SELECT COUNT(*) FROM `shelf` WHERE `id_warehouse` = '" + id + "'AND `number`= '" + number + "'AND `location` = '" + location + "'")[0];

                if (registered != "0")
                {
                    MessageBox.Show("Такой стеллаж уже существует!");
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    return;
                }
                else
                {
                    SQLClass.Insert("INSERT INTO `shelf`(`id_warehouse`, `number`, `location`, `size`) VALUES ('" + id + "', '" + number + "', '" + location + "', '" + size + "')");
                    MessageBox.Show("Стеллаж создан");

                    Close();
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt);
                int id = Convert.ToInt32(warehouses[0].ToString());
             //   MessageBox.Show(Convert.ToString(id));
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
