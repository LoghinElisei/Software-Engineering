using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    public class A
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class B
    {
        private int _x, _y;
        private int _sum;
        public int Sum
        {
            get { return _sum; }
        }
        public B(int x, int y)
        {
            _x = x; _y = y;
            _sum = A.Add(_x, _y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(1, 2);
            Console.WriteLine(b.Sum);
        }
    }
}
