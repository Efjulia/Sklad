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
                "SELECT COUNT(*) FROM `shelf` WHERE `number`= '" + number + "'AND `location` = '" + location + "'")[0];

                if (registered != "0")
                {
                    MessageBox.Show("Такой стеллаж уже существует!");
                    return;
                }
                else
                {
                    SQLClass.Insert("INSERT INTO `shelf`(`id_warehouse`, `number`, `location`, `size`) VALUES ('" + id + "', '" + number + "', '" + location + "', '" + size + "')");
                    MessageBox.Show("ok");

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
                MessageBox.Show(Convert.ToString(id));
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }


        }
    }
}
