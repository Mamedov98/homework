using ConsoleApp21.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp21.classes.FileService;

namespace ConsoleApp21.classes
{
    public class FileService : IFileService
    {
        public string FileName { get; set; }
        public FileMode FileMode { get; set; }
        public IWritable ItemToWrite { get; set; }


        public void AppendTo()
        {
            string fileName = $"{ItemToWrite.GetType().Name}.json";

            using FileStream fs = new(fileName, FileMode.OpenOrCreate);
        }

        public void AppendTo<T>() where T : IWritable
        {
            using FileStream fs = new(FileName, FileMode);
            using StreamWriter sw = new(fs);

            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };

            var data = JsonConvert.SerializeObject(ItemToWrite, settings);
            sw.Write(data);

        }
    }
}

