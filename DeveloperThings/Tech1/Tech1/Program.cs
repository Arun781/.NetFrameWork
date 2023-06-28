using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    if (col == 1 || col == 5 || row == 1 || row == 5)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write (" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
