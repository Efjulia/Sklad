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
            /*this.Hide();
            Autentification AUform = new Autentification();
            AUform.ShowDialog();
            this.Show();
            if (Autentification.user_role == 2)
            {
                UsersMenuItem.Visible = false;
                newwarehouseMenu.Visible = false;
                editwarehouseMenu.Visible = false;
            }
            else { UsersMenuItem.Visible = true;
                newwarehouseMenu.Visible = true;
                editwarehouseMenu.Visible = true;
                
            }*/
          //  MessageBox.Show(Convert.ToString(Autentification.user_role));
        }

        private void NewuserMenu_Click(object sender, EventArgs e)
        {
            Registration Regform = new Registration();
            Regform.ShowDialog();
        }

        private void NewDepartmentMenu_Click(object sender, EventArgs e)
        {
            NewDepartment NewDepform = new NewDepartment();
            NewDepform.ShowDialog();
        }

        private void adddetailMenu_Click(object sender, EventArgs e)
        {
            NewDetailForm NewDetail = new NewDetailForm();
            NewDetail.ShowDialog();
        }

        private void newshelfMenu_Click(object sender, EventArgs e)
        {
            NewShelf NSF = new NewShelf();
            //NewShelf.new_shelf = 0;
            NSF.Show();
        }

        private void Edituser_Click(object sender, EventArgs e)
        {
            EditUserForm EUForm = new EditUserForm();
            EUForm.ShowDialog();
        }

        private void GenShtrih_Click(object sender, EventArgs e)
        {
            genbarcode GBrC = new genbarcode();
            GBrC.ShowDialog();
        }

        private void NewMaterialMenu_Click(object sender, EventArgs e)
        {
            NewMaterialForm NewMF = new NewMaterialForm();
            NewMF.ShowDialog();
        }

        private void newcellmenu_Click(object sender, EventArgs e)
        {
            Newcell NewCellForm = new Newcell();
            NewCellForm.ShowDialog();
        }

        private void ShowdetailMenu_Click(object sender, EventArgs e)
        {
            ShowDetail SDForm = new ShowDetail();
            SDForm.ShowDialog();
        }

        private void selectUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentification AUform = new Autentification();
            AUform.ShowDialog();
            this.Show();
            if (Autentification.user_role == 2)
            {
                UsersMenuItem.Visible = false;
                newwarehouseMenu.Visible = false;
                editwarehouseMenu.Visible = false;
            }
            else
            {
                UsersMenuItem.Visible = true;
                newwarehouseMenu.Visible = true;
                editwarehouseMenu.Visible = true;
            }
            //  MessageBox.Show(Convert.ToString(Autentification.user_role));
        }


        private void exitMenu_Click(object sender, EventArgs e)
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
            else { Application.Exit(); }
        }

        private void reportwarehouseMenu_Click(object sender, EventArgs e)
        {
            ReportForm RepF = new ReportForm();
            RepF.ShowDialog();
        }

        private void showDepartmentMenu_Click(object sender, EventArgs e)
        {
            ShowDepartmentForm SDForm = new ShowDepartmentForm();
            SDForm.ShowDialog();
        }

        private void EditDepatmentMenu_Click(object sender, EventArgs e)
        {
            EditDepatmentForm EDForm = new EditDepatmentForm();
            EDForm.ShowDialog();

        }

        private void editshelfmenu_Click(object sender, EventArgs e)
        {
            EditShelfForm ESF = new EditShelfForm();
          //  NewShelf.new_shelf = 1;
            ESF.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          AboutForm AbForm = new AboutForm();
            AbForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch SDForm = new FormSearch();
            SDForm.ShowDialog();
        }

        private void PrintShtrih_Click(object sender, EventArgs e)
        {
            genbarcode GBrC = new genbarcode();
            GBrC.ShowDialog();
        }

        private void editdetailMenu_Click(object sender, EventArgs e)
        {
            EditDetailForm EDForm = new EditDetailForm();
            EDForm.ShowDialog();
        }
    }
}
