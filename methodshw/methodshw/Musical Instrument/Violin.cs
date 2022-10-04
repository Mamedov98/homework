using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Violin : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine("Скри́пка — смычковый музыкальный инструмент с четырьмя струнами, настроенными по квинтам: Gм D1 A1 E2");
        }

        public override void History()
        {
            Console.WriteLine("Прародителями скрипки были арабский ребаб, испанская фидель, германская рота, слияние которых и образовало виолу. Формы скрипки установились к XVI веку");
        }

        public override void Show()
        {
            Console.WriteLine("Скрипка");
        }

        public override void Sound()
        {
            Console.WriteLine("брынгь брынгь");
        }
    }
}
