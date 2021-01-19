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

namespace Tekst_przyklad_01
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<String> tekst = new List<string>();
                while (!sr.EndOfStream)
                {
                    tekst.Add(sr.ReadLine());
                }
                richTextBox1.Lines = tekst.ToArray();
                sr.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> tekst = new List<string>(richTextBox1.Lines);
            List<String> wynik = new List<string>();
            for (int i=tekst.Count()-1; i>=0; i--)
            {
                wynik.Add(tekst[i]);
            }
            richTextBox2.Lines = wynik.ToArray();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                try
                {
                    StreamWriter sw = new StreamWriter(fs);
                    List<string> wynik = new List<string>(richTextBox2.Lines);
                    for (int i=0; i<wynik.Count(); i++)
                    {
                        sw.WriteLine(wynik[i]);
                    }
                    sw.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
