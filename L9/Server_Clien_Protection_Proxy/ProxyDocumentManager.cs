/**************************************************************************
 *                                                                        *
 *  File:        DocumentManager.cs                                       *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               The Protection Proxy (Software Engineering lab 9)        *
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
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProtectionProxy
{
    public class ProxyDocumentManager : IDocumentManager
    {
        private List<User> _users;
        private List<string> _levels;
        private User _currentUser;
        private const string Path = "Secure\\";

        public List<string> Levels => _levels;
        public int CurrentAccessLevel { get; private set; }

        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;
            public readonly int AccessLevel;

            public User(string name, string passHash, int accessLevel)
            {
                Name = name;
                PassHash = passHash;
                AccessLevel = accessLevel;
            }
        }

        public ProxyDocumentManager()
        {
            try
            {
                _levels = new List<string>();
                StreamReader sr = new StreamReader(Path + "niveluri.txt");
                string[] lvls = sr.ReadToEnd().Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                for (int i = 0; i < lvls.Length; i++)
                    _levels.Add(lvls[i]);

                _users = new List<User>();
                sr = new StreamReader(Path + "utilizatori.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private string SendRequest(string request)
        {
            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 8888))
                using (NetworkStream stream = client.GetStream())
                using (StreamReader reader = new StreamReader(stream))
                using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
                {
                    writer.WriteLine(request);
                    return reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare de conexiune cu Serverul: " + ex.Message);
                return string.Empty;
            }
        }
        public List<string> GetDocumentList()
        {
            if (CurrentAccessLevel >= 0)
            {
                string response = SendRequest($"LIST|{CurrentAccessLevel}");
                if (!string.IsNullOrEmpty(response))
                {
                    return new List<string>(response.Split(','));
                }
            }
            return new List<string>();
        }

        public string GetDocument(string documentName)
        {
            if (CurrentAccessLevel >= 0)
            {
                string encryptedContent = SendRequest($"GET|{documentName}|{CurrentAccessLevel}");

                if (!string.IsNullOrEmpty(encryptedContent))
                {
                    string compressedBase64 = Cryptography.Decrypt(encryptedContent, "SharedSecret");

                    byte[] compressedBytes = Convert.FromBase64String(compressedBase64);
                    byte[] decompressedBytes = Cryptography.Decompress(compressedBytes);

                    return Encoding.UTF8.GetString(decompressedBytes);
                }
            }
            return string.Empty;
        }

        public bool Login(string username, string password)
        {
            string hash = Cryptography.HashString(password);
            foreach (var user in _users)
            {
                if (user.Name == username && user.PassHash == hash)
                {
                    _currentUser = user;
                    CurrentAccessLevel = user.AccessLevel;
                    return true;
                }
            }
            return false;
        }

        public void AddUser(in string user, in string pass, in int level)
        {
            foreach (var u in _users)
            {
                if (u.Name == user)
                {
                    MessageBox.Show("Utilizatorul există deja!");
                    return;
                }
            }

            string hash = Cryptography.HashString(pass);
            _users.Add(new User(user, hash, level));

            SaveUsers();
            MessageBox.Show("Utilizator adăugat cu succes!");
        }
        private void SaveUsers()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path + "utilizatori.txt"))
                {
                    foreach (var u in _users)
                    {
                        sw.WriteLine($"{u.Name}\t{u.PassHash}\t{u.AccessLevel}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}