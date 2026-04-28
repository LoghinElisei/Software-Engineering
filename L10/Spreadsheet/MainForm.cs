/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Main form (Software Engineering lab 10)                  *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spreadsheet
{
    public partial class MainForm : Form
    {
        private TextBoxGrid _grid;
        private Invoker _invoker;
        private int _selected; // numarul celulei in care se efectueaza o actiune; _grid.GetCell(_selected) intoarce obiectul ExtendedTextBox corespunzator
        private FormulaEvaluator _evaluator;

        public MainForm()
        {
            InitializeComponent();

            _grid = new TextBoxGrid(Controls, 27, 140, new EventHandler(textBox_Enter), new EventHandler(textBox_Leave), new KeyEventHandler(textBox_KeyDown));
            _invoker = new Invoker(_grid);
            _evaluator = new FormulaEvaluator(_grid);

            UpdateUndoRedoCombos();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            // acest eveniment se apeleaza cand o celula devine controlul selectat activ din fereastra

            Control ac = this.ActiveControl;
            ExtendedTextBox tb = (ExtendedTextBox)sender;

            _selected = Convert.ToInt32(tb.Name.Substring(2));
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            // acest eveniment se apeleaza cand o celula nu mai este controlul selectat activ din fereastra

            Control ac = this.ActiveControl;
            ExtendedTextBox tb = (ExtendedTextBox)sender;
            _selected = Convert.ToInt32(tb.Name.Substring(2));

            string evaluatedText = _evaluator.Evaluate(tb.Text);
            if (evaluatedText != tb.Text)
            {
                tb.Text = evaluatedText;
            }

            ChangeTextCommand c = new ChangeTextCommand(tb, $"Change text on {_grid.GetCoords(_selected)}: \"{tb.Text}\"");
            if (c.MakesChanges())
            {
                _invoker.SetAndExecute(c);
            }
            else
            {
                tb.Text = tb.PreviousText;
            }

            this.ActiveControl = ac;
            UpdateUndoRedoCombos();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // cand se apasa ENTER intr-o celula
            {
                ExtendedTextBox tb = (ExtendedTextBox)sender;
                _selected = Convert.ToInt32(tb.Name.Substring(2));
                this.ActiveControl = _grid.GetSuccessor(_selected);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            Color c = colorDialog.Color;
            buttonColor.ForeColor = c;
            //buttonColor.BackColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

            // se creeaza o comanda de schimbare a culorii
            // daca este o comanda valida (care provoaca o schimbare), se introduce in _invoker si apoi se apeleaza metoda UpdateUndoRedoCombos

            ExtendedTextBox cell = _grid.GetCell(_selected);
            ChangeColorCommand cmd = new ChangeColorCommand(cell, c, $"Change color on {_grid.GetCoords(_selected)}: {c.Name}");

            if (cmd.MakesChanges())
            {
                _invoker.SetAndExecute(cmd);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            ExtendedTextBox cell = _grid.GetCell(_selected);
            ChangeFormatCommand cmd = new ChangeFormatCommand(cell, FontStyle.Regular, $"Change format on {_grid.GetCoords(_selected)}: Regular");
            if (cmd.MakesChanges())
            {
                _invoker.SetAndExecute(cmd);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            ExtendedTextBox cell = _grid.GetCell(_selected);
            ChangeFormatCommand cmd = new ChangeFormatCommand(cell, FontStyle.Bold, $"Change format on {_grid.GetCoords(_selected)}: Bold");
            if (cmd.MakesChanges())
            {
                _invoker.SetAndExecute(cmd);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            ExtendedTextBox cell = _grid.GetCell(_selected);
            ChangeFormatCommand cmd = new ChangeFormatCommand(cell, FontStyle.Italic, $"Change format on {_grid.GetCoords(_selected)}: Italic");
            if (cmd.MakesChanges())
            {
                _invoker.SetAndExecute(cmd);
                UpdateUndoRedoCombos();
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _invoker.Undo();
            UpdateUndoRedoCombos();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            _invoker.Redo();
            UpdateUndoRedoCombos();
        }

        private void UpdateUndoRedoCombos()
        {
            comboBoxUndo.Items.Clear();
            foreach (string s in _invoker.UndoDescriptions)
                comboBoxUndo.Items.Add(s);

            if (comboBoxUndo.Items.Count > 0)
            {
                comboBoxUndo.SelectedIndex = 0;
                buttonUndo.Enabled = true;
            }
            else
            {
                buttonUndo.Enabled = false;
            }

            comboBoxRedo.Items.Clear();
            foreach (string s in _invoker.RedoDescriptions)
                comboBoxRedo.Items.Add(s);

            if (comboBoxRedo.Items.Count > 0)
            {
                comboBoxRedo.SelectedIndex = 0;
                buttonRedo.Enabled = true;
            }
            else
            {
                buttonRedo.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _grid.Clear();
            _invoker.Clear();
            UpdateUndoRedoCombos();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            const string copyright =
               "Sablonul de proiectare Comanda\r\n" +
               "Ingineria programarii, Laboratorul 10\r\n" +
               "(c)2026 Loghin Elisei\r\n";

            MessageBox.Show(copyright, "Despre Foaia de calcul");
        }
    }
}