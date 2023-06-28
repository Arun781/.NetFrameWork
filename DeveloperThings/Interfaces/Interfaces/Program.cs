using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class shape
    {
        public abstract void CallArea();//abstract classes never have body
    }
    public class square : shape
    {
        public override void CallArea()
        {
            // throw new NotImplementedException();
            double area, side;
            side = 3.5;
            area = side * side;
            Console.WriteLine("the area of square is {0} ", area);
        }
    }

    public class Circle : shape
    {
        public override void CallArea()
        {
            //throw new NotImplementedException();
            double area, radius;
            radius = 3.5;
            area = 3.14 * radius * radius;
            Console.WriteLine("the area of circle is {0} ", area);
        }
    }
    public class ReactAngle : shape
    {
        public override void CallArea()
        {
            // throw new NotImplementedException();
            double area, len, width;
            len = 3.5; width = 4.5;
            area = len * width;
            Console.WriteLine("the area of rectngle  is {0} ", area);
        }
     static void Main(string[] args) {
            shape s1, s2, s3;
            s1 = new Circle();
            s1.CallArea();
            s2 = new square();
            s2.CallArea();  
            s3 = new ReactAngle (); 
            s3.CallArea();
        }
    }
    
}
