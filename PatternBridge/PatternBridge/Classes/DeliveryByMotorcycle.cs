using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Classes
{
    public class DeliveryByMotorcycle : Idelivery
    {
        public string DeliveryOperation()
        {
            return "Доставка на мотоцикле";
        }
    }
}
