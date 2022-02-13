using System;
using System.Collections.Generic;


namespace BookClass
{
    public class Books
    {
        public int bookid;
        public string bookname;
        public string aname;
        public float price;

        public Books(int bid, string bname, string aname, float pr)
        {
            bookid = bid;
            bookname = bname;
            this.aname = aname;
            price = pr;

        }
        public void Calculate()
        {
            price = price - (price * 10 / 100);
            Console.WriteLine(price);
        }
        public void ShowDetails()
        {
            Console.WriteLine(bookid + " , " + bookname + " , " + aname + " , " + price);
        }

    }
    class Class1
    {
        static void Main(string[] args)
        {
            List<Books> list = new List<Books>();
            {
                new Books(1, "CPP", "Tony Gaddis", 390);
                new Books(2, "Java", "Charles Perkins", 650);
                new Books(3, "C#", "Jon Skeet", 2550);
            };
            //list.Add(new Book(1, "CPP", "Tony Gaddis", 390));
            //list.Add(new Book(2, "Java", "Charles Perkins", 650));
            //list.Add(new Book(3, "C#", "Jon Skeet", 2550));

            foreach (Books b in list)
            {
                Console.WriteLine(b);
            }
        }
    }
}
