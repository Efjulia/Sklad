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
    public partial class EditDepatmentForm : Form
    {
        public EditDepatmentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                    MessageBox.Show("Выберите контрагента");
                else
                {

                    string txt = "SELECT `id`,`type`,`fio`,`phone`,`address` FROM `department` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                    List<string> depatments = SQLClass.Select(txt);
                    int id = Convert.ToInt32(depatments[0].ToString());

                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox4.Text = depatments[2].ToString();
                    textBox3.Text = depatments[3].ToString();
                    textBox2.Text = depatments[4].ToString();
                }
            }
            catch
            { MessageBox.Show("Что-то пошло не так"); }
        }

        private void EditDepatmentForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBox1;
            string txt1 = "SELECT `name` FROM department ORDER BY name";
            List<string> departmentss = SQLClass.Select(txt1);
            comboBox1.Items.AddRange(departmentss.ToArray());

            //textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int tyre_dep = 0;
                if (comboBox2.SelectedIndex == -1)
                    MessageBox.Show("Выберите тип контрагента");
                else
                {
                    if (comboBox1.SelectedIndex == -1)
                        MessageBox.Show("Выберите контрагента");
                    else
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            tyre_dep = 1; //MessageBox.Show("1");
                        }
                        if (comboBox2.SelectedIndex == 1)
                        {
                            tyre_dep = 2;
                            // MessageBox.Show("2");
                        }
                        string txt = "SELECT `id`,`type`,`fio`,`phone`,`address` FROM `department` WHERE `name` = " + "'" + comboBox1.Text + "' " + "ORDER BY name";
                        List<string> depatments = SQLClass.Select(txt);
                        int id = Convert.ToInt32(depatments[0].ToString());
                        // MessageBox.Show(Convert.ToString(id));

                        SQLClass.Insert("UPDATE `department`  SET" + " `name` = '" + comboBox1.Text + "'," + " `type` = '" + tyre_dep + "'," +
                                    " `address` = '" + textBox4.Text + "'," + " `phone` = '" + textBox3.Text + "'," +
                                    " `fio` = '" + textBox2.Text + "'" + " WHERE `id` = " + id);

                        this.Close();
                    }
                }
            }
            catch
            { MessageBox.Show("Что-то пошло не так"); }
        }
    }
}
