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
    public partial class genbarcode : Form
    {
        public genbarcode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button1.Enabled = false;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ошибка ввода текста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            else{button1.Enabled = true;
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color BackColor = Color.Transparent;
                Image img = barcode.Encode(TYPE.CODE128, textBox1.Text.Trim(), foreColor, BackColor, (int)(pictureBox1.Width * 0.8), (int)(pictureBox1.Height * 0.8));
                pictureBox1.Image = img;
                
              //  Graphics.FromImage(bmp).Clear(Color.Black);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        
        

        private void genbarcode_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = Convert.ToInt32(comboBox1.Text);
            pictureBox1.Height = Convert.ToInt32(comboBox2.Text);

            textBox1.Focus();
            this.ActiveControl = textBox1;
            textBox1.MaxLength = 40;//Максимальная длина шифруемого в штрих-код текста
            button1.Enabled = false;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Название детали", new Font("Times New Roman", 14), Brushes.Black, 10, 10);
            e.Graphics.DrawImage(pictureBox1.Image, 10, 30);
           /* using (Graphics dg = e.Graphics)
            { 
            
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = Convert.ToInt32(comboBox1.Text);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = Convert.ToInt32(comboBox2.Text);
        }
    }
}
