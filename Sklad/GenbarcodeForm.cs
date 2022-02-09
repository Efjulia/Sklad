using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class GenbarcodeForm : Form
    {
        public int id_detail = 0;
        public string name_detail = "";
        public GenbarcodeForm()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;


        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.Handled = true;

        }

        private void GenbarcodeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(id_detail);
            pictureBox1.Width = Convert.ToInt32(comboBox1.Text);
            pictureBox1.Height = Convert.ToInt32(comboBox2.Text);

            button1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(id_detail);

            //button1.Enabled = false;
            if (textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Ошибка получения номера детали", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
               // MessageBox.Show("Э");
                button1.Enabled = true;
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color BackColor = Color.Transparent;
                Image img = barcode.Encode(TYPE.CODE128, textBox1.Text.Trim(), foreColor, BackColor, (int)(pictureBox1.Width * 0.8), (int)(pictureBox1.Height * 0.8));
                pictureBox1.Image = img;

                //  Graphics.FromImage(bmp).Clear(Color.Black);

            }

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(name_detail, new Font("Times New Roman", 14), Brushes.Black, 10, 10);
            e.Graphics.DrawImage(pictureBox1.Image, 10, 30);
            /* using (Graphics dg = e.Graphics)
             { 

             }*/
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Width = Convert.ToInt32(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Height = Convert.ToInt32(comboBox2.Text);
        }
    }
}
