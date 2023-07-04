using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWork
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
        public static void DisplayWithSp()
        {
            using (CompanyEntities ce = new CompanyEntities())
            {

                var listEmps = ce.prc_empselectall().ToList(); 
                foreach (var e1 in listEmps)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", e1.eId, e1.eName, e1.eAddress, e1.eSalary);
                }
            }
        }
        public static void DisplayARow(int no)
        {
            using (CompanyEntities ce = new CompanyEntities())
            {
                //  Select * from emp where eid=101
                //  emp e1 = ce.emps.Where(x => x.eid == no).FirstOrDefault();// matching record
                //  Console.WriteLine("{0}\t{1}\t{2}",e1.eid,e1.Ename,e1.salary);
                string s1 = ce.Employees.Where(x => x.eId == no).FirstOrDefault().eName;
                string s2 = ce.Employees.Where(x => x.eId == no).FirstOrDefault().eAddress;
                decimal s3 = ce.Employees.Where(a => a.eId == no).FirstOrDefault().eSalary;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", no, s1, s2,s3);
            }
        }
        static void Main(string[] args)
        {
            //List<Employee> empAll = DisplayAll();
            //foreach (Employee e1 in empAll)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}",e1.eId,e1.eName,e1.eAddress,e1.eSalary);
            //}
            //DisplayWithSp();
            Console.WriteLine("enter id");
            int n = int.Parse(Console.ReadLine());
            DisplayARow(n);
        }
    }
}
