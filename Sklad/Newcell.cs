using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Newcell : Form
    {
        public Newcell()
        {
            InitializeComponent();
        }

        private void Newcell_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBox1;
        }
    }
}
