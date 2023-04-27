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
    public partial class CustomerForm : Form
    {
        public string name;
        public int nationalid;
        public string gender;
        public string address;
        public int age;
        public CustomerForm(string name,string nationalid,string gender,string address,int age)
        {
            InitializeComponent();
            this.name = name;
            this.nationalid = Convert.ToInt32(nationalid);
            this.gender = gender;
            this.address = address;
            this.age = age;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer C1 = new Customer(radioButton1.Checked, Convert.ToInt32(numericUpDown1.Value), trackBar1.Value, name, age, Convert.ToInt32(nationalid), address, gender);
            BooksForm form6 = new BooksForm(C1);
            form6.Show();
            this.Close();
        }
    }
}
