using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int role_user = 2;
                string registered = SQLClass.Select(
                    "SELECT COUNT(*) FROM `users` WHERE `login` = '" + textBox1.Text + "'")[0];

                if (registered != "0")
                {
                    MessageBox.Show("Вы уже зарегистрированы!");
                    return;
                }

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else
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

                SQLClass.Insert("INSERT INTO `users`(`login`, `password`, `role`) VALUES(" +
                      "'" + textBox1.Text + "', '" + textBox2.Text + "', '" + role_user + "')");
                MessageBox.Show("Теперь можно входить в систему");

                Close();
            } 
        }


        private void Registration_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }
    }
}
