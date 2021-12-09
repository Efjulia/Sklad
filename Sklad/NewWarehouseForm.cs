using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewWarehouseForm : Form
    {
        public NewWarehouseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //INSERT INTO `warehouse`(`id`, `name`, `address`, `phone`, `size`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5])
             string registered = SQLClass.Select(
                 "SELECT COUNT(*) FROM `warehouse` WHERE `name` = '" + textBox1.Text + "'")[0];

             if (registered != "0")
             {
                 MessageBox.Show("Такой склад уже существует!");
                 return;
             }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SQLClass.Insert("INSERT INTO `warehouse`( `name`, `address`, `phone`, `size`) VALUES(" +
                      "'" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + Convert.ToInt32(textBox4.Text) + "')");
                MessageBox.Show("ok");

                Close();
            }
            else { MessageBox.Show("Не все поля заполнены"); }
        }
    }
}
