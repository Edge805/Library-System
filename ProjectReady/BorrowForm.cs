using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectReady
{
    public partial class BorrowForm : Form
    {
        Customer C;
        public BorrowForm(Book booktobeborrowd,Customer ourcustomer)
        {
            InitializeComponent();
            C = ourcustomer;
            label1.Text=C.borrow((BorrowedBook)(booktobeborrowd));
            if (C.Subscription == true)
            {
                ((BorrowedBook)(booktobeborrowd)).BorrowPrice = 3;
            }
            label2.Text=$"You have to pay a fees of {((BorrowedBook)(booktobeborrowd)).BorrowPrice}";
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
