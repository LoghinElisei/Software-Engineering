using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prim;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number =7;
            //int result = (Prim.Prim.isPrim(number) == false) ? 0:1;
            //Console.WriteLine(result);

            Console.WriteLine(Prim.Prim.numaraPrime(47).ToString());
            while (true)
            {
            }
        }
    }
}
