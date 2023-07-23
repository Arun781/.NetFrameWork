using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPro
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "ArunKumar";
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.Write($"Actual String is : {str} \n");
            Console.Write($"Reversed String is : {reversedStr} ");
            Console.ReadLine();
        }
    }
}
