using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime maintenant = DateTime.Now;
            n_hours.Value = maintenant.Hour;
            n_minuts.Value = maintenant.Minute;
            n_seconde.Value = maintenant.Second;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            DateTime maintenant = DateTime.Now;
            if (button1.Text == "Start")
            {
                timer1.Start(); 
               // timer1.Enabled = true;
                button1.Text = "Arrét";
                return;
            }
           
           timer1.Enabled = false;
           button1.Text = "Start";
           return;
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          //  DateTime maintenant = DateTime.Now;
           // label1.Text = DateTime.Now.ToString(" HH:mm:ss tt ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maintenant = DateTime.Now;
            if (maintenant.Hour == n_hours.Value && maintenant.Minute == n_minuts.Value && maintenant.Second == n_seconde.Value)
            {
                timer1.Enabled = false;
                MessageBox.Show("alarm");
            }
            label1.Text = DateTime.Now.ToString(" HH:mm:ss tt ");
           // label1.Text = maintenant.Hour.ToString("d2") + ":" + maintenant.Minute.ToString("M2") + ":" + maintenant.Second.ToString("s2"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
