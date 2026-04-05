using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentReader.Pages;

namespace DocumentReader.Document
{
    public abstract class Document
    {
        protected List<Page> _pages;

        protected Document(in string indexFileName)
        {
            _pages = new List<Page>();
            StreamReader sr = new StreamReader(indexFileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line != string.Empty)
                    _pages.Add(CreatePage(line));
            }
            sr.Close();

        }
        public List<Page> Pages => _pages;
        protected abstract Page CreatePage(in string fileName);
    }
}
