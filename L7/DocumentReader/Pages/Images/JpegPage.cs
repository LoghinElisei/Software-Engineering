using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentReader.Pages.Images
{
    internal class JpegPage : Page
    {
        public JpegPage(in string fileName)
        {
            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.ImageLocation = fileName; 
            this._content = pb;  
            this._name = Path.GetFileNameWithoutExtension(fileName); 
        }
    }
}
