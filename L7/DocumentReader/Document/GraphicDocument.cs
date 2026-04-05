using DocumentReader.Pages.Images;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentReader.Pages;

namespace DocumentReader.Document
{
    public class GraphicDocument : Document
    {
    
        public GraphicDocument(in string indexFileName) : base(indexFileName) { }

      
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
                case ".bmp": return new BitmapPage(fileName); 
                case ".jpg":
                case ".jpeg": return new JpegPage(fileName); 
                default:
                    throw new ArgumentException($"Extensia '{extension}' nu este suportată."); 
            }
        }
    }
}
