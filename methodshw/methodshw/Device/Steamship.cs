using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Device
{
    internal class Steamship : Device
    {
        public override void Desc()
        {
            Console.WriteLine("water transport");
        }

        public override void Show()
        {
            Console.WriteLine("Steamship");
        }

        public override void Sound()
        {
            Console.WriteLine("sailing signal");
        }
    }
}
