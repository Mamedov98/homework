﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter.interfaces
{
    public interface IDataSerializer
    {
        Iconvert Deserializer(string data);
    }
}
