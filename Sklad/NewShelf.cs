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
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox1.Items.AddRange(warehouses.ToArray());
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

            }


        }
    }
}
