using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Zile
    {
        private int _zi;
        private int _luna;
        private int _an;
        private int _diferenta;

        public int Diferenta
        {
            get { return _diferenta; }
        }

        public Zile(int zi, int luna, int an)
        {
            _zi = zi;
            _luna = luna;
            _an = an;
            Calculeaza();
        }

        private void Calculeaza()
        {
            if (_luna < 1 || _luna > 12)
                throw new Exception("Dată invalidă");

            int[] nrzile = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            if (_an % 4 == 0 && _an % 100 != 0 || _an % 400 == 0) 
                nrzile[1] = 29;

            if (_zi < 1 || _zi > nrzile[_luna - 1])
                throw new Exception("Dată invalidă");

            int zilePanaLaDataIntrodusa = CalculZileAbsolute(_zi, _luna, _an);
            int zilePanaLaReferinta = CalculZileAbsolute(1, 1, 2000); 

            _diferenta = zilePanaLaDataIntrodusa - zilePanaLaReferinta;
        }

        private int CalculZileAbsolute(int zi, int luna, int an)
        {
            int[] nrzile = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)
                nrzile[1] = 29;

            int anPrecedent = an - 1;
            int aniBisecti = anPrecedent / 4 - anPrecedent / 100 + anPrecedent / 400;

            int zileAni = anPrecedent * 365 + aniBisecti;

            int zileLuni = 0;
            for (int i = 0; i < luna - 1; i++)
            {
                zileLuni += nrzile[i];
            }

            return zileAni + zileLuni + zi;
        }
    }
}
