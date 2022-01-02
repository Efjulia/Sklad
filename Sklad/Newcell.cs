using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Newcell : Form
    {
        public Newcell()
        {
            InitializeComponent();
        }
        static int id;
        static int location_id;
        static int number;
        static int shelf_id;
        static int cell_id;
        static int size;


        private void Newcell_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBox3;
            
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox3.Items.AddRange(warehouses.ToArray());
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); comboBox2.ResetText();
            comboBox4.Items.Clear(); comboBox4.ResetText(); comboBox4.Enabled = false;
           
            comboBox2.Enabled = true;
            string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            id = Convert.ToInt32(warehouses[0].ToString());


            string txt2 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
            List<string> shelfs = SQLClass.Select(txt2);
            if (shelfs.Count == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "Отсутствуют ряды для склада";
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Items.Clear();
                location_id = Convert.ToInt32(shelfs[0].ToString());
                comboBox2.Items.AddRange(shelfs.ToArray());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear(); comboBox4.ResetText(); comboBox4.Enabled = false;
            
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {

                comboBox4.Enabled = true;
                comboBox4.Items.Clear();
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt11);
                id = Convert.ToInt32(warehouses[0].ToString());


                string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt12);
                location_id = Convert.ToInt32(shelfs[0].ToString());

                string txt2 = "SELECT DISTINCT `number` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + "ORDER BY number";
                List<string> numbers = SQLClass.Select(txt2);
                //number = Convert.ToInt32(numbers[0].ToString());
                if (numbers.Count == 0)
                {
                    comboBox4.Items.Clear();
                    comboBox4.Text = "Отсутствуют стеллажи для склада";
                    comboBox4.Enabled = false;
                }
                else
                {
                    comboBox4.Items.Clear();
                    number = Convert.ToInt32(numbers[0].ToString());
                    comboBox4.Items.AddRange(numbers.ToArray());
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt11);
                id = Convert.ToInt32(warehouses[0].ToString());


                string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt12);
                location_id = Convert.ToInt32(shelfs[0].ToString());

                string txt13 = "SELECT `id` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + " AND  `number` = " + "'" + comboBox4.Text + "' ";
                List<string> shelfs_id = SQLClass.Select(txt13);
                shelf_id = Convert.ToInt32(shelfs_id[0].ToString());

                string txt14 = "SELECT `id` FROM `cell` WHERE `id_shelf` = " + "'" + shelf_id + "' " + "ORDER BY id";
                List<string> cell_ids = SQLClass.Select(txt14);

                if (cell_ids.Count != 0)
                {
                    cell_id = Convert.ToInt32(cell_ids[0].ToString());
                }
                else
                {
                     
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 )
            {
                
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt11);
                id = Convert.ToInt32(warehouses[0].ToString()); //id скалада


                string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt12);
                location_id = Convert.ToInt32(shelfs[0].ToString()); //ряд стеллажа

                string txt2 = "SELECT DISTINCT `number` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + "ORDER BY number";
                List<string> numbers = SQLClass.Select(txt2);
                number = Convert.ToInt32(numbers[0].ToString());//номер стеллажа

                string txt22 = "SELECT DISTINCT `id` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' AND  `number` = " + "'" + comboBox4.Text + "' " + "ORDER BY number";
                List<string> ids = SQLClass.Select(txt22);
                shelf_id = Convert.ToInt32(ids[0].ToString()); //id стеллажа


                size = Convert.ToInt32(textBox1.Text);
                SQLClass.Insert("INSERT INTO `cell` (`id_shelf`, `size`) VALUES ('" + shelf_id + "',  '" + size + "')");
                MessageBox.Show("Ячейка создана");

                Close();
            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }
    

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.Handled = true;
            size = Convert.ToInt32(textBox1.Text);
        }
    }
}