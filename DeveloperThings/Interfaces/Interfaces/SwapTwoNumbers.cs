using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class SwapTwoNumbers
    {
        int a; int b;
        void swap()
        {
            Console.Write("Enter 1st number:-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:-");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================================");
            Console.WriteLine("Before Swappig:-" + a + b);
            Console.WriteLine("===================================");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swappig:-" + a + b);
        }
        static void Main(string[] args)
        {

            SwapTwoNumbers a = new SwapTwoNumbers();
            a.swap();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
