using System;

namespace Assignment1
{

    class MathClass
    {

        public void Average(params int[] A)
        {
            double total = 0;
            double avg = 0;

            for (int i = 0; i < A.Length; i++)
            {
                total = total + A[i];
            }
            avg = total / A.Length;
            Console.WriteLine("Average is " + avg);
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    MathClass m = new MathClass();
        //    //Console.WriteLine("Enter Values");
        //    //int[] A = Console.ReadLine();
        //    m.Average(12, 9, 13, 6, 41, 45);
        //}
    }
}
