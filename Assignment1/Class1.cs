using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    class Swapping
    {
        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    class Class1
    {
        //static void Main(string[] args)
        //{

        //    int a, b;
        //    Console.WriteLine("Enter 2 numbers:");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    b = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Values Before Swapping a={0} and b={1}", a, b);

        //    Swapping s = new Swapping();
        //    s.Swap(ref a, ref b); 
        //    Console.WriteLine("Values after Swapping a={0} and b={1}", a, b);
        //}
    }
}
