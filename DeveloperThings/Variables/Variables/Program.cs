using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        //public void adding()
        //{
        //    int a1, a2, a3;
        //    a1 = 1;
        //    a2 = 2;
        //    a3 = a1 + a2;
        //}
        //static int Adding(int a1, int a2)
        //{
        //    int a3 = a1 + a2;
        //    Console.WriteLine(a3);
        //    return a3;
        //}
        //static void Main(string[] args)
        //{
        //    //Adding(1, 2);
        //    int n = Adding(1, 2);
        //    Console.WriteLine(n);

        //}
        //================================================================
        //static void Fun1(int insideVar)//called
        //{
        //    insideVar = insideVar + 10;
        //}
        //static void Main(string[] args)//caller
        //{
        //    int outSideVar = 20;
        //    Fun1(outSideVar);
        //    Console.WriteLine(outSideVar);
        //    Console.ReadLine();

        //}

        //=================================================================
        //static void Fun1(ref int insideVar)//called
        //{
        //    insideVar = insideVar + 10;
        //}
        //static void Main(string[] args)//caller
        //{
        //    int outSideVar = 20;
        //    Fun1(ref outSideVar);
        //    Console.WriteLine(outSideVar);
        //    Console.ReadLine();
        //}

        //=================================================================
        static void Fun1(out int insideVar)//called
        {
            insideVar = 0;
            insideVar = insideVar + 10;
        }
        static void Main(string[] args)//caller
        {
            int outSideVar = 20;
            Fun1(out outSideVar);
            Console.WriteLine(outSideVar);
            Console.ReadLine();

        }
    }
}
