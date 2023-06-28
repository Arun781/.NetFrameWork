using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace BankClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankDetails c1, c2;
            c1 = new BankDetails();
            c2 = new BankDetails(1,"Arun",2500);
            c2.DisplayDetails(); 
        }
    }
}
