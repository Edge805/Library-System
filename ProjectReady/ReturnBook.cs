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
    public partial class ReturnBook : Form
    {
        BorrowedBook borrow;
        Customer C;
        public ReturnBook(Book booktobeused,Customer ourcustomer)
        {
            InitializeComponent();
            borrow = (BorrowedBook)booktobeused;     
            C = ourcustomer;
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrow.State = trackBar1.Value;
            label6.Text = C.ReturnBook(borrow);
        }
    }
}
