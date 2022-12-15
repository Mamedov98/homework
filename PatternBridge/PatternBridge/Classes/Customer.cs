using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Classes
{
    public class Customer
    {
        public void CustomerChoice(Delivery delivery)
        {
            Console.WriteLine(delivery.Delivery_());
        }
    }
}
