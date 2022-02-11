using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Sklad
{
    public partial class EditDetailForm : Form
    {
        public EditDetailForm()
        {
            InitializeComponent();
        }
        //static int rasp = 0;
        //static int 
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
            string txt = "SELECT `id`, `name`, `id_material`, `count`, `measurement`, `id_warehouse`, `id_shelf`, `id_cell` FROM `detail` WHERE `name` = " + "'" + comboBox11.Text + "' " + "ORDER BY name";
            List<string> depatments = SQLClass.Select(txt);
            int id = Convert.ToInt32(depatments[0].ToString());
        }

        private void EditDetailForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            groupBox2.Enabled = false;
            button4.Enabled = false;
            this.ActiveControl = comboBox11;
            string txt = "SELECT `name` FROM detail ORDER BY name";
            List<string> details = SQLClass.Select(txt);
            comboBox11.Items.AddRange(details.ToArray());
            button3.Enabled = false;

            string txt_sklad = "SELECT `name` FROM warehouse ORDER BY name";
            List<string> warehouses = SQLClass.Select(txt_sklad);
            comboBox3.Items.AddRange(warehouses.ToArray());

            radioButton1.Checked = true;
           
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            button2.Enabled = false;
            string txtmat = "SELECT `material` FROM material ORDER BY material";
            List<string> materials = SQLClass.Select(txtmat);
            comboBox5.Items.AddRange(materials.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button6.Enabled = true;
            
            button4.Enabled = true;
            dataGridView1.Rows.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            string Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id " +
                "WHERE detail.name = " + "'" + comboBox11.Text + "' " + "ORDER BY detail.name";

            System.Collections.Generic.List<string> details = SQLClass.Select(Text);

            List<string[]> data = new List<string[]>();
            for (int i = 0; i < details.Count - 7; i += 8)
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = details[i].ToString();
                data[data.Count - 1][1] = details[i + 1].ToString();
                data[data.Count - 1][2] = details[i + 2].ToString();
                data[data.Count - 1][3] = details[i + 3].ToString();
                data[data.Count - 1][4] = details[i + 4].ToString();
                data[data.Count - 1][5] = details[i + 5].ToString();
                data[data.Count - 1][6] = details[i + 6].ToString();
                data[data.Count - 1][7] = details[i + 7].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox2.Enabled == true && textBox2.Text != "" && groupBox1.Enabled == true)
            {
                //если включено все все
                if (comboBox6.SelectedIndex != -1 && textBox2.Text != "" && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && textBox2.Text != "")
                    {
                        count = Convert.ToInt32(textBox2.Text);
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
                        string txt222 = "SELECT detail.id FROM `detail` WHERE detail.name LIKE " + "'%" + comboBox11.Text + "%' " + "ORDER BY detail.id";
                        List<string> d_details = SQLClass.Select(txt222);
                        int d_detail = Convert.ToInt32(d_details[0].ToString());//id детали

                        SQLClass.Insert("UPDATE `detail` SET `name`= " + "'" + comboBox11.Text + "', " + "`id_material`='" + id_material + "', " + "`count`=" +
                        "'" + count + "', " + "`measurement`=" + "'" + measurement + "'," + "`id_warehouse`= " + "'" + id + "', " + "`id_shelf`=" +
                         "'" + shelf_id + "', " + "`id_cell`=" + "'" + comboBox6.Text + "' WHERE `id`=" + "'" + d_detail + "'");
                         MessageBox.Show("Деталь сохранена");
                        button3.Enabled = true;
                        //идентификатор id детали в БД, номер ряда, номер стеллажа, номер ячейки
                        location_id = Convert.ToInt32(comboBox2.Text); // ряд
                        number = Convert.ToInt32(comboBox4.Text);
                        cell = Convert.ToInt32(comboBox6.Text);
                        //запоминаем идентификационный номер детали для открытия окна генерации
                        id_detail_ident = "0" + Convert.ToString(d_detail) + "00" + Convert.ToString(location_id) + "00" + Convert.ToString(number) + "00" + Convert.ToString(cell);
                        //Close();
                    }
                    else
                    { 
                        MessageBox.Show("Не все поля заполнены"); 
                    }
            }
                else
                {
                    //если отключен первый групбокс
                    if (groupBox2.Enabled == true && textBox2.Text != "" && groupBox1.Enabled == false)
                    {
                           if (textBox2.Text != "" && comboBox5.SelectedIndex != -1)
                            {
                                count = Convert.ToInt32(textBox2.Text);
                                if (radioButton1.Checked)
                                    measurement = "шт";
                                if (radioButton2.Checked)
                                    measurement = "кг";
                                string txt222 = "SELECT detail.id FROM `detail` WHERE detail.name LIKE " + "'%" + comboBox11.Text + "%' " + "ORDER BY detail.id";
                                List<string> d_details = SQLClass.Select(txt222);
                                int d_detail = Convert.ToInt32(d_details[0].ToString());//id детали

                                SQLClass.Insert("UPDATE `detail` SET `name`= " + "'" + comboBox11.Text + "', " + "`id_material`='" + id_material + "', " + "`count`=" +
                                "'" + count + "' WHERE `id`=" + "'" + d_detail + "'");
                                MessageBox.Show("Деталь сохранена");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Не все поля заполнены");
                            }

                        }
                        else
                        {
                            //если отключен первый групбокс
                            if (groupBox1.Enabled == true && groupBox2.Enabled == false)
                            {

                                if (comboBox6.SelectedIndex != -1 && comboBox6.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
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
                                    string txt222 = "SELECT detail.id FROM `detail` WHERE detail.name LIKE " + "'%" + comboBox11.Text + "%' " + "ORDER BY detail.id";
                                    List<string> d_details = SQLClass.Select(txt222);
                                    int d_detail = Convert.ToInt32(d_details[0].ToString());//id детали

                                    SQLClass.Insert("UPDATE `detail` SET `name`= " + "'" + comboBox11.Text + "', " +
                                     "`measurement`=" + "'" + measurement + "'," + "`id_warehouse`= " + "'" + id + "', " + "`id_shelf`=" +
                                     "'" + shelf_id + "', " + "`id_cell`=" + "'" + comboBox6.Text + "' WHERE `id`=" + "'" + d_detail + "'");
                                    MessageBox.Show("Деталь сохранена");
                                    button3.Enabled = true;
                                    //идентификатор id детали в БД, номер ряда, номер стеллажа, номер ячейки
                                    location_id = Convert.ToInt32(comboBox2.Text); // ряд
                                    number = Convert.ToInt32(comboBox4.Text);
                                    cell = Convert.ToInt32(comboBox6.Text);
                                    //запоминаем идентификационный номер детали для открытия окна генерации
                                    id_detail_ident = "0" + Convert.ToString(d_detail) + "00" + Convert.ToString(location_id) + "00" + Convert.ToString(number) + "00" + Convert.ToString(cell);
                                    //Close();
                                }
                                
                            }
                        }
                    
                    }
                

            }

        

        
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear(); comboBox4.ResetText(); comboBox4.Enabled = false;
            comboBox6.ResetText(); comboBox6.Items.Clear(); comboBox6.Enabled = false; button3.Enabled = false;
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
            comboBox2.Items.Clear(); comboBox2.ResetText();
            comboBox4.Items.Clear(); comboBox4.ResetText(); comboBox4.Enabled = false;
            comboBox6.ResetText(); comboBox6.Items.Clear(); comboBox6.Enabled = false;
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
            comboBox6.ResetText(); comboBox6.Items.Clear(); comboBox6.Enabled = true; button3.Enabled = false;
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Выберите склад");
            else
            {
                comboBox6.Enabled = true;
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

                if (cell_ids.Count == 0)
                {
                    comboBox6.Items.Clear();
                    comboBox6.Text = "Отсутствуют ячейки для стеллажа";
                    comboBox6.Enabled = false;
                }
                else
                {
                    comboBox6.Items.Clear();
                    cell_id = Convert.ToInt32(cell_ids[0].ToString());
                    comboBox6.Items.AddRange(cell_ids.ToArray());
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenbarcodeForm GenForm = new GenbarcodeForm();
            GenForm.id_detail = Convert.ToInt64(id_detail_ident);
            GenForm.name_detail = comboBox11.Text;
            GenForm.ShowDialog();
            Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                            return;
                        e.Handled = true;
                        count = Convert.ToInt32(textBox2.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
