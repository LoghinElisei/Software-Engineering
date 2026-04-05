using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages.Text
{
    public class TextPage : Page
    {
        public TextPage(in string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                textBox.Text = sr.ReadToEnd();

                this._content = textBox;

            }
            this._name = Path.GetFileNameWithoutExtension(fileName);
        }
    }
}
