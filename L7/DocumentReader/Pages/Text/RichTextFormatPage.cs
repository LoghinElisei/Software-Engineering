using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages.Text
{
    public class RichTextFormatPage : Page
    {
        public RichTextFormatPage(in string fileName)
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            rtb.LoadFile(fileName, RichTextBoxStreamType.RichText);

            this._content = rtb;
            this._name = Path.GetFileNameWithoutExtension(fileName);
        }
    }
}
