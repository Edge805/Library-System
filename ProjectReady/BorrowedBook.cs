using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReady
{
    public class BorrowedBook : Book
    {
        public DateTime returndate;
        private double borrowPrice=5;
        public double BorrowPrice { get { return borrowPrice; } set { borrowPrice = value; } }
        private int state;
        public int State { get { return state; } set { if ((value >= 0) && (value <= 10)) state = value; } }
        public BorrowedBook(DateTime returndate, double price, int state, string title, string author, bool available, string edition, string bookcategory) : base(title, author, available, edition, bookcategory, price)
        {
            this.returndate = returndate;
            State = state;
        }
        public override string ToString()
        {
            return $"{base.ToString()} State : {State}  Return Date : {returndate}";
        }
        public string ReturnDateCheck()
        {
            if (DateTime.Now > returndate)
            {
                return "You have to pay a fine for not returning the book in time";
            }
            else
            {
                return "You returned the book in time, Thank you";
            }
        }
        public string StateCheck()
        {
            if (State > 7)
            {
                return"You returned the book in a great condition, Thank you :)";
            }
            else if ((State > 4) && (State <= 6))
            {
                return"You have to pay a fine of 10$, for not returning the book in a good state";
            }
            else
            {
                return "The book is damaged, you have to pay it's total price";
            }
        }      
    }
}
