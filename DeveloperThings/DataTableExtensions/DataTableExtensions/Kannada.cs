using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExtensions
{
    internal class Kannada
    {
        static void Main(string[] args)
        {
            string [] Kannada = { "1.UdayaVani", "2.PrajaVani", "3.UdayaKarnataka" };
            for (int i = 0; i < Kannada.Length; i++)
            {
                string res = Kannada[i];
                Console.WriteLine(res);
              for (int j = 0; j < Kannada.Length; j++)
                {
                   j = j + 1;
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine(Kannada.Length);

            //string Kannada;
            //Kannada=Convert.ToString(Console.ReadLine());
            //switch (Kannada)
            //{
            //    case "1":
            //        Console.WriteLine("1.Udaya Vani");
            //        break;
            //    case "2":
            //        Console.WriteLine("2.Praja Vani");
            //        break;
            //        case "3":
            //        Console.WriteLine("3.Udaya Karnataka");
            //        break;
            //}
            //Console.WriteLine(Kannada+"Is my paper");
            //string lang2 = "English";
            //Console.WriteLine("Select Your lang" + lang2);
            //switch (lang2)
            //{
            //    case "1":
            //        Console.WriteLine("1.Times of India");
            //        break;
            //    case "2":
            //        Console.WriteLine("2.The Times");
            //        break;
            //    case "3":
            //        Console.WriteLine("3.The Economic Times");
            //        break;
            //}

            //String lang3 = "Telugu";
            //Console.WriteLine("Select Your lang" + lang3);
            //switch (lang3)
            //{
            //    case "1":
            //        Console.WriteLine("1.Andra Jyothi");
            //        break;
            //    case "2":
            //        Console.WriteLine("2.Namaste Telangana");
            //        break;
            //    case "3":
            //        Console.WriteLine("3.Praja Sakthi");
            //        break;
            //}
            //String lang4 ;
            //Console.WriteLine("Select Your lang" + lang4);
            //switch (lang4)
            //{
            //    case "1":
            //        Console.WriteLine("1.Hindustan");
            //        break;
            //    case "2":
            //        Console.WriteLine("2.NavBharat Times");
            //        break;
            //    case "3":
            //        Console.WriteLine("3.Patrika");
            //        break;
            //}

        }
    }
}
