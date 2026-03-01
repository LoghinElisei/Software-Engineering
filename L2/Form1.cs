using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2
{
    public partial class Form1 : Form
    {
        double _x0;
        double _x1;
        double _x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DespreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Despre aplicatie");

        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculeazaButton_Click(object sender, EventArgs e)
        {
            IEquation eq = new PolyEquation(_x2, _x1, _x0);
            textBoxSolutie.Text = eq.Solve();
        }

        private void EcPolinomialaSelect_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void EcTrigonometricaSelect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textX2_TextChanged(object sender, EventArgs e)
        {
            _x2 = Convert.ToDouble(textX2.Text);
        }

        private void textX1_TextChanged(object sender, EventArgs e)
        {
            _x1 = Convert.ToDouble(textX1.Text);
        }

        private void textX0_TextChanged(object sender, EventArgs e)
        {
            _x0 = Convert.ToDouble(textX0.Text);
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            labelX2.Text = "X" + "\x00B2" + " + ";

        }
    }
}
