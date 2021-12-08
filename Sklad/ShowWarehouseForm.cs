using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class ShowWarehouseForm : Form
    {
        public ShowWarehouseForm()
        {
            InitializeComponent();

            /*Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "Server=localhost; Port=3306; Database=trains; User ID=root;  ";
            MySqlConnectionStringBuilder db;
            db = new MySqlConnectionStringBuilder();
            db.Server = "localhost"; // хостинг БД
            db.Database = "beavisabra"; // Имя БД
            db.UserID = "root"; // Имя пользователя БД
                                // db.Password = "ca8484adc89a"; // Пароль пользователя БД
            db.CharacterSet = "utf8"; // Кодировка Базы Данных

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            conn.Open();*/

            string Text = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse`";
            System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text);
            //int y = 10;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < warehouses.Count - 3; i += 4)
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = warehouses[i].ToString();
                data[data.Count - 1][1] = warehouses[i + 1].ToString();
                data[data.Count - 1][2] = warehouses[i + 2].ToString();
                data[data.Count - 1][3] = warehouses[i + 3].ToString();
                // data[data.Count - 1][2] = reader[2].ToString();
                //reader.Read();
              /* Label lbl1 = new Label();
                Label lbl2 = new Label();
                lbl1.Location = new Point(0, y);
                lbl2.Location = new Point(300, y);
                lbl1.Size = new Size(300, 30);
                lbl2.Size = new Size(300, 30);
                string warehouse = warehouses[i];
                string warehouse1 = warehouses[i + 1];
                lbl1.Text = warehouse;
                lbl2.Text = warehouse1;
                //MessageBox.Show(warehouse1);
                Controls.Add(lbl1);
                Controls.Add(lbl2);
                y += 50;*/

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }


    }
}
