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
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ошибка ввода текста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            {
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color BackColor = Color.Transparent;
                Image img = barcode.Encode(TYPE.CODE128, textBox1.Text.Trim(), foreColor, BackColor, (int)(pictureBox1.Width * 0.8), (int)(pictureBox1.Height * 0.8));
                pictureBox1.Image = img;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        
        

        private void genbarcode_Load(object sender, EventArgs e)
        {textBox1.Focus();
            this.ActiveControl = textBox1;
            textBox1.MaxLength = 40;//Максимальная длина шифруемого в штрих-код текста
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
           /* using (Graphics dg = e.Graphics)
            { 
            
            }*/
        }
    }
}
