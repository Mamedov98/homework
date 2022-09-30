using converter.classes;
using converter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp21.classes
{
    internal class DataSerializer : IDataSerializer
    {
        public Iconvert Deserializer(string data)
        {
            Iconvert? result = JsonSerializer.Deserialize<Converter>(data);
            return result ?? throw new NullReferenceException();
        }
    }
}
