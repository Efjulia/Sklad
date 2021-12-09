using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewDepartment : Form
    {
        public NewDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type_department = 1;
            /*
             *              
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
                    type_department = 1;
                }
             if (comboBox1.SelectedIndex == 1)
                {
                    type_department = 2;
                }

                SQLClass.Insert("INSERT INTO `users`(`login`, `password`, `role`) VALUES(" +
                      "'" + textBox1.Text + "', '" + textBox2.Text + "', '" + role_user + "')");
                MessageBox.Show("Теперь можно входить в систему");

                Close();
            } 
            INSERT INTO `department`( `name`, `type`, `fio`, `phone`, `address`) VALUES([value - 1],[value-2],[value-3],[value-4],[value-5],[value-6]);*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
