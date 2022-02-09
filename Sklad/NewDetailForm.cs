using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Sklad
{
    public partial class NewDetailForm : Form
    {
        public NewDetailForm()
        {
            InitializeComponent();
        }

        static int id;
        static int location_id;//ряд стеллажа
        static int number;//номер стеллажа
        static int shelf_id;
        static int cell_id;
        static int id_material;
        static int count;
        static string measurement;
        static string id_detail_ident;
        static int cell;




        private void button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox5.SelectedIndex != -1 && comboBox1.SelectedIndex!= -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && textBox2.Text != "")
            {
                if (radioButton1.Checked)
                    measurement = "шт";
                if (radioButton2.Checked)
                    measurement = "кг";


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

                //MessageBox.Show("id_material = " + Convert.ToString(id_material) + "number = " + comboBox4.Text + " measurement = " + measurement + "\n location_id = " + comboBox2.Text + " count = " + Convert.ToString(count) + "shelf_id" + Convert.ToString(shelf_id) + " \n cell_id=" + comboBox1.Text + " id_warehouse=" + Convert.ToString(id));



                //  MessageBox.Show("ok");
                SQLClass.Insert("INSERT INTO `detail`( `name`, `id_material`, `count`, `measurement`, `id_warehouse`, `id_shelf`, `id_cell`) VALUES (" +
                      "'" + textBox1.Text + "', '" + id_material + "', '" + count + "', '" + measurement + "', '" + id + "',  '" + shelf_id + "','" + comboBox1.Text + "')");
                MessageBox.Show("Деталь добавлена");

                string txt222 = "SELECT detail.id FROM `detail` WHERE detail.name LIKE " + "'%" + textBox1.Text + "%' " + "ORDER BY detail.id";
                List<string> d_details = SQLClass.Select(txt222);
                int d_detail = Convert.ToInt32(d_details[0].ToString());//id детали


                button3.Enabled = true;
                //идентификатор id детали в БД, номер ряда, номер стеллажа, номер ячейки
                location_id = Convert.ToInt32(comboBox2.Text); // ряд
                number = Convert.ToInt32(comboBox4.Text);
                cell = Convert.ToInt32(comboBox1.Text);
                id_detail_ident =  "0" + Convert.ToString(d_detail) +  Convert.ToString(location_id) + Convert.ToString(number) + Convert.ToString(cell); 
               //Close();
            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }

        private void NewDetailForm_Load_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            this.ActiveControl = textBox1;
            radioButton1.Checked = true;
            string txt = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt);
            comboBox3.Items.AddRange(warehouses.ToArray());
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox1.Enabled = false;

            string txtmat = "SELECT `material` FROM material ORDER BY material";
            List<string> materials = SQLClass.Select(txtmat);
            comboBox5.Items.AddRange(materials.ToArray());


        }

        //private void comboBox_
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear(); comboBox4.ResetText(); comboBox4.Enabled = false;
            comboBox1.ResetText(); comboBox1.Items.Clear(); comboBox1.Enabled = false; button3.Enabled = false;
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


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();    comboBox2.ResetText(); 
            comboBox4.Items.Clear();    comboBox4.ResetText(); comboBox4.Enabled = false;
            comboBox1.ResetText();      comboBox1.Items.Clear(); comboBox1.Enabled = false;
            comboBox2.Enabled = true; button3.Enabled = false;
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.ResetText(); comboBox1.Items.Clear();     comboBox1.Enabled = true; button3.Enabled = false;
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                comboBox1.Enabled = true;
                string txt11 = "SELECT `id`, `name`,`address`,`phone`,`size` FROM `warehouse` WHERE `name` = " + "'" + comboBox3.Text + "' " + "ORDER BY name";
                List<string> warehouses = SQLClass.Select(txt11);
                id = Convert.ToInt32(warehouses[0].ToString());


                string txt12 = "SELECT DISTINCT `location` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' " + "ORDER BY location";
                List<string> shelfs = SQLClass.Select(txt12);
                location_id = Convert.ToInt32(shelfs[0].ToString());

                string txt13 = "SELECT `id` FROM `shelf` WHERE `id_warehouse` = " + "'" + id + "' AND  `location` = " + "'" + comboBox2.Text + "' " + " AND  `number` = " + "'" + comboBox4.Text + "' " ;
                List<string> shelfs_id = SQLClass.Select(txt13);
                shelf_id = Convert.ToInt32(shelfs_id[0].ToString());

                string txt14 = "SELECT `id` FROM `cell` WHERE `id_shelf` = " + "'" + shelf_id + "' " + "ORDER BY id";
                List<string> cell_ids = SQLClass.Select(txt14);

                if (cell_ids.Count == 0)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Text = "Отсутствуют ячейки для стеллажа";
                    comboBox1.Enabled = false;
                }
                else
                {
                    comboBox1.Items.Clear();
                    cell_id = Convert.ToInt32(cell_ids[0].ToString());
                    comboBox1.Items.AddRange(cell_ids.ToArray());
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMaterialForm NewMF = new NewMaterialForm();
            NewMF.ShowDialog();

            string txtmat = "SELECT `material` FROM material ORDER BY material";
            List<string> materials = SQLClass.Select(txtmat); 
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(materials.ToArray());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            string txtid = "SELECT `id` FROM `material` WHERE `material` = " + "'" + comboBox5.Text + "' ";
            List<string> materialid = SQLClass.Select(txtid);
            id_material = Convert.ToInt32(materialid[0].ToString());
           // MessageBox.Show(Convert.ToString(id_material));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.Handled = true;
            count = Convert.ToInt32(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //идентификатор id детали в БД, номер ряда, номер стеллажа, номер ячейки

            GenbarcodeForm GenForm = new GenbarcodeForm();
            GenForm.id_detail = Convert.ToInt32(id_detail_ident);
            GenForm.name_detail = textBox1.Text;
            GenForm.ShowDialog();
            Close();
        }
    }
}
