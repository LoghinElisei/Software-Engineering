using System;
using System.Drawing;
using System.Windows.Forms;

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
                for (int i = 0; i < _squareSize; i++)
                    for (int j = 0; j < _squareSize; j++)
                    {
                        //g.DrawString(...);
                    }

                for (int i = 0; i <= _squareSize; i++)
                {
                    //g.DrawLine(...);
                    //g.DrawLine(...);
                }
            }

            e.Graphics.DrawImage(_bmp, 0, 0);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // calculeaza patratul
            _squareSize = Convert.ToInt32(this.textBoxSize.Text);
            MagicBuilder mb = new MagicBuilder(_squareSize);
            _squareMatrix = mb.BuildMagicSquare();

            // apeleaza evenimentul de desenare cu metoda Refresh
            pictureBoxSquare.Refresh();

            // codul din aceasta metoda trebuie inclus intr-un bloc de tratare a exceptiilor
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // salveaza imaginea
        }

        private void buttonChm_Click(object sender, EventArgs e)
        {
            // afiseaza help-ul
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // despre program
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}