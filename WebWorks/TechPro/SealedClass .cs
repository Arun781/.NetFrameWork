using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPro
{
    sealed class SealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class a
    {

        // Main Method
        static void Main(string[] args)
        {

            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
            Console.ReadLine();
        }
    }
}
