using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Autentification : Form
    {
        public static int user_role;
        public static string user_name;
        public Autentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        user_name = textBox1.Text;
         string user_password = textBox2.Text.Trim();

        string Text = "SELECT `login`,`password` FROM `users`";
        System.Collections.Generic.List<string> users = SQLClass.Select(Text);
        bool legal_user = false;
        List<string[]> data = new List<string[]>();
            for (int i = 0; i<users.Count - 1; i += 2)
            {
            string current_user = users[i].ToString();
        string current_user_password = users[i + 1].ToString();
            if (user_name == current_user && user_password==current_user_password)
                
            legal_user =true;
            }
            // MainForm.Show();
            if (legal_user)
            {
                string Text_0 = "SELECT  `role` FROM `users` WHERE `login` = " + "'" + textBox1.Text + "'"; 
                System.Collections.Generic.List<string> user_current = SQLClass.Select(Text_0);
                user_role = Convert.ToInt32(user_current[0].ToString());

                user_name = textBox1.Text;
                this.Close();}
                
            else
                MessageBox.Show("Неверный логин или пароль");

   }

        private void Autentification_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            this.ControlBox = false;
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
    }
}
