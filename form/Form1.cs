﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void smenu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Form2();
            fm.Show();
        }
    }
}
