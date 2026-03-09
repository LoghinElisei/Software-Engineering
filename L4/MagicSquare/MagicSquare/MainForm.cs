using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MagicSquare
{
    public partial class MainForm : Form
    {
        private int _squareSize, _squareSum;
        private int[,] _squareMatrix;
        private Bitmap _bmp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBoxSquare_Paint(object sender, PaintEventArgs e)
        {
            // evenimentul de desenare

            _bmp = new Bitmap(pictureBoxSquare.Width, pictureBoxSquare.Height);
            Graphics g = Graphics.FromImage(_bmp);

            g.Clear(Color.White);

            if (_squareMatrix != null)
            {
                int cellSize = 40;
                for (int i = 0; i < _squareSize; i++)
                    for (int j = 0; j < _squareSize; j++)
                    {
                        //g.DrawString(...);
                        g.DrawString(_squareMatrix[i,j].ToString(),new Font("Arial",12),Brushes.Black, j* cellSize + 10, i * cellSize + 10);
                    }

                for (int i = 0; i <= _squareSize; i++)
                {
                    //g.DrawLine(...); horizontal
                    g.DrawLine(Pens.Black, 0, i * cellSize, _squareSize * cellSize, i * cellSize);
                    //g.DrawLine(...); vertical
                    g.DrawLine(Pens.Black, i * cellSize, 0, i * cellSize, _squareSize * cellSize);

                }
            }

            e.Graphics.DrawImage(_bmp, 0, 0);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                // calculeaza patratul
                _squareSize = Convert.ToInt32(this.textBoxSize.Text);
                MagicBuilder mb = new MagicBuilder(_squareSize);
                _squareMatrix = mb.BuildMagicSquare();

                _squareSum = _squareSize * (_squareSize * _squareSize + 1) / 2;
                this.textBoxSum.Text = _squareSum.ToString();

                // apeleaza evenimentul de desenare cu metoda Refresh
                pictureBoxSquare.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error drawing the square: " + ex.Message);
            }

           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Check if the user pressed OK [cite: 434, 435]
            {
             
                _bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void buttonChm_Click(object sender, EventArgs e)
        {
            // afiseaza help-ul
            try
            {
                Help.ShowHelp(this, "MagicHelp.chm");
            }
            catch (Exception)
            {
            
                System.Diagnostics.Process.Start("MagicHelp.chm");
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program generates a Magic Square where the sum of every column, every row, and both diagonals is the same");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}