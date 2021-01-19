using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosowZdjecie
{
    public partial class Form1 : Form
    {

        Image[] obrazki = new Image[]
        {
            Image.FromFile("pictures//p01.jpg"),
            Image.FromFile("pictures//p02.jpg"),
            Image.FromFile("pictures//p03.jpg"),
            Image.FromFile("pictures//p04.jpg"),
        };
        int n = 4;
        int numerObrazka = 0;

        Random random;
        
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            numerObrazka = random.Next(4);
            pictureBox1.Image = obrazki[numerObrazka];

            switch (numerObrazka)
            {
                case 0: radioButton1.Checked = true; break;
                case 1: radioButton2.Checked = true; break;
                case 2: radioButton3.Checked = true; break;
                case 3: radioButton4.Checked = true; break;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            int los;
            do
            {
                los = random.Next(4);
            } while (los == numerObrazka);
            numerObrazka = los;
            pictureBox1.Image = obrazki[numerObrazka];
            switch (numerObrazka)
            {
                case 0: radioButton1.Checked = true; break;
                case 1: radioButton2.Checked = true; break;
                case 2: radioButton3.Checked = true; break;
                case 3: radioButton4.Checked = true; break;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = obrazki[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = obrazki[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = obrazki[2];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = obrazki[3];
        }
    }
}
