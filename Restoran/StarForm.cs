using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class StarForm : Form
    {
        public StarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order");
        }
    }
}
