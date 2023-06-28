using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            String.Format("{0:d/M/yyyy HH:mm:ss}", dt); // "9/3/2008 16:05:07" - english (en-US)
            String.Format("{0:d/M/yyyy HH:mm:ss}", dt); // "9.3.2008 16:05:07" - german (de-DE)
            Console.WriteLine(dt);
            Console.ReadLine();
        }
    }
}
