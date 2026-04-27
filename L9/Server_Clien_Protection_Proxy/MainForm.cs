/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               Main form (Software Engineering lab 9)                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProtectionProxy
{
    public partial class MainForm : Form
    {
        private ProxyDocumentManager _proxyDocumentManager;

        public MainForm()
        {
            InitializeComponent();
            groupBoxAdmin.Enabled = false;

            _proxyDocumentManager = new ProxyDocumentManager();

            //buttonLogin.Click += buttonLogin_Click;
            //listBoxDocList.SelectedIndexChanged += listBoxDocList_SelectedIndexChanged;
            //buttonAddNew.Click += buttonAddNew_Click;
            //textBoxPassword.KeyPress += TextBoxPassword_KeyPress;
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin_Click(sender, e);

                e.Handled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUserName.Text;
            string pass = textBoxPassword.Text;

            if (_proxyDocumentManager.Login(user, pass))
            {
                int level = _proxyDocumentManager.CurrentAccessLevel;

                if (level == -1) 
                {
                    
                    groupBoxAdmin.Enabled = true;
                    groupBoxDocs.Enabled = false;
                    groupBoxContent.Enabled = false;
                    textBoxAccessLevel.Text = "Administrator";
                    listBoxDocList.Items.Clear();
                }
                else
                {
                    groupBoxAdmin.Enabled = false;
                    groupBoxDocs.Enabled = true;
                    groupBoxContent.Enabled = true;
                    textBoxAccessLevel.Text = _proxyDocumentManager.Levels[level];

                    listBoxDocList.Items.Clear();
                    List<string> docs = _proxyDocumentManager.GetDocumentList();
                    foreach (string d in docs)
                    {
                        listBoxDocList.Items.Add(d);
                    }
                }
            }
            else
            {
                MessageBox.Show("Autentificare eșuată! Utilizator sau parolă greșită.");
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            string newUser = textBoxNewUser.Text;
            string newPass = textBoxNewPassword.Text;
            int level = comboBoxAccessLevel.SelectedIndex;

            _proxyDocumentManager.AddUser(newUser, newPass, level);

            textBoxNewUser.Clear();
            textBoxNewPassword.Clear();
            comboBoxAccessLevel.SelectedIndex = -1;
        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie acces securizat documente");
        }

        private void listBoxDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocList.SelectedItem != null)
            {
                string docName = listBoxDocList.SelectedItem.ToString();
                string content = _proxyDocumentManager.GetDocument(docName);

                richTextBoxDocument.Rtf = content;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}