using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExtensions
{
   
public class A
    {
        public A()
        {
            Console.WriteLine("A object initialized");
        }
        ~A() { Console.WriteLine("A object released "); }
    }
    public class B : A { public B() { Console.WriteLine("B object initialized"); } ~B() { Console.WriteLine("B object released"); } }
    public class C : B
    {
        public C() { Console.WriteLine("C object initialized"); }
        ~C() { Console.WriteLine("C object released"); }
        static void Main(string[] args)
        {
            Console.WriteLine("all objects are going to created");
            C obj;
            obj = new C();
            obj = null;
            //GC.Collect();
            Console.WriteLine("all objects are being release now");
            Console.ReadLine();
        }
    }
}
