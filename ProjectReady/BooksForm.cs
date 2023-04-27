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
    public partial class BooksForm : Form
    {
        Customer ourcustomer;
        private Book[] book = { new BoughtBook(60.5,8,"The Mindset", "Carol Dweck", true, "2007", "Self Development"), new BoughtBook(60,2,"Clean Code", "Uncle Bob", true, "2008", "Computer Sciene"), new BoughtBook(55, 5, "Five Love Languages", "Gary Chapman", true, "1992", "Relationships"), new BorrowedBook(new DateTime(2022, 8, 17), 5, 7, "Art of war", "Sun Tzu", true, "1998", "History"), new BoughtBook(100, 2, "Rich Dad Poor Dad", "Robert Kiyosaki", true, "1997", "Personal Finance"), new BoughtBook(25, 0, "The Book of five rings", "Miyamoto Musashi", false, "2004", "War Life Style") };
        Book Booktobeused;
        public BooksForm(Customer C1)
        {
            InitializeComponent();
            ourcustomer = C1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (Book b in book)
            {
                if ((comboBox1.GetItemText(comboBox1.SelectedItem) == b.Title) && (comboBox2.GetItemText(comboBox2.SelectedItem) == b.Author) && (b.Available==true)&&(b is BoughtBook))
                {
                    label3.Text = "Available for purchase";
                    label4.Text = Convert.ToString(b.Price);
                    flag = 1;
                    label6.Text = "The Book is avaialble";
                    Booktobeused = b;
                    BorrowButton.Enabled = false;
                    BuyButton.Enabled = true;
                    ReturnButton.Enabled = false;
                    break;
                }
                else if ((comboBox1.GetItemText(comboBox1.SelectedItem) == b.Title) && (comboBox2.GetItemText(comboBox2.SelectedItem) == b.Author) && (b.Available == true) && (b is BorrowedBook))
                {
                    label3.Text = "Available for borrow";
                    label4.Text = Convert.ToString(b.Price);
                    flag = 1;
                    label6.Text = "The Book is avaialble";
                    Booktobeused = b;
                    BorrowButton.Enabled = true;
                    BuyButton.Enabled = false;
                    ReturnButton.Enabled = true;
                    break;
                }
            }
           if (flag == 0)
            {
                label3.Text = "Not Available";
                label4.Text = "N/A";
                BorrowButton.Enabled = false;
                BuyButton.Enabled = false;
                label6.Text = "The Book is not currently available, Do you want to return it?";
            }
                           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm(Booktobeused,ourcustomer);
            borrowForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnBook returnform = new ReturnBook(Booktobeused,ourcustomer);
            returnform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm(Booktobeused,ourcustomer);
            buyForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
