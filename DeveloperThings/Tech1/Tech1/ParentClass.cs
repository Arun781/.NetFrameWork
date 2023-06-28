using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech1
{
    internal class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClasswith no param");

        }
        public ParentClass(int a)
        {
            Console.WriteLine("ParentClass with param");
        }
        static ParentClass()
        {
            Console.WriteLine("ParentClass with static param");
        }
        internal class ChildClass : ParentClass
        {
            public ChildClass()
            {
                Console.WriteLine("ChildClass with no param");

            }
            public ChildClass(int a)
            {
                Console.WriteLine("ChildClass with param");
            }
            static ChildClass()
            {
                Console.WriteLine("ChildClass with static param");
            }
        }
            static void Main(string[] args)
        {

        }
        
    }
}
