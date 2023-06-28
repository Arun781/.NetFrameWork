using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkOnThreads
{
    internal class New
    {
        static void f1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Exceuting" + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Parent thred start");
            Thread thread = new Thread(f1);
            thread.Start();
            Console.WriteLine("Parent thred complet.");
        }
    }
}
