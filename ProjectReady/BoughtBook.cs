using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReady
{
    public class BoughtBook : Book
    {
        private int quantity;
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public BoughtBook(double price, int quantity, string title, string author, bool available, string edition, string bookcategory) : base(title, author, available, edition, bookcategory, price)
        {
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Price : {Price} Quantity : {Quantity}";
        }
        public override bool found()
        {
            return base.found();
        }
        public void Order()
        {
            if (found() == true)
            {
                Quantity--;
                if (Quantity == 0)
                {
                    Available = false;
                }
            }

        }
    }
}
