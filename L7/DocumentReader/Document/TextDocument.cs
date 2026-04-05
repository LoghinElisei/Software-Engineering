using DocumentReader.Pages.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentReader.Pages;

namespace DocumentReader.Document
{
    public class TextDocument : Document
    {
        public TextDocument(in string indexFileName) : base(indexFileName)
        { }
        protected override Page CreatePage(in string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName), "Numele fișierului nu poate fi null.");
            }

            string extension = Path.GetExtension(fileName);

            if (string.IsNullOrEmpty(extension))
            {
                throw new ArgumentNullException(nameof(fileName), "Fișierul nu are o extensie validă.");
            }


            switch (extension.ToLower())
            {
                case ".txt": return new TextPage(fileName);
                case ".docx": return new DocxPage(fileName);
                case ".pdf": return new PdfPage(fileName);
                case ".rtf": return new RichTextFormatPage(fileName);
                default:
                    throw new NotSupportedException($"Extensia '{extension}' nu este suportată pentru fișierul '{fileName}'.");
            };
        }

    }
}
