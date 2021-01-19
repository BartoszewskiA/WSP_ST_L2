using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprawdzaniePoprawnosciOknaDialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (sprawdzImie() && sprawdzNazwisko()) label4.Text = "OK";
        }

        private bool sprawdzImie()
        {
            bool wynik=true;
            String imie = textBox1.Text;
            if (imie.Length == 0)
            {
                MessageBox.Show("Pole Imie jest obowiązkowe", "Błąd");
                wynik = false;
            }       
            return wynik;
        }

        private bool sprawdzNazwisko()
        {
            bool wynik = true;
            String nazw = textBox2.Text;
            if (nazw.Length == 0)
            {
                MessageBox.Show("Pole Nazwisko jest obowiązkowe", "Błąd");
                wynik = false;
            }
            if (nazw.IndexOf(' ')>=0)
            {
                if (MessageBox.Show("Nazwisko musi być jednym wyrazem", "Błąd",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
                    textBox2.Text="";
                wynik = false;
            }

            return wynik;
        }
    }
}
