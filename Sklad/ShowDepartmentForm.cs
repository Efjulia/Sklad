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
    public partial class ShowDepartmentForm : Form
    {
        public ShowDepartmentForm()
        {
            InitializeComponent();
        }

        int type_department;

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.Rows.Clear();

                type_department = 1;
                //MessageBox.Show("Внутренний");
                string Text = "SELECT `name`,`fio`,`phone`,`address` FROM `department` WHERE `type` = 1";
                System.Collections.Generic.List<string> departments = SQLClass.Select(Text);
                //int y = 10;
                List<string[]> data = new List<string[]>();
                for (int i = 0; i < departments.Count - 3; i += 4)
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = departments[i].ToString();
                    data[data.Count - 1][1] = departments[i + 1].ToString();
                    data[data.Count - 1][2] = departments[i + 2].ToString();
                    data[data.Count - 1][3] = departments[i + 3].ToString();
               
                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);


            
            
            }
                            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dataGridView1.Rows.Clear();

                type_department = 2;
               
                string Text = "SELECT `name`,`fio`,`phone`,`address` FROM `department` WHERE `type` = 2";
                System.Collections.Generic.List<string> departments = SQLClass.Select(Text);
                //int y = 10;
                List<string[]> data = new List<string[]>();
                for (int i = 0; i < departments.Count - 3; i += 4)
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = departments[i].ToString();
                    data[data.Count - 1][1] = departments[i + 1].ToString();
                    data[data.Count - 1][2] = departments[i + 2].ToString();
                    data[data.Count - 1][3] = departments[i + 3].ToString();

                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);


            }

        }
    }
}
