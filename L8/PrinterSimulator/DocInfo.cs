using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterSingleton
{
    public class DocInfo
    {
        public string Name { get; set; }
        public int TimeLeft { get; set; }
        public DocInfo(string name, int timeleft)
        {
            if (timeleft < 1)
                throw new Exception("Timpul necesar trebuie sa fie pozitiv");
            Name = name;
            TimeLeft = timeleft;
        }
    }

}
