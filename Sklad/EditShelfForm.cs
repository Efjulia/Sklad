using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad
{
    public partial class EditShelfForm : Form
    {
        static int id; //склад
        static int location_id;//ряд стеллажа
        static int number;//номер стеллажа
        static int shelf_id;//стеллаж

        public EditShelfForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && textBox8.Text != "")
            {
                    string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                    List<string> warehouses = SQLClass.Select(txt11);
                    id = Convert.ToInt32(warehouses[0].ToString());

                    string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                    List<string> shelfs = SQLClass.Select(txt12);
                    location_id = Convert.ToInt32(shelfs[0].ToString());

                    string txt13 = "SELECT `id` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + " AND  `number` = " + "'" + comboBox3.Text + "' ";
                    List<string> shelfs_id = SQLClass.Select(txt13);
                    shelf_id = Convert.ToInt32(shelfs_id[0].ToString());

                    string txt14 = "SELECT `size` FROM `shelf` WHERE `id` = " + "'" + shelf_id + "' ";
                   // int new_size_shelf = Convert.ToInt32(textBox8.Text);
                SQLClass.Insert("UPDATE `shelf`  SET" + " `size` = '" + textBox8.Text + "'" + " WHERE `id` = " + shelf_id);
                MessageBox.Show("Изменения сохранены");
                this.Close();

                }
            else { MessageBox.Show("Не все поля заполнены"); }
        }   

        private void EditShelfForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.ActiveControl = comboBox1;
            comboBox3.Enabled = false;
            comboBox2.Enabled = false;
            textBox8.Enabled = false;
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox1.Items.AddRange(warehouses.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); comboBox2.ResetText(); comboBox2.Enabled = true; button1.Enabled = false;
            comboBox3.Items.Clear(); comboBox3.ResetText(); comboBox3.Enabled = false; textBox8.Enabled = false;


            string txt = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
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
            comboBox3.Items.Clear(); comboBox3.ResetText(); comboBox3.Enabled = true; button1.Enabled = false; textBox8.Enabled = false;
            //comboBox1.ResetText(); comboBox1.Items.Clear(); comboBox1.Enabled = true;
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {

                comboBox3.Enabled = true;
                comboBox3.Items.Clear();
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
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
                    comboBox3.Items.Clear();
                    comboBox3.Text = "Отсутствуют стеллажи для склада";
                    comboBox3.Enabled = false;
                }
                else
                {
                    comboBox3.Items.Clear();
                    number = Convert.ToInt32(numbers[0].ToString());
                    comboBox3.Items.AddRange(numbers.ToArray());
                }
            }
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
               
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt11);
                id = Convert.ToInt32(warehouses[0].ToString());


                string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt12);
                location_id = Convert.ToInt32(shelfs[0].ToString());

                string txt13 = "SELECT `id` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + " AND  `number` = " + "'" + comboBox3.Text + "' ";
                List<string> shelfs_id = SQLClass.Select(txt13);
                shelf_id = Convert.ToInt32(shelfs_id[0].ToString());

                string txt14 = "SELECT `size` FROM `shelf` WHERE `id` = " + "'" + shelf_id + "' ";
                List<string> size_shelf = SQLClass.Select(txt14);
                

                if (size_shelf.Count == 0)
                {

                    textBox8.Text = "Отсутствует значение размера для стеллажа";
                    
                }
                else
                {
                    textBox8.Text = size_shelf[0].ToString();
                    button1.Enabled = true;
                    textBox8.Enabled = true;
                }
                
            }

        }
    }
}
