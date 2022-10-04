using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Musical_Instrument
{
    abstract public class MusicalInstrument
    {
        abstract public void Sound();
        abstract public void Show();
        abstract public void Desc();
        abstract public void History();
    }
}
