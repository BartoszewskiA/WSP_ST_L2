using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3p01
{
    public partial class Form1 : Form
    {

        string[] users = new string[]
        {
            "Kowalski", "Nowak", "Iksiński", "Ktoś"
        };
        int[] pass = new int[]
        {
            111,222,333,444
        };

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kto = textBox1.Text;
            //int p = int.Parse(textBox2.Text);
            int p, temp;
            if (int.TryParse(textBox2.Text, out temp)) p = temp;
            else p = 0;
            // wersja dla jednego uzytkwnika
            //  if (users[0] == kto && pass[0] == p)
            //      label3.Text = "OK";
            // else
            //    label3.Text = "brak dostępu";

            // wersja dla wielu uzytkownikow
            bool dostep = false;

            for (int i =0; i< users.Length; i++)
            {
                if (users[i] == kto && pass[i] == p) dostep = true;
            }
            if (dostep)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "OK";
            }
            else 
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Brak dostępu"; 
            }
        
        }
    }
}
