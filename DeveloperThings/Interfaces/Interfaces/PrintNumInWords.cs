using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class PrintNumInWords
    {
        static void Main(string[] args)
        {
            int n, num = 0;

            // Reading a number from user
            Console.WriteLine("Enter any number to print in words: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                num = (num * 10) + (n % 10);
                n /= 10;
            }

            //print corresponding digit in words till num becomes 0
            while (num != 0)
            {
                switch (num % 10)
                {
                    case 0:
                        Console.Write("zero ");
                        break;
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                }
                num = num / 10;



            }
            Console.ReadLine();
        }
        }
}
