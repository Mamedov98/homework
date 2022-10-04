using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    internal class Trombone : MusicalInstrument
    {
        public override void Desc()
        {
            Console.WriteLine(" европейский духовой амбушюрный инструмент.");
        }

        public override void History()
        {
            Console.WriteLine("История тромбона Появление тромбона относится к XV веку. Принято считать, что непосредственными предшественниками этого инструмента были кулисные трубы, при игре на которых у музыканта была возможность передвигать трубку инструмента, таким образом получая хроматический звукоряд.");
        }

        public override void Show()
        {
            Console.WriteLine("Тромбон");
        }

        public override void Sound()
        {
            Console.WriteLine("ква  квааа квааа");
        }
    }
}
