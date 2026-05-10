using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Speed
{
    public partial class Form1 : Form
    {
        private double[] _array;
        private Random _rand;
        private IMeasure _speedMeasure;
        private ISort _sortingAlgorithm;
        public Form1()
        {
            InitializeComponent();
            _speedMeasure = new DateTimeMeasure();
        }

       

        private void radioButtonDateTime_CheckedChanged(object sender, EventArgs e)
        {
            _speedMeasure = new DateTimeMeasure();
        }

        private void radioButtonPerformance_CheckedChanged(object sender, EventArgs e)
        {
            _speedMeasure = new PerformanceCounterMeasure();
        }

        private void radioButtonButtonStopwatch_CheckedChanged(object sender, EventArgs e)
        {
            _speedMeasure = new StopwatchMeasure();
        }

        private void buttonGenRandom_Click(object sender, EventArgs e)
        {
            GenerateArray(0);
        }

        private void buttonGenCresc_Click(object sender, EventArgs e)
        {
            GenerateArray(1);
        }

        private void buttonGenDesc_Click(object sender, EventArgs e)
        {
            GenerateArray(2);
        }

        private void GenerateArray(int type)
        {
            try
            {
                int n = int.Parse(textBoxLungime.Text);
                int seed = int.Parse(textBoxSeed.Text);

                _array = new double[n];
                _rand = new Random(seed);

                if (_speedMeasure != null)
                {
                    _speedMeasure.BeginTest();
                }

                for (int i = 0; i < n; i++)
                {
                    if (type == 0)
                        _array[i] = _rand.NextDouble() * 1000;
                    else if (type == 1)
                        _array[i] = i;
                    else if (type == 2)
                        _array[i] = n - i;
                }

                double timpExecutie = 0;
                if (_speedMeasure != null)
                {
                    timpExecutie = _speedMeasure.EndTest();
                }

                string tipGenerare = "";
                if (type == 0) tipGenerare = "Generare aleatorie:";
                else if (type == 1) tipGenerare = "Generare crescatoare:";
                else if (type == 2) tipGenerare = "Generare descrescatoare:";

                textBoxRezultat.AppendText($"{tipGenerare} {timpExecutie.ToString("0.000")} ms\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor: " + ex.Message);
            }
        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            _sortingAlgorithm = new QuickSort();
            RunSort();

            if (progressBarQuick.Maximum > 0) progressBarQuick.Value = progressBarQuick.Maximum;
        }

     
        private void buttonSterge_Click(object sender, EventArgs e)
        {
            textBoxRezultat.Clear();

            progressBarQuick.Value = 0;
            progressBarShell.Value = 0;
            progressBarBubble.Value = 0;
            progressBarSelection.Value = 0;
        }

        private void buttonDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Despre");
        }

        private void buttonInchide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShellSort_Click(object sender, EventArgs e)
        {
            _sortingAlgorithm = new ShellSort();
            RunSort();

            if (progressBarShell.Maximum > 0) progressBarShell.Value = progressBarShell.Maximum;
        }
        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            _sortingAlgorithm = new SelectionSort();
            RunSort();

            if (progressBarShell.Maximum > 0) progressBarSelection.Value = progressBarShell.Maximum;
        }

        private void buttonBubbleSort_Click(object sender, EventArgs e)
        {
            _sortingAlgorithm = new BubbleSort();
            RunSort();

            if (progressBarBubble.Maximum > 0) progressBarBubble.Value = progressBarBubble.Maximum;
        }
        private void RunSort()
        {
            if (_array == null)
            {
                MessageBox.Show("Generați mai întâi un vector!");
                return;
            }

            _speedMeasure.BeginTest();

            double[] sortedArray = _sortingAlgorithm.Sort(_array);

            double timpExecutie = _speedMeasure.EndTest();

            string timpFormatat = timpExecutie.ToString("0.0000") + " ms";
            textBoxRezultat.AppendText($"\r\n{_sortingAlgorithm.GetType().Name}: {timpFormatat}\n");
        }

        private void PrintArray(string mesaj)
        {
            if (_array.Length <= 100) 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(mesaj);
                foreach (var item in _array)
                {
                    sb.Append(item.ToString("0.##") + " ");
                }
                sb.AppendLine();
                textBoxRezultat.AppendText(sb.ToString());
            }
            else
            {
                textBoxRezultat.AppendText($"\r\n{mesaj} (Dimensiune: {_array.Length} elemente. Prea mare pentru a fi afișat complet.)");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
