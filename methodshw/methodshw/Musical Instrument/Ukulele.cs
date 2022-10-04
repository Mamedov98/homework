using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Ukulele : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine("Укулеле – это миниатюрная четырёхструнная гавайская гитара. В переводе с гавайского «укулеле» – прыгающая блоха");
        }

        public override void History()
        {
            Console.WriteLine("Укулеле появилась на Гавайских островах во второй половине XIX века, куда её, под названием машети да браса (порт. machete da braça), завезли португальцы с острова Мадейра. Первый магазин по продаже укулеле на Гавайях был открыт в 1880 году Мануэлем Нуньесом");
        }

        public override void Show()
        {
            Console.WriteLine("Укулеле");
        }

        public override void Sound()
        {
            Console.WriteLine("dzin dzin");
        }
    }
}
