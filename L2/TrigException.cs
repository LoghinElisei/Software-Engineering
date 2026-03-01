using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class TrigException: Exception
    {
        double _argument;
        string _message;

        public TrigException(string message,double argument)
        {
            _message = message;
            _argument = argument;
        }
        public override string Message => _message+_argument.ToString();

    }
}
