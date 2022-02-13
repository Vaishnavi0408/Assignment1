using System;
using System.IO;

namespace StoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fileStream = new FileStream("MyDemo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);

            Console.WriteLine("Enter data to wirte into file");
            string fileinfo = Console.ReadLine();
            writer.WriteLine(fileinfo);
            writer.Flush();

            Console.WriteLine("Data Stored into file Successfully");
        }
    }
}
