using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Classes
{
    public class ChangeDelivery : Delivery
    {
        public ChangeDelivery(Idelivery delivery) : base(delivery)
        {

        }
        public virtual string Delivery()
        {
            return "Выбрана доставка\n" + Deliv.DeliveryOperation();
        }

    }
}
