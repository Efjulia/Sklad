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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("ldsjghk");

        }

        private void warehouseMenuItem_Click(object sender, EventArgs e)
        {
            //Меню склад
        }

        private void newwarehouseMenu_Click(object sender, EventArgs e)
        {
            //Создание нового склада
            NewWarehouseForm WF = new NewWarehouseForm();
            WF.ShowDialog();

        }


        private void editwarehouseMenu_Click(object sender, EventArgs e)
        {
            //Редактирование склада
            EditWarehouseForm EW = new EditWarehouseForm();
            EW.ShowDialog();

        }

        private void showwarehouseMenu_Click(object sender, EventArgs e)
        {
            //Обзор склада
            ShowWarehouseForm SW = new ShowWarehouseForm();
            SW.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          const string message = "Закрыть программу?";
            const string caption = "Закрытие программы";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                ;
                // cancel the closure of the form.
               // e.Cancel = true;
            }
            else {Application.Exit();  }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
           // Autentification AUform = new Autentification();
           // AUform.ShowDialog();
           // this.Show();
        }

        private void NewuserMenu_Click(object sender, EventArgs e)
        {
            Registration Regform = new Registration();
            Regform.ShowDialog();
        }
    }
}
