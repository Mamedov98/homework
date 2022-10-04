using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Device
{
    internal class Kettle : Device
    {
        public override void Desc()
        {
            Console.WriteLine("to boil water");
        }

        public override void Show()
        {
            Console.WriteLine("Kettle");
        }

        public override void Sound()
        {
            Console.WriteLine("bul-bul");
        }
    }
}

