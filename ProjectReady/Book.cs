using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReady
{
    public class Book
    {
        private string title;
        private string author;
        private bool available;
        private string edition;
        private string bookcategory;
        private double price;
        public string Title { get { return title; } set { title = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Author { get { return author; } set { author = value; } }
        public bool Available { get { return available; } set { available = value; } }
        public string Edition { get { return edition; } set { edition = value; } }
        public string Bookcategory { get { return bookcategory; } set { bookcategory = value; } }
        public Book(string title, string author, bool available, string edition, string bookcategory, double price)
        {
            Title = title;
            Author = author;
            Available = available;
            Edition = edition;
            Bookcategory = bookcategory;
            Price = price;
        }
        public override string ToString()
        {
            return $"Title {Title} Author : {Author}  Available : {Available}  Edition : {Edition}  Bookcategory : {Bookcategory}";
        }
        public virtual bool found()
        {
            if (available == true)
            {
                Console.WriteLine("Found");
                return true;
            }
            else
            {
                Console.WriteLine("Not Found");
                return false;
            }
        }

    }
}
