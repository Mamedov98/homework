using converter.interfaces;
using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConsoleApp21.classes;

namespace converter.classes
{
    public class FirtsConverterClient : IconverterClient
    {
        public const string _key = "596e298OGcvGKYgiweUt3YMSuyFVWZp6";
        public const string _url = @"https://api.apilayer.com/exchangerates_data/convert?";
        public IDataSerializer dataSerializer;
        readonly WebClient? client = new();
        public FirtsConverterClient(IDataSerializer serializer)
        {
            this.dataSerializer = serializer;
        }
        public Iconvert GetConverterByMoney(string convertname1, string convertname2, int count)
        {
            string link = ($"{_url}apikey={_key}&to={convertname1}&from={convertname2}&amount={count}");
            string? result =  client?.DownloadString(link);
            Iconvert returnedConvert;

            if (result != null)
            {
                returnedConvert = dataSerializer.Deserializer(result);

                FileService fileService = new()
                {
                    FileName = "data1.json",
                    FileMode = FileMode.Append,
                    ItemToWrite = new History()
                    {
                        Date = DateTime.Now,
                        ConvertMoney = returnedConvert as Converter
                    }
                };

                fileService.AppendTo<History>();

                return returnedConvert;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
