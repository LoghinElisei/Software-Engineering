using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterSingleton
{
    public class Printer
    {
        private static Printer _instance = null;
        private List<DocInfo> _printerQueue;

        private Printer()
        {
            _printerQueue = new List<DocInfo>();
        }
        public static Printer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Printer();
                }
                return _instance;
            }
        }
        public void Add(string name, int timeleft)
        {

            _printerQueue.Add(new DocInfo(name, timeleft));
        }
        public void Tick()
        {
            if (_printerQueue.Count > 0)
            {
                _printerQueue[0].TimeLeft--;

                if (_printerQueue[0].TimeLeft <= 0)
                {
                    _printerQueue.RemoveAt(0);
                }
            }

        }

        public string Queue
        {
            get
            {
                string result = "";
                foreach (var doc in _printerQueue)
                {
                    result += doc.Name + " - " + doc.TimeLeft + "\r\n";
                }
                return result;
                
            }
        }

    }
}
