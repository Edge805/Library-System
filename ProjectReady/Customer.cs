using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReady
{
    public class Customer : person
    {
        private bool subscription;
        public bool Subscription { get { return subscription; } set { subscription = value; } }
        private int numberofborrowedbooks;
        public int Numberofborrowedbooks { get { return numberofborrowedbooks; } set { } }
        private int rating;
        public int Rating { get { return rating; } set { rating = value; } }
        public Customer(bool subscription, int numberofborrowedbooks, int rating, string name, int age, int nationalid, string address, string gender) : base(name, age, nationalid, address, gender)
        {
            Subscription = subscription;
            Numberofborrowedbooks = numberofborrowedbooks;
            Rating = rating;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Subscription : {Subscription}";
        }
        /*public void DisplayBooks()
        {
            foreach (string s in borrowedbooks)
            {
                Console.WriteLine(s);
            }
        }*/
        public string borrow(BorrowedBook book1)
        {
            book1.Available = false;
            if (Numberofborrowedbooks >= 5)
            {               
                book1.returndate = DateTime.Now.AddDays(30);
                return"You are a loyal customer to our library, We have an offer for you, You can borrow the book up to 30 Days.";
            }
            else
            {
                book1.returndate = DateTime.Now.AddDays(14);
                return $"You have to return the book by {book1.returndate}";
            }
        }
        public string ReturnBook(BorrowedBook book1)
        {
            book1.Available = true;
            Numberofborrowedbooks++;
            return $"{book1.StateCheck()}\n{book1.ReturnDateCheck()}";         
        }
        public void Buy(BoughtBook b2)
        {
            if (b2.Quantity <= 0)
            {
                Console.WriteLine("Out of stock");
            }
            else
            {
                b2.Quantity--;
                if (b2.Quantity == 0)
                {
                    b2.Available = false;
                }
            }
        }
    }
}
