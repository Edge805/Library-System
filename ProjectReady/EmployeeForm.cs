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
    public partial class EmployeeForm : Form
    {
        public string name;
        public int nationalid;
        public string gender;
        public string address;
        public int age;
        public int id;
        public EmployeeForm(string name, string nationalid, string gender, string address, int age)
        {
            InitializeComponent();
            this.name = name;
            this.nationalid = Convert.ToInt32(nationalid);
            this.gender = gender;
            this.address = address;
            this.age = age;
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(textBox1.Text);
                Employee E1 = new Employee(id, Convert.ToString(listBox1.GetItemText(listBox1.SelectedItem)), name, age, Convert.ToInt32(nationalid), address, gender, Convert.ToInt32(textBox2.Text));
                FinalEmployee form5 = new FinalEmployee(E1);
                form5.Show();
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Please Enter A valid format for ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
