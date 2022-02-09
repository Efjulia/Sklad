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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Программа Склад 1.0 \nнаписана студентом гр. ЗПИу-1-18 \nАхметзяновым М.М. в качестве ВКР";
        }
    }
}
