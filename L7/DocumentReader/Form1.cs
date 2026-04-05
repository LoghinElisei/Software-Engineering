using DocumentReader.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentReader.Document; 
using DocumentReader.Pages;   

namespace DocumentReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            tabControl1.TabPages.Clear();

            openFileDialog1.Filter = "Text documents (*.txd)|*.txd|Graphic documents (*.grd)|*.grd";
            openFileDialog1.RestoreDirectory = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return; 

            Document.Document doc = null; 

            try
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                     doc = new TextDocument(openFileDialog1.FileName); 
                }
                else if (openFileDialog1.FilterIndex == 2)
                {
                     doc = new GraphicDocument(openFileDialog1.FileName); 
                }

                if (doc != null)
                {
                     tabControl1.Controls.Clear(); 

                     foreach (Page p in doc.Pages) 
                    {
                         TabPage tp = new TabPage(p.Name); 
                        
                         p.Content.Dock = DockStyle.Fill; 
                        
                         tp.Controls.Add(p.Content); 
                         tabControl1.TabPages.Add(tp); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la deschiderea/citirea fișierului:\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicație Document Factory\nRealizat cu șablonul Factory Method.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
