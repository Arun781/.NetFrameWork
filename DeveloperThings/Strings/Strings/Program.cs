using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rNum = "";
            for (int i = 1; i < 1000; i++)
            {
                rNum = rNum + i.ToString();
                //will create 999 new strings are created in memory
                Console.WriteLine(rNum);
            }
            //string result = "";
            //StringBuilder sb = new StringBuilder(1000);
            //for (int i = 0; i < 1000; i++)
            //{
            //    sb.Append(i.ToString());
            //    //Console.WriteLine(sb.ToString());
            //}
            //result = sb.ToString();
            //Console.WriteLine(sb);
        }
    }
}
