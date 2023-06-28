using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class CreateUserDefineWithParameter
    {
        //public string Welcome(string name)
        //{
        //    Console.WriteLine("Welcome"+name);
        //    return "Welcome";
        //}
        //public string Day()
        //{
        //    Console.WriteLine("Have a cool day");
        //    return "Day";
        //}

        //static void Main(string[] args)
        //{
        //    CreateUserDefineWithParameter str = new CreateUserDefineWithParameter();
        //    Console.WriteLine("Please Enter Your Name:-");
        //    str.Welcome("Arun");
        //    str.Day();
        //    Console.ReadLine();

        //}
        public static void welcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day");
        }
        public static void Main(string[] args)
        {
            string str1;
            Console.Write("Please Enter a name : ");
            str1 = Console.ReadLine();
            welcome(str1);
            HaveAnice();

            Console.ReadLine();
        }
    }
}
