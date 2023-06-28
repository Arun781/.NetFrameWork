using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    abstract class moment
    {
        public abstract void SetName();
        public moment()
        {
            SetName();
        }
        
    }
    class MoveOn : moment
    {
        static void Main(string[] args)
        {
            MoveOn on = new MoveOn();
            on.SetName();
            Console.WriteLine(on);
            Console.ReadLine();
        }

        public override void SetName()
        {
            Console.WriteLine("Running the override method");
        }
    }
}
