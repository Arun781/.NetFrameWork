using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPro
{
    internal class EmpDetails
    {
        int id { get; set; }
        String name;
        String city;
        
        public void display()
        {
            Console.WriteLine("--------Enter Details--------");
            Console.Write("Enter Id:-" + id);
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name:-" + name);
            name = Console.ReadLine();
            Console.Write("Enter City:-" + city);
            city = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            EmpDetails emp = new EmpDetails();
            emp.display();
            Console.WriteLine();
            Console.WriteLine("--------------Displaying the Emp Details-----------");
            Console.WriteLine();
            Console.WriteLine("Employe ID "+emp.id.ToString());
            Console.WriteLine("Employe Name " + emp.name.ToString());
            Console.WriteLine("Employe City " + emp.city.ToString()); 
            Console.ReadLine(); 
        }

        
    }
}
