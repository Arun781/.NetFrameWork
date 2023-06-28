using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class LoginAndRigester
    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0;
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "admin" || password != "123456") && (ctr != 3));

            if (ctr == 3)
                Console.WriteLine("\nLogin attemp three or more times. Try later!");
            else
                Console.WriteLine("\nThe password entered successfully!");

            Console.ReadLine();
        }
    }
}
