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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            int age;
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "Female";
            }
                try
                {
                    age = int.Parse(textBox4.Text);
                    if (CustomerButton.Checked == true)
                    {
                         CustomerForm form3 = new CustomerForm(textBox1.Text, textBox2.Text, textBox3.Text, gender, Convert.ToInt32(textBox4.Text));
                         form3.Show();
                    }
                    else if (EmployeeButton.Checked == true)
                {
                    EmployeeForm form4 = new EmployeeForm(textBox1.Text, textBox2.Text, textBox3.Text, gender, Convert.ToInt32(textBox4.Text));
                    form4.Show();
                }
            }
                catch
                {
                    textBox4.Clear();
                    MessageBox.Show("Please Enter A valid format for age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
