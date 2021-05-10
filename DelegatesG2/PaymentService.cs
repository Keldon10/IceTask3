using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesG2
{
    class PaymentService
    {
        public void collectPayment(Order o)
        {
            MessageBox.Show("Collected payment from " + o.Name);
        }
    }
}
