using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Class3
    {

        class StaticEx
        {

            public int a = 12;
            static int b = 10;

            public void increment()
            {
                a++;
                b++;
            }
            public void print()
            {
                Console.WriteLine("a= " + a);
                Console.WriteLine("b= " + b);
                Console.WriteLine("____________________________");
            }

        }

        //static void Main(string[] args)
        //{
        //    StaticEx e = new StaticEx();
        //    e.increment();
        //    e.print();

        //    StaticEx e1 = new StaticEx();
        //    e1.increment();
        //    e1.print();

        //}
    }
}
