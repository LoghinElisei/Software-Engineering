using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();

            c1.fun1(1);
            c1.fun_x_2(1);
            c1.met1(1);
            c1.met2(1);

            c2.met1(1);
            c2.met2(2);
            c2.fun1(2);
            c2.fun_x_2(3);

            c3.fun1(3);
            c3.fun_x_2(3);
            c3.met(3);
            c3.mett(2);
        }

    }
}
