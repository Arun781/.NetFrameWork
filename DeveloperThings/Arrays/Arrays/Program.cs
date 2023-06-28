using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            String[] strings = new String[10];
            strings[0] = "";
            strings[1] = "";
            strings[2] = "";
            strings[3] = "";
            //changinng the index value
            evenNums[2] = 150;
            Console.WriteLine(evenNums[2]);
            Console.WriteLine(evenNums.Length);
            Console.ReadLine();

        }
    }
}
