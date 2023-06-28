using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may31First
{
    internal class Program
    {
        public void Add2Numbers()
        {//add 2 numbers
            int n1, n2, result;
            Console.WriteLine("enter 1st number");

            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd numeber");
            n2 = int.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.WriteLine("result of 2 numbers " + result);
            Console.WriteLine("{0}\t{1} retult of adding is  {2}  ", n1, n2, result);

        }
        static void Main(string[] args)
        {   // creaate object of class
            Program pr;//object 
            //memory allocation or instance 
            pr = new Program();//pr is referred as instance
            pr.Add2Numbers();//calling methods of class



            //            //type-safe
            //            string s1;
            //            int num1,num2,num3;
            //            Console.WriteLine("enter a number");
            //            //read value
            //            //num1 = Console.ReadLine();// compile error 
            //           // s1 = Console.ReadLine();
            //           num1 = int.Parse(Console.ReadLine());
            //            Console.WriteLine("enter a number");
            //           // Console.WriteLine("number is  " + num1);
            //            num2 = int.Parse(Console.ReadLine());
            //            Console.WriteLine("enter a number");
            //            num3 = int.Parse(Console.ReadLine());
            //            Console.WriteLine("{0}\t{1}\t{2} are numbers given ",num1,num2,num3);
            ////console.readline() returns string type value


        }
    }
}
