using PrinterSingleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrinterSimulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                string numeDocument = textDocument.Text;
                int dimensiune = int.Parse(textDimensiune.Text);

                Printer.Instance.Add(numeDocument, dimensiune);

                textDocument.Clear();
                textDimensiune.Clear();
                textDocument.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introdu o dimensiune validă! Eroare: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loghin Elisei - 2026 - Ingineria programării");
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            Printer.Instance.Tick();
            richTextBox1.Text = Printer.Instance.Queue;
        }
    }
}
