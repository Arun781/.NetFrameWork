using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankDetails
    {
        int bID;
        String bName;
        double bBalance;
        public BankDetails()
        {
            Console.WriteLine("Created a no argument constructor...");
        }
        public BankDetails(int id,string name ,double balance)
        {
            this.bID = id;
            this.bName = name;
            this.bBalance = balance;
        }
        public String DisplayDetails()
        {
            String display = string.Format("{0}\t{1}\t{2}" ,this.bID, this.bName, this.bBalance);
            Console.WriteLine(display);
            return display;
        }
    }
}
