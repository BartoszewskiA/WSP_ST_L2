using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraKolory
{
    public partial class Form1 : Form
    {
        int czas = 300;
        int punkty=0;
        int zielone = 0;
        int czerwone = 0;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            label1.Text = czas.ToString();
            label3.Text = punkty.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            timer3.Stop();

            int x;
            do
            {
                x = random.Next(1, 5);
            } while (x == zielone || x==czerwone);
            czerwone = x;
            do
            {
                x = random.Next(1, 5);
            } while (x == zielone || x==czerwone);
            zielone = x;
    
            switch(zielone)
            {
                case 1: panel2.BackColor = Color.Green; break;
                case 2: panel3.BackColor = Color.Green; break;
                case 3: panel4.BackColor = Color.Green; break;
                case 4: panel5.BackColor = Color.Green; break;
            }
            switch (czerwone)
            {
                case 1: panel2.BackColor = Color.Red; break;
                case 2: panel3.BackColor = Color.Red; break;
                case 3: panel4.BackColor = Color.Red; break;
                case 4: panel5.BackColor = Color.Red; break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            czas--;
            if (czas<=0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                panel6.Visible = true;
                label2.Visible = true;
            }
            label1.Text = czas.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            punkty++;
            label3.Text = punkty.ToString();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            if (zielone==1 && czas>0)
                timer3.Start();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (zielone == 2 && czas > 0)
                timer3.Start();
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            if (zielone == 3 && czas > 0)
                timer3.Start();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            if (zielone == 4 && czas > 0)
                timer3.Start();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (czerwone == 1)
                czas = 1;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (czerwone == 2)
                czas = 1;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (czerwone == 3)
                czas = 1;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            if (czerwone == 4)
                czas = 1;
        }
    }
}
