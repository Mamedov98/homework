using System.Text;
using System.Threading.Tasks;
using System;
using converter.classes;
using converter.interfaces;
using ConsoleApp21.classes;

Converter? converter = new();
IDataSerializer dataSerializer = new DataSerializer();
IconverterClient converterClient = new FirtsConverterClient(dataSerializer);

Console.Write("Введите конвертируюмую валюту : ");
var money1 = Console.ReadLine();

Console.Write("В какую валюту : ");
var money2 = Console.ReadLine();

Console.Write("Число : ");
var count = int.Parse(Console.ReadLine());


converter = converterClient.GetConverterByMoney(money1, money2, count) as Converter;
Console.WriteLine(converter);

