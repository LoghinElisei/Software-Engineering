using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prim;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conjectura lui Goldbach");
        }


        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttDescompunere_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            if (!int.TryParse(textInput.Text, out int num)) return;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (num % 2 == 0)
            {
                if (num <= 2) { textOutput.Text = "!!!!! n > 2 !!!!!"; }
                else
                {
                    bool gasit = false;
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (Prim.Prim.isPrim(i) && Prim.Prim.isPrim(num - i))
                        {
                            textOutput.Text = $"{i} + {num - i}";
                            gasit = true;
                            break; // Ne oprim la prima soluție găsită
                        }
                    }
                    if (!gasit) textOutput.Text = "Nu s-a găsit";
                }
            }
            else
            {
                if (num < 7) { textOutput.Text = "!!!!!!!! n >= 7 !!!!!!!"; }
                else
                {
                    bool gasit = false;
                    for (int i = 2; i <= num && !gasit; i++)
                    {
                        for (int j = 2; j <= num - i && !gasit; j++)
                        {
                            int k = num - i - j;
                            if (k >= 2 && Prim.Prim.isPrim(i) && Prim.Prim.isPrim(j) && Prim.Prim.isPrim(k))
                            {
                                textOutput.Text = $"{i} + {j} + {k}";
                                gasit = true;
                            }
                        }
                    }
                    if (!gasit) textOutput.Text = "Rezultat negăsit";
                }
            }

            watch.Stop();
            MessageBox.Show($"Timp de execuție: {watch.Elapsed.TotalMilliseconds:F4} ms");
        }
    }
}
