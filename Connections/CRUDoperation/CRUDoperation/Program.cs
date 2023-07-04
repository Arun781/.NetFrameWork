using Intuit.Ipp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperation
{
    internal class Program
    {
        public static List<Employee> DisplayAll()
        {
            List<Employee> listEMps = new List<Employee>();
            using (CompanyEntities ce = new CompanyEntities())
            {
                listEMps = ce.Employees.ToList();// select * from emp
            }
            return listEMps;
        }
        static void Main(string[] args)
        {
            List<Employee> empAll = DisplayAll();
            foreach (Employee s1 in empAll)
            {
                 Console.WriteLine("{0}\t{1}\t{2}\t{3}",s1.eId,s1.eName);
            }
        }
    }
}
