using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkOnThreads
{
    internal class Threds
    {
        static void f1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Exceuting" + i);
                Thread.Sleep(1000);
            }
        }
        static void f2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 Exceuting" + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(f1);
            thread.Start();
            Thread  thread2 = new Thread(f2);               
            thread2.Start();
        }
    }
}
