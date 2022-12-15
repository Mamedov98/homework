using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Classes
{
    public class Delivery
    {
        public Idelivery? Deliv
        { get; set; }
        public Delivery(Idelivery customer)
        {
            this.Deliv = customer; 
        }

        public Delivery(ChangeDelivery changeDelivery)
        {
        }

        public Delivery()
        {
        }

        public virtual string Delivery_()
        {
            return "Метод доставки:\n" + Deliv.DeliveryOperation();
        }
    }
}
