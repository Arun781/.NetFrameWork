using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void dele(int a, int b);

namespace ImplementMulticastDelegates
{
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        static void Main(string[] args)
        {
            dele del = new dele(Add);
            del += new dele(Sub);
            del(4, 2);
            del -= new dele(Sub);
            del(1, 9);
            Console.Read();
        }
    }
}
