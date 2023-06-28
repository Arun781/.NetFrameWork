using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace NewsPaper
    {
        internal class Program
        {
            public String suscriberName;
            public int suscriberPhone;

            public void LoginDetails()
            {
                Console.WriteLine("--------Enter Details of Suscriber---------");
                Console.WriteLine("Name of the Suscriber only A-Z characters:-" + suscriberName);
                suscriberName = Console.ReadLine();
                Console.WriteLine("Please enter the Phone Number of Suscriber:- "+ suscriberPhone);
                suscriberPhone = int.Parse(Console.ReadLine());
            }
            public void SelectNewsPaper()
            {
                Console.WriteLine("----------List of news papers----------");
                string[] langs = { "1.English", "2.Kannada", "3.Telugu", "4.Hindi" };
                for (int i = 0; i < langs.Length; i++)
                {
                    string res = langs[i];
                    Console.WriteLine(res);
                }
                Console.WriteLine("-------Please Select Your Language--------");
                int paper;
                paper = Convert.ToInt32(Console.ReadLine());
                switch (paper)
                {
                    case 1:
                        Console.WriteLine("1.Times of India");
                        Console.WriteLine("2.The Times");
                        Console.WriteLine("3.The Economic Times");
                        break;
                    case 2:
                        Console.WriteLine("1.Udaya Vani");
                        Console.WriteLine("2.Praja Vani");
                        Console.WriteLine("3.Udaya Karnataka");
                        break;
                    case 3:
                        Console.WriteLine("1.Andra Jyothi");
                        Console.WriteLine("2.Namaste Telangana");
                        Console.WriteLine("3.Praja Sakthi");
                        break;
                    case 4:
                        Console.WriteLine("1.Hindustan");
                        Console.WriteLine("2.NavBharat Times");
                        Console.WriteLine("3.Patrika");
                        break;
                }
            }
            static void Main(string[] args)
            {
                Program pro = new Program();
                pro.LoginDetails();
                pro.SelectNewsPaper();
            }
        }
    }

}
