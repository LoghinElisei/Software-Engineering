/**************************************************************************
 *                                                                        *
 *  File:        DocumentManager.cs                                       *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               The real subject (Software Engineering lab 9)            *
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

namespace RealDocumentManager_Server
{
    public class RealDocumentManager : IDocumentManager
    {
        private static List<List<string>> _documents;
        private const string Path = "Secure\\", DocPath = "Secure\\Documente\\";
        private int _accessLevel;
        public int AccessLevel => _accessLevel;
        static RealDocumentManager()
        {
            // constructorul static este apelat automat o singura data inainte de prima instantiere a clasei sau inainte de folosirea campurilor statice
            // prin urmare, lista de documente este citita o singura data si de fiecate data cand se logheaza un utilizator
            // _documents este o lista de liste: pentru fiecare nivel de acces este retinuta lista de documente corespunzatoare nivelului respectiv

            try
            {
                StreamReader sr = new StreamReader(Path + "drepturi.txt");
                string[] lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                int numberOfLevels = lines.Length;

                _documents = new List<List<string>>(numberOfLevels);
                for (int i = 0; i < numberOfLevels; i++)
                    _documents.Add(new List<string>());

                for (int i = 0; i < numberOfLevels; i++)
                {
                    string[] files = lines[i].Split();
                    _documents[i].AddRange(files);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public RealDocumentManager(int accessLevel)
        {
            _accessLevel = accessLevel;
        }
        public List<string> GetDocumentList()
        {
            List<string> result = new List<string>();
            for (int i = 0; i <= _accessLevel && i < _documents.Count; i++)
            {
                result.AddRange(_documents[i]);
            }
            return result;
        }

        public string GetDocument(string documentName)
        {
            try
            {
                string filePath = DocPath + documentName;
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);

                    // 1. Arhivare (înainte de criptare)
                    byte[] contentBytes = System.Text.Encoding.UTF8.GetBytes(content);
                    byte[] compressedBytes = Cryptography.Compress(contentBytes);
                    string compressedBase64 = Convert.ToBase64String(compressedBytes);

                    // 2. Criptare
                    return Cryptography.Encrypt(compressedBase64, "SharedSecret");
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
    }
 }
