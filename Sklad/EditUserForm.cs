using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int role_user = 2;
            string new_user_name;
            string new_user_password;
            if ((checkBox1.Checked == true && textBox1.Text != "")
                || (checkBox2.Checked == true && textBox2.Text != "")
                || (checkBox3.Checked == true && comboBox1.SelectedIndex != -1) && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            {

                if (checkBox1.Checked == true && textBox1.Text != "")
                    new_user_name = textBox1.Text;


                if (comboBox2.SelectedIndex != -1)
                {
                   
                    button1.Enabled = true;
                    if (comboBox1.SelectedIndex == 0)
                    {
                        role_user = 1;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        role_user = 2;
                    }
                    if ((checkBox1.Checked == true && textBox1.Text != "") || (checkBox2.Checked == true && textBox2.Text != "") || (checkBox3.Checked == true && comboBox1.SelectedIndex != -1))
                    {
                        //string txt = "SELECT `login` FROM `users`  ORDER BY login";
                        string tx2t = "SELECT `id` FROM `users` WHERE `login` = " + "'" + comboBox2.Text + "'";
                        List<string> users_data = SQLClass.Select(tx2t);
                        string id = users_data[0].ToString();

                        if (checkBox1.Checked == true)
                        {
                            SQLClass.Insert("UPDATE `users`  SET" + " `login` = '" + textBox1.Text + "'" + " WHERE `id` = '" + id + "'");
                        }

                        if (checkBox2.Checked == true)
                        {
                            SQLClass.Insert("UPDATE `users`  SET" + " `password` = '" + textBox2.Text + "'" + " WHERE `id` = '" + id + "'");
                        }
                        if (checkBox3.Checked == true)
                        {
                            SQLClass.Insert("UPDATE `users`  SET" + " `role` = '" + role_user + "'" + " WHERE `id` = '" + id + "'");
                        }

                        MessageBox.Show("Изменения сохранены");

                        Close();
                    }
                }
            }
            else { MessageBox.Show("Не все поля заполнены"); }

        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            comboBox1.Visible = false; textBox1.Visible = false; textBox2.Visible = false;
            label2.Visible = false; //label3.Visible = false; label4.Visible = false;
            string txt = "SELECT `login` FROM `users`  ORDER BY login";
            List<string> users = SQLClass.Select(txt);
            string login;// = users[0].ToString();
            if (users.Count == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "Отсутствуют пользователи в системе";
                //comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Items.Clear();
                login = users[0].ToString();
                comboBox2.Items.AddRange(users.ToArray());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear(); comboBox1.ResetText(); //comboBox1.Enabled = false;
            if (comboBox2.SelectedIndex == -1 || comboBox2.Text=="")
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox1.Visible = true;

            else
                textBox1.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox2.Visible = true;

            else
                textBox2.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                comboBox1.Visible = true;

            else
                comboBox1.Visible = false;
        }
    }
}
