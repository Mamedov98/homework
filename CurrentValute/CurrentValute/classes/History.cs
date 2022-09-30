using ConsoleApp21.interfaces;
using converter.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.classes
{
        public class History : IWritable
        {
            public Converter? ConvertMoney { get; set; }
            public DateTime Date { get; set; }
        }

}
