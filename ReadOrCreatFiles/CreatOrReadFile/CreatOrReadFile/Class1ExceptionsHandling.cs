using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CreatOrReadFile
{
    internal class Class1ExceptionsHandling
    {
        static void Main(string[] args)
        {
     //In this example, we have used sbyte variable for simple arithmetic calculation.The multiply of num1 and num2 should be 600 but you will get output 88.It will not raise any exception and error still your program is incorrect.It is done because you have used very small variable without using checked andunchecked statement. The size of sbyte is -128 to 127 only; so the result is overflowed.
            sbyte num1 = 20, num2 = 30, result;
            result = (sbyte)(num1 * num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            Console.ReadKey();
        }
    }


}
