using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.interfaces
{
        public interface IFileService
        {
            public string FileName { get; set; }
            public FileMode FileMode { get; set; }

            void AppendTo<T>() where T : IWritable;
            void AppendTo();
        }
}

