using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech1
{
        public class Constructer
    {
        public Constructer() { Console.WriteLine(); }
        public Constructer(int a) { Console.WriteLine(); }
        static Constructer() { Console.WriteLine(); }

        static void Main(string[] args)
        {
            Console.WriteLine("We are in main method");
            Constructer c1, c2;
            c1= new Constructer();
            c2= new Constructer();
            Console.ReadLine();
        }
    }
}
