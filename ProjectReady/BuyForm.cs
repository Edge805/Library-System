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
    public partial class BuyForm : Form
    {
        Book boughtBook;
        public BuyForm(Book b,Customer ourcustomer)
        {
            InitializeComponent();
            boughtBook =b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label6.Text = "Thank for coming to our shop, it was an honour ^_^";
                ((BoughtBook)boughtBook).Order();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
