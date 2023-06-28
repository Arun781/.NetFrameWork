using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOnThreads
{
    internal class Program
    {
        static void d1()
        {
           for (int i = 0; i < 10; i++) {
                Console.WriteLine("Function 1 Exceuting"+i);
            }
        }
        static void d2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Exceuting" + i);
            }
        }

        static void Main(string[] args)
        {
            d1();
            d2();
        }
    }
}
