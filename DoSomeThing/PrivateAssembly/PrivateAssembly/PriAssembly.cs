using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAssembly
{
    internal class PriAssembly
    {
        public PriAssembly()
        {
            Console.WriteLine("Created no Arg const.......");
        }
        private void Display()
        {
            Console.WriteLine("Hello From Public member");
        }
        protected void ShowMe()
        {
            Console.WriteLine("Hello From Protected Member");
        }
    }
}
