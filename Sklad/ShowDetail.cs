using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class ShowDetail : Form
    {
        public ShowDetail()
        {
            InitializeComponent();
           
            string Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id";


            System.Collections.Generic.List<string> details = SQLClass.Select(Text);

            List<string[]> data = new List<string[]>();
            for (int i = 0; i < details.Count - 7; i += 8)
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = details[i].ToString();
                data[data.Count - 1][1] = details[i + 1].ToString();
                data[data.Count - 1][2] = details[i + 2].ToString();
                data[data.Count - 1][3] = details[i + 3].ToString();
                data[data.Count - 1][4] = details[i + 4].ToString();
                data[data.Count - 1][5] = details[i + 5].ToString();
                data[data.Count - 1][6] = details[i + 6].ToString();
                data[data.Count - 1][7] = details[i + 7].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "header doc text");
            _ClsPrint.PrintForm();
        }
    }
}
