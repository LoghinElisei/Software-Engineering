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
        double _arg;
        TrigEquation.TrigonometricFunction _function;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelX2.Text = "X" + "\x00B2" + " + ";
        }

        private void DespreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an polynomial and trigonometric function calculator");

        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculeazaButton_Click(object sender, EventArgs e)
        {

            try
            {
           
                String str = null;
                IEquation eq = null;
                if (EcPolinomialaSelect.Checked)
                {
                    _x0 = Convert.ToDouble(textX0.Text);
                    _x1 = Convert.ToDouble(textX1.Text);
                    _x2 = Convert.ToDouble(textX2.Text);

                    eq = new PolyEquation(_x2, _x1, _x0);
                   
                }
                else if (EcTrigonometricaSelect.Checked)
                {
                   
                   _arg = Convert.ToDouble(textArg.Text);
                   

                    if (comboBoxTrig.SelectedItem == null)
                        throw new Exception("Please select a trigonometric function");

                    string selectedFun = comboBoxTrig.SelectedItem.ToString();
                    if (selectedFun == "Sin")
                        _function = TrigEquation.TrigonometricFunction.Sin;
                    else if (selectedFun == "Cos")
                        _function = TrigEquation.TrigonometricFunction.Cos;
                    else if (selectedFun == "Tan")
                        _function = TrigEquation.TrigonometricFunction.Tan;
               


                    eq = new TrigEquation(_function, _arg);
                }
                str = eq.Solve();
                textBoxSolutie.Text = str;
            }
            catch (PolyException ex)
            {MessageBox.Show(ex.Message);}
            catch (TrigException ex)
            { MessageBox.Show(ex.Message);}
            catch(Exception ex)
            {MessageBox.Show(ex.Message);}
            
        }

        private void EcPolinomialaSelect_CheckedChanged(object sender, EventArgs e)
        { 
            if(EcPolinomialaSelect.Checked)
            {
                EcTrigonometricaSelect.Checked = false;
            }
        }

        private void EcTrigonometricaSelect_CheckedChanged(object sender, EventArgs e)
        {
            if(EcTrigonometricaSelect.Checked)
            {
                EcPolinomialaSelect.Checked = false;
            }
        }

        private void textX2_TextChanged(object sender, EventArgs e)
        {
            //_x2 = Convert.ToDouble(textX2.Text);
        }

        private void textX1_TextChanged(object sender, EventArgs e)
        {
            //_x1 = Convert.ToDouble(textX1.Text);
        }

        private void textX0_TextChanged(object sender, EventArgs e)
        {
            //_x0 = Convert.ToDouble(textX0.Text);
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            labelX2.Text = "X" + "\x00B2" + " + ";

        }

        private void comboBoxTrig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textArg_TextChanged(object sender, EventArgs e)
        {
            //_arg = Convert.ToDouble(textArg.Text);
        }
    }
}
