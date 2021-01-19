using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int l = 5;    
        public Form1()
        {
            InitializeComponent();
            label2.Text = l.ToString();
            label2.BackColor = Color.FromArgb(255, 25, 25, 25);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l--;
            label2.Text = l.ToString();
            if (l<1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                label2.Visible = false;
                timer1.Stop();
            }
        }
    }
}
