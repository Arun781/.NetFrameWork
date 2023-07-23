using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPro
{
    internal class CalculateSubStringInGivenString
    {
        static void Main()
        {
            string str = "Arun";
            for (int i = 1; i < str.Length; i++)
            {
                for (int start = 0; start <= str.Length - i; start++)
                {
                    string substr = str.Substring(start, i);
                    Console.WriteLine(substr);
                    Console.ReadLine    ();
                }
            }
        }
    }
}
