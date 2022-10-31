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
    public partial class RegostrationForm : Form
    {
        public RegostrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            pizza.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaccintaForm placcinta = new PlaccintaForm();
            placcinta.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StarForm starForm = new StarForm();
            starForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SunDayForm sunDayForm = new SunDayForm();
            sunDayForm.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PizzaForm pizzaForm = new PizzaForm();
            pizzaForm.Show();
            Hide();
        }
    }
}
