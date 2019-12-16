using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingAndOverloading
{
    class Overloading
    {
        public void print(string name)
        {
            Console.WriteLine("The Name is {0} ", name);
        }
        public void print(int age)
        {
            Console.WriteLine("The age is {0} ", age);
        }
    }

    class OverridingShape
    {
        public virtual void area()
        {
            Console.WriteLine("This is a virtual function");
        }
    }
    class rectangle: OverridingShape
    {
        public override void area()
        {
            int area, length=5, breadth=7;
            area = length * breadth;
            Console.WriteLine("Area is {0} ", area);
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {
            Overloading overObj = new Overloading();
            overObj.print("Akash");
            overObj.print(23);
            OverridingShape overrideObj;

            overrideObj = new OverridingShape();
            overrideObj.area();
            overrideObj = new rectangle();
            overrideObj.area();
          


            Console.ReadKey();
        }
    }
}
