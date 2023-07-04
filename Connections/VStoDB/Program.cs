using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VStoDB.DB;

namespace VStoDB
{
    public class Program
    {

        public static void AddNewStudent()
        {
            using (CollegeDB cd = new CollegeDB())
            {
                StudentDB st = new StudentDB()
                { sID = 1, sName = "Arun Veerapur", sFirstName = "Arun", sLastName = "Veerapur",  sMarks = 45 };
                StudentDB st1 = new StudentDB()
                { sID = 1, sName = "Arun Veerapur", sFirstName = "Arun", sLastName = "Veerapur", sMarks = 45 };

                cd.students.Add(st);
                cd.SaveChanges();
                Console.WriteLine("I'm done...");
            }
        }
       
        
        static void Main(string[] args)
        {
            AddNewStudent();
        }
    }
}
