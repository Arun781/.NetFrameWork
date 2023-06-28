using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class SwappingAlphbets
    {
        
        static void Main(string[] args)
        {
            string str = "PQRQP";

            var res = str.Select(a => a == 'P' ? 'Q' : (a == 'Q' ? 'P' : a)).ToArray();
            str = new String(res);

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
