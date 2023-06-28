using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    internal class Program
        {// class  scope or instance variable
            int n1, n2;
            static int n3;
            public void IfCondition()
            {// here static n3, non-static n1,n2 are also accessible            
             //enter a number
                Console.WriteLine("enter a number ");
                //declare a variable
                int num;//local or private
                num = int.Parse(Console.ReadLine());
                if (num < 10)
                { Console.WriteLine("number is very less"); }
                else if (num >= 10 && num <= 25)
                    Console.WriteLine("number is ok");
                else if (num > 25 && num <= 75)
                    Console.WriteLine("number is good");
                else
                    Console.WriteLine("number is excellent");
            }

            static void WhileLoop()//here only static members are accessible
            {// to repeat a task till condition comes false
                Console.WriteLine("enter a number 0--40");
                n3 = int.Parse(Console.ReadLine());//assign
                while (n3 < 50)// check condition
                {
                    Console.WriteLine("number is " + n3);
                    // n3++;
                    n3 = n3 + 1;//increment
                }

            }

            static int Menu()//int return type
            {
                Console.WriteLine("enter a choice");
                Console.WriteLine("1 if condition");
                Console.WriteLine("2  while loop");
                Console.WriteLine("3   do while");
                Console.WriteLine("4 exit");
                int ch = int.Parse(Console.ReadLine());
                return ch;// return keyword is must , it should be last statement in 
                Console.WriteLine();//not compile error line nevre executes
            }
            static void Dowhileloop()
            {
                // to repeat a task till condition comes false
                Console.WriteLine("enter a number 0--40");
                n3 = int.Parse(Console.ReadLine());//assign
                                                   // check condition
                do
                {
                    Console.WriteLine("number is " + n3);
                    // n3++;
                    n3 = n3 + 1;//increment
                } while (n3 < 50);
            }
            static void Main(string[] args)
            {
                int c = Menu();
                switch (c)
                {
                    case 1:
                        {
                            Program pr = new Program();
                            pr.IfCondition();
                            break;
                        }
                    case 2: { WhileLoop(); break; }
                    case 3: { Dowhileloop(); break; }
                    case 4: { System.Environment.Exit(0); break; }
                    default: { Console.WriteLine("wrong "); break; }

                }

                // Program.Dowhileloop();
                //   Dowhileloop();
                //  WhileLoop();//S data member are accissible by class name --
                // Program.WhileLoop();
                // class 
                // Program pr;
                //instance
                //   pr = new Program();
                //call
                //    pr.IfCondition();//non-static are accissble by object of class
                Console.ReadLine();//f5
            }
        
}
}
