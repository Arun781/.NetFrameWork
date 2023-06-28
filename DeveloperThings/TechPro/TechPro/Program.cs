using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    if (col == 1 || row == 1 || col == 5 || row == 5 || row == 3 || col == 3)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------");
            
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    if (row == 1 && col == 5)
                    {
                        Console.WriteLine("Xworkz");
                    }
                    else
                    {
                        Console.WriteLine(col);
                    }
                }
               
            }
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(" " + "Sonu");
            }
            Console.ReadLine();
        }
    }
}
