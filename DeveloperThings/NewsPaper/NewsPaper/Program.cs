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

        public String inputKey { get; set; }   
        public String suscriberName { get; set; }   
        public int suscriberPhone { get; set; }

        public int language;

        public void LoginDetails()
        {
            Console.WriteLine("--------Enter Details of Suscriber---------");
            Console.Write("Name of the Suscriber only A-Z characters:-" + suscriberName);
            suscriberName=Console.ReadLine();

            Console.Write("Please enter the Phone Number of Suscriber:- ");
            suscriberPhone=int.Parse(Console.ReadLine());
        }
        public void final()
        {
            Console.WriteLine(suscriberName + "Choice of the daily news paper is"+ language);
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.LoginDetails();
            
            string[] langs = { "1.English", "2.Kannada", "3.Telugu", "4.Hindi" };
            for (int i = 0; i < langs.Length; i++)
            {
                string res = langs[i];
                Console.WriteLine(res);
            }
            int paper;
            Console.WriteLine("Enter a languge ID num to get news papers:- ");
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
            pro.final();
            Console.ReadLine();
        }
    }
}
