
namespace Sklad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem warehouseMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showwarehouseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newwarehouseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editwarehouseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deletewarehouseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportwarehouseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShtrihMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenShtrih = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadShtrih = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintShtrih = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDepartmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepatmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adddetailMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editdetailMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedetailMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewuserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Edituser = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newshelfMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editshelfmenu = new System.Windows.Forms.ToolStripMenuItem();
            warehouseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // warehouseMenuItem
            // 
            warehouseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showwarehouseMenu,
            this.newwarehouseMenu,
            this.editwarehouseMenu,
            this.deletewarehouseMenu,
            this.reportwarehouseMenu,
            this.newshelfMenu,
            this.editshelfmenu});
            warehouseMenuItem.Name = "warehouseMenuItem";
            warehouseMenuItem.Size = new System.Drawing.Size(74, 24);
            warehouseMenuItem.Text = "&Склады";
            warehouseMenuItem.Click += new System.EventHandler(this.warehouseMenuItem_Click);
            // 
            // showwarehouseMenu
            // 
            this.showwarehouseMenu.Name = "showwarehouseMenu";
            this.showwarehouseMenu.Size = new System.Drawing.Size(254, 26);
            this.showwarehouseMenu.Text = "Обзор склада";
            this.showwarehouseMenu.Click += new System.EventHandler(this.showwarehouseMenu_Click);
            // 
            // newwarehouseMenu
            // 
            this.newwarehouseMenu.Name = "newwarehouseMenu";
            this.newwarehouseMenu.Size = new System.Drawing.Size(254, 26);
            this.newwarehouseMenu.Text = "Создать склад";
            this.newwarehouseMenu.Click += new System.EventHandler(this.newwarehouseMenu_Click);
            // 
            // editwarehouseMenu
            // 
            this.editwarehouseMenu.Name = "editwarehouseMenu";
            this.editwarehouseMenu.Size = new System.Drawing.Size(254, 26);
            this.editwarehouseMenu.Text = "Редактировать склад";
            this.editwarehouseMenu.Click += new System.EventHandler(this.editwarehouseMenu_Click);
            // 
            // deletewarehouseMenu
            // 
            this.deletewarehouseMenu.Name = "deletewarehouseMenu";
            this.deletewarehouseMenu.Size = new System.Drawing.Size(254, 26);
            this.deletewarehouseMenu.Text = "Удалить";
            // 
            // reportwarehouseMenu
            // 
            this.reportwarehouseMenu.Name = "reportwarehouseMenu";
            this.reportwarehouseMenu.Size = new System.Drawing.Size(254, 26);
            this.reportwarehouseMenu.Text = "Отчет";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterMenuItem,
            warehouseMenuItem,
            this.ShtrihMenuItem,
            this.helpMenuItem,
            this.departmentMenuItem,
            this.DetailMenuItem,
            this.UsersMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // enterMenuItem
            // 
            this.enterMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.enterMenuItem.Name = "enterMenuItem";
            this.enterMenuItem.Size = new System.Drawing.Size(170, 24);
            this.enterMenuItem.Text = "Администрирование";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(252, 26);
            this.toolStripMenuItem4.Text = "Вход";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(252, 26);
            this.toolStripMenuItem3.Text = "Сменить пользователя";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(252, 26);
            this.toolStripMenuItem2.Text = "Выход";
            // 
            // ShtrihMenuItem
            // 
            this.ShtrihMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenShtrih,
            this.ReadShtrih,
            this.PrintShtrih});
            this.ShtrihMenuItem.Name = "ShtrihMenuItem";
            this.ShtrihMenuItem.Size = new System.Drawing.Size(98, 24);
            this.ShtrihMenuItem.Text = "Штрих-код";
            // 
            // GenShtrih
            // 
            this.GenShtrih.Name = "GenShtrih";
            this.GenShtrih.Size = new System.Drawing.Size(190, 26);
            this.GenShtrih.Text = "Генерировать";
            // 
            // ReadShtrih
            // 
            this.ReadShtrih.Name = "ReadShtrih";
            this.ReadShtrih.Size = new System.Drawing.Size(190, 26);
            this.ReadShtrih.Text = "Считать";
            // 
            // PrintShtrih
            // 
            this.PrintShtrih.Name = "PrintShtrih";
            this.PrintShtrih.Size = new System.Drawing.Size(190, 26);
            this.PrintShtrih.Text = "Печать";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(83, 24);
            this.helpMenuItem.Text = "&Помощь";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.contentsToolStripMenuItem.Text = "&Помощь";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.indexToolStripMenuItem.Text = "&Настройки";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.searchToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.aboutToolStripMenuItem.Text = "&О программе...";
            // 
            // departmentMenuItem
            // 
            this.departmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDepartmentMenu,
            this.EditDepatmentMenu});
            this.departmentMenuItem.Name = "departmentMenuItem";
            this.departmentMenuItem.Size = new System.Drawing.Size(113, 24);
            this.departmentMenuItem.Text = "&Контрагенты";
            // 
            // NewDepartmentMenu
            // 
            this.NewDepartmentMenu.Name = "NewDepartmentMenu";
            this.NewDepartmentMenu.Size = new System.Drawing.Size(283, 26);
            this.NewDepartmentMenu.Text = "Создать контрагента";
            this.NewDepartmentMenu.Click += new System.EventHandler(this.NewDepartmentMenu_Click);
            // 
            // EditDepatmentMenu
            // 
            this.EditDepatmentMenu.Name = "EditDepatmentMenu";
            this.EditDepatmentMenu.Size = new System.Drawing.Size(283, 26);
            this.EditDepatmentMenu.Text = "Редактировать контрагента";
            // 
            // DetailMenuItem
            // 
            this.DetailMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adddetailMenu,
            this.editdetailMenu,
            this.deletedetailMenu});
            this.DetailMenuItem.Name = "DetailMenuItem";
            this.DetailMenuItem.Size = new System.Drawing.Size(71, 24);
            this.DetailMenuItem.Text = "Деталь";
            // 
            // adddetailMenu
            // 
            this.adddetailMenu.Name = "adddetailMenu";
            this.adddetailMenu.Size = new System.Drawing.Size(244, 26);
            this.adddetailMenu.Text = "Добавить деталь";
            this.adddetailMenu.Click += new System.EventHandler(this.adddetailMenu_Click);
            // 
            // editdetailMenu
            // 
            this.editdetailMenu.Name = "editdetailMenu";
            this.editdetailMenu.Size = new System.Drawing.Size(244, 26);
            this.editdetailMenu.Text = "Редактировать деталь";
            // 
            // deletedetailMenu
            // 
            this.deletedetailMenu.Name = "deletedetailMenu";
            this.deletedetailMenu.Size = new System.Drawing.Size(244, 26);
            this.deletedetailMenu.Text = "Удалить деталь";
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewuserMenu,
            this.Edituser});
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(105, 24);
            this.UsersMenuItem.Text = "Сотрудники";
            // 
            // NewuserMenu
            // 
            this.NewuserMenu.Name = "NewuserMenu";
            this.NewuserMenu.Size = new System.Drawing.Size(277, 26);
            this.NewuserMenu.Text = "Создать сотрудника";
            this.NewuserMenu.Click += new System.EventHandler(this.NewuserMenu_Click);
            // 
            // Edituser
            // 
            this.Edituser.Name = "Edituser";
            this.Edituser.Size = new System.Drawing.Size(277, 26);
            this.Edituser.Text = "Редактировать сотрудника";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // newshelfMenu
            // 
            this.newshelfMenu.Name = "newshelfMenu";
            this.newshelfMenu.Size = new System.Drawing.Size(254, 26);
            this.newshelfMenu.Text = "Создать стеллаж";
            this.newshelfMenu.Click += new System.EventHandler(this.newshelfMenu_Click);
            // 
            // editshelfmenu
            // 
            this.editshelfmenu.Name = "editshelfmenu";
            this.editshelfmenu.Size = new System.Drawing.Size(254, 26);
            this.editshelfmenu.Text = "Редактировать стеллаж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Склад 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDepartmentMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem newwarehouseMenu;
        private System.Windows.Forms.ToolStripMenuItem editwarehouseMenu;
        private System.Windows.Forms.ToolStripMenuItem deletewarehouseMenu;
        private System.Windows.Forms.ToolStripMenuItem reportwarehouseMenu;
        private System.Windows.Forms.ToolStripMenuItem departmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adddetailMenu;
        private System.Windows.Forms.ToolStripMenuItem editdetailMenu;
        private System.Windows.Forms.ToolStripMenuItem deletedetailMenu;
        private System.Windows.Forms.ToolStripMenuItem showwarehouseMenu;
        private System.Windows.Forms.ToolStripMenuItem UsersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewuserMenu;
        private System.Windows.Forms.ToolStripMenuItem Edituser;
        private System.Windows.Forms.ToolStripMenuItem ShtrihMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenShtrih;
        private System.Windows.Forms.ToolStripMenuItem ReadShtrih;
        private System.Windows.Forms.ToolStripMenuItem PrintShtrih;
        private System.Windows.Forms.ToolStripMenuItem EditDepatmentMenu;
        private System.Windows.Forms.ToolStripMenuItem newshelfMenu;
        private System.Windows.Forms.ToolStripMenuItem editshelfmenu;
    }
}

