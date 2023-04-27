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
    public partial class FinalEmployee : Form
    {
        public FinalEmployee(Employee E1)
        {
            InitializeComponent();
            richTextBox1.Text = E1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
