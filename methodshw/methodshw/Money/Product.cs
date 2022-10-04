using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Money
{
    internal class Product : Money
    {
        private const string Value = "1 :Уменьшить цену  \n2 :Увеличить  цену";
        private double change;
        public void SetChange()
        {
            if (price == 0) 
            {
                Price();
            }
            Console.WriteLine("На какую сумму хотите изменить цену?: ");
            Console.WriteLine("Введите сумму целой валюты(цена товара)"); 
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму копеек");
            int second = Convert.ToInt32(Console.ReadLine());
            this.change = first + second / 100d;
        }
        public void Change()
        {
            Console.WriteLine(Value);
            int choice = Convert.ToInt32(Console.ReadLine());
            SetChange();
            if (choice == 1)
            {
               
                price -= change;
                Console.WriteLine("Цена данного товара понизилась до " + price + "AZN");
            }
            else if (choice == 2)
            {
               
                price += change; 
                Console.WriteLine("Цена данного товара повысилась до " + price + "AZN"); 
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine($"Новая цена товара  {price} + AZN");
        }
    }
}
