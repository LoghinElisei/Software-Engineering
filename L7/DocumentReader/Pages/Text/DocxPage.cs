using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages.Text
{
    public class DocxPage : Page
    {
        public DocxPage(in string fileName)
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            try
            {
                var wordApp = new Microsoft.Office.Interop.Word.Application();

                var doc = wordApp.Documents.Open(Path.GetFullPath(fileName), ReadOnly: true);

                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();

                rtb.Paste();

                doc.Close(false);
                wordApp.Quit(false);
            }
            catch (Exception ex)
            {
                rtb.Text = "Eroare la încărcarea DOCX (Asigură-te că ai adăugat referința COM Interop.Word):\n" + ex.Message;
            }

            this._content = rtb;
            this._name = Path.GetFileNameWithoutExtension(fileName);
        }
    }
}
