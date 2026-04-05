using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages
{
    public class Page
    {
        protected Control _content;
        protected string _name;

        public string Name => _name;
        public Control Content => _content;
    }
}
