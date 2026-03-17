/**************************************************************************
 *                                                                        *
 *  File:        MagicBuilder.cs                                          *
 *  Copyright:   (c) 2026, Loghin Elisei                              *
 *  E-mail:      elisei.loghin2@student.tuiasi.ro                         *
 *  Website:     https://github.com/LoghinElisei                          *
 *  Description: Calculates magic squares of any size                     *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MagicSquare
{
    /// <summary>
    /// Reprezintă fereastra principală a aplicației Magic Square.
    /// Gestionează interfața cu utilizatorul, desenarea matricei și salvarea rezultatelor.
    /// </summary>
    public partial class MainForm : Form
    {
        private int _squareSize, _squareSum;
        private int[,] _squareMatrix;
        private Bitmap _bmp;

        /// <summary>
        /// Constructorul ferestrei principale.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedura responsabilă pentru randarea vizuală a pătratului magic.
        /// </summary>
        /// <param name="sender">Sursa evenimentului (PictureBox).</param>
        /// <param name="e">Datele pentru evenimentul de desenare.</param>
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

        /// <summary>
        /// Gestionează evenimentul de click pe butonul de generare.
        /// </summary>
        /// <param name="sender">Butonul Draw.</param>
        /// <param name="e">Argumentele evenimentului.</param>
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

        /// <summary>
        /// Gestionează salvarea reprezentării grafice într-un fișier imagine.
        /// </summary>
        /// <param name="sender">Butonul Save.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Check if the user pressed OK [cite: 434, 435]
            {
             
                _bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        /// <summary>
        /// Lansează sistemul de ajutor al aplicației.
        /// </summary>
        /// <param name="sender">Butonul Help.</param>
        /// <param name="e">Argumentele evenimentului.</param>
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

        /// <summary>
        /// Afișează informații despre scopul programului.
        /// </summary>
        /// <param name="sender">Butonul About.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program generates a Magic Square where the sum of every column, every row, and both diagonals is the same");
        }

        /// <summary>
        /// Închide complet aplicația.
        /// </summary>
        /// <param name="sender">Butonul Close.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}