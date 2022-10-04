using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Device
{
    internal class Microwave : Device
    {
        public override void Desc()
        {
            Console.WriteLine("for warming a food");
        }

        public override void Show()
        {
            Console.WriteLine("Microwave");
        }

        public override void Sound()
        {
            Console.WriteLine("piip piip");
        }
    }
}
