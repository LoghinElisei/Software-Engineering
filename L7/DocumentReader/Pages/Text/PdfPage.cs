using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages.Text
{
    public class PdfPage : Page
    {
        public PdfPage(in string fileName)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;

            webBrowser.Url = new Uri(Path.GetFullPath(fileName));

            this._content = webBrowser;
            this._name = Path.GetFileNameWithoutExtension(fileName);
        }
    }
}
