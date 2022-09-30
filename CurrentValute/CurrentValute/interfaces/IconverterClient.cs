using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter.interfaces
{
  public interface IconverterClient
    {
        Iconvert GetConverterByMoney(string convertname1 , string convertname2 , int count);
    }
}
