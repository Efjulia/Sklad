using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class NewMaterialForm : Form
    {
        public NewMaterialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ошибка ввода текста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            //SELECT `material` FROM `material`
            {


                string material = textBox1.Text;
                string compound = textBox2.Text;
                string registered = SQLClass.Select("SELECT COUNT(*) FROM `material` WHERE `material` = " + "'" + textBox1.Text + "' ")[0];

                if (registered != "0")
                {
                    MessageBox.Show("Такой материал уже существует!");
                    return;
                }
                else
                {
                    SQLClass.Insert("INSERT INTO `material`(`material`, `compound`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')");
                    MessageBox.Show("Материал создан");

                    Close();
                }
            }
        }
    }
}
