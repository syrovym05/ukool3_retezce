using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3_retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Počet slov: ";
            label2.Text = "Počet cifer: ";
            label3.Text = "Počet pismen: ";
            label4.Text = "Nejdelší slovo: ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vstup = textBox1.Text;

                while (vstup.Contains("  "))
                {
                    vstup.Replace("  ", " ");
                }
                string[] slova = vstup.Split(' ');


                int pocet_slov = slova.Length;
                int pocet_cifer = 0;
                int pocet_pismen = 0;
                string max_slovo = slova[0];


                foreach (string s in slova)
                {
                    if (s.Length > max_slovo.Length)
                    {
                        max_slovo = s;
                    }

                    foreach (char p in s)
                    {
                        if (p >= '0' && p <= '9') pocet_cifer++;

                        if ((p >= 'a' && p <= 'z') || (p >= 'A' && p <= 'Z')) pocet_pismen++;

                    }
                }

                string posledni_znak = vstup[vstup.Length - 1].ToString();
                string vysledek;

                if (vstup.Length % 2 == 0)
                {
                    vysledek = vstup.Insert(vstup.Length / 2, posledni_znak);
                }
                else
                {
                    vysledek = vstup.Insert((vstup.Length - 1) / 2, posledni_znak);
                }

                label1.Text = "Počet slov: " + pocet_slov;
                label2.Text = "Počet cifer: " + pocet_cifer;
                label3.Text = "Počet pismen: " + pocet_pismen;
                label4.Text = "Nejdelší slovo: " + max_slovo;

                textBox1.Text = vysledek;

            }
            catch(Exception)
            {
                MessageBox.Show("Chyba", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


         

        }
    }
}
