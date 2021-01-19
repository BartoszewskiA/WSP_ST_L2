using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorownywarkaZdjec
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog()==DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == openFileDialog2.FileName)
            {
                form2.ShowDialog();
            }
            else
            {
                form3.ShowDialog();
            }
        }

        // Pliki JPEG (*.jpg)|*.jpg|Pliki BMP (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*
    }
}
