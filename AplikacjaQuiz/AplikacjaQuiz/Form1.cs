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

namespace AplikacjaQuiz
{
    public partial class Form1 : Form
    {
        List<string> pytania = new List<string>();
        List<string> odpowiedzi = new List<string>();
        List<int> wyniki = new List<int>();
        int numerPytania=0;
        int liczbaDobrychOdp = 0;
        int liczbaZlychOdp = 0;
        public Form1()
        {
            InitializeComponent();
            wczytajTestDoList();
            wypiszNaEkran(numerPytania);
        }

        private void wypiszNaEkran(int n)
        {
            richTextBox1.Text = pytania[n];
            richTextBox2.Text = odpowiedzi[n];
        }

        private void wczytajTestDoList()
        {
            String adres = "J:\\Programy 2020\\WSP_ST_L2\\AplikacjaQuiz\\pytania.txt";
            FileStream fs = new FileStream(adres, FileMode.Open, FileAccess.Read);
            string odp = "";
            try
            {
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    pytania.Add(sr.ReadLine());
                    odp += "a) ";
                    odp += sr.ReadLine();
                    odp += "\n";
                    odp += "b) ";
                    odp += sr.ReadLine();
                    odp += "\n";
                    odp += "c) ";
                    odp += sr.ReadLine();
                    odpowiedzi.Add(odp);
                    odp = "";
                    wyniki.Add(int.Parse(sr.ReadLine()));
                }
                sr.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania pliku:    "+ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int naszaOdpowiedz = 0;
            if (radioButton1.Checked) naszaOdpowiedz = 1;
            else if (radioButton2.Checked) naszaOdpowiedz = 2;
            else if (radioButton3.Checked) naszaOdpowiedz = 3;
            if (naszaOdpowiedz == wyniki[numerPytania]) liczbaDobrychOdp++;
            else liczbaZlychOdp++;
            textBox1.Text = liczbaDobrychOdp.ToString();
            textBox2.Text = liczbaZlychOdp.ToString();
            numerPytania++;
            wypiszNaEkran(numerPytania);
        }
    }
}
