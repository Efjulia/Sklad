using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sklad
{

    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string today_date = Convert.ToString(DateTime.Now.ToLongDateString());
            string today_time = Convert.ToString(DateTime.Now.ToShortTimeString());
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "Перечень складов на " + today_date + ", " + today_time);
            _ClsPrint.PrintForm();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {

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


            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            MessageBox.Show("1111");
            /* Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
             dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
             e.Graphics.DrawImage(bmp, 0, 0);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();

                string Text1 = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse` WHERE `Name` LIKE " + "'%" + textBox1.Text + "%' " + "ORDER BY name";
                System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text1);
                //int y = 10;
                List<string[]> data = new List<string[]>();
                for (int i = 0; i < warehouses.Count - 3; i += 4)
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = warehouses[i].ToString();
                    data[data.Count - 1][1] = warehouses[i + 1].ToString();
                    data[data.Count - 1][2] = warehouses[i + 2].ToString();
                    data[data.Count - 1][3] = warehouses[i + 3].ToString();


                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Text3 = "SELECT `Name`, `address`, `phone`, `size`  FROM `warehouse`";
            System.Collections.Generic.List<string> warehouses = SQLClass.Select(Text3);
            //int y = 10;
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < warehouses.Count - 3; i += 4)
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = warehouses[i].ToString();
                data[data.Count - 1][1] = warehouses[i + 1].ToString();
                data[data.Count - 1][2] = warehouses[i + 2].ToString();
                data[data.Count - 1][3] = warehouses[i + 3].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }

}