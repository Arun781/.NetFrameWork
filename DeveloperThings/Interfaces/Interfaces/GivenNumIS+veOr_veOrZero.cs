using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class GivenNumIS_veOr_veOrZero
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("PLease Enter to find number:-");
            num=int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The Enter is +VE :-" + num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The Enter is -VE :-" + num);
            }
            else
            {
               
                Console.WriteLine("The Enter is Zero" + num);
            }
            Console.ReadLine();
        }
    }
}
