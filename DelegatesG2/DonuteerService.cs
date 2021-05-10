using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesG2
{
    class DonuteerService
    {
        public void packDonuts(Order o)
        {
            MessageBox.Show("Packing donuts - " + o.Donuts);

        }
    }
}
