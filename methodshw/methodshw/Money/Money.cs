using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Money
{
    internal class Money
    {
        protected double price = 0;
        private double bill;
        private double penny;
        public void Price()
        {
            Console.WriteLine("Введите сумму целой валюты: ");
            bill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите копейки");
            penny = Convert.ToInt32(Console.ReadLine());
            PrintPrice();
        }

        public double Total()
        {
            double price = bill +( penny / 100);
            this.price = (double)price;
            return price;
        }
        public void PrintPrice()
        {
            Console.WriteLine(Total());
        }
    }
}
