using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesG2
{
    public partial class frmDonutsOrder : Form
    {
        public frmDonutsOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int coffee = Convert.ToInt32(txbCoffes.Text);
            int donuts = Convert.ToInt32(txbDonuts.Text);

            Order o = new Order(name, coffee, donuts);

            ProcessOrder p = new ProcessOrder();
            p.ProcessTheOrder(o);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click handler");
        }

        private void DoSomething(object sender, EventArgs e)
        {
            MessageBox.Show("Doing Something");
        }
    }
}
