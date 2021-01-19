using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OknoModalneBazaDanych
{
    public partial class Form1 : Form
    {
        Form2 okno2;
        public Form1()
        {
            InitializeComponent();
            okno2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okno2.ShowDialog()==DialogResult.OK)
            {
                String s = "";
                s += okno2.textBox1.Text;
                s += ";";
                s += okno2.textBox2.Text;
                s += ";";
                s += okno2.textBox3.Text;
                s += ";";
                s += okno2.textBox4.Text;
                s += ";";
                richTextBox1.Text += s;
                richTextBox1.Text += "\n";

            }
        }
    }
}
