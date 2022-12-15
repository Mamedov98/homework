using CosackFactoryMethod.Classes;
using CosackFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod
{
    public class England : ICountry
    {

        public Army? ArmyCount { get; set; }
        public Cavalry? CavalryCount { get; set; }

        public Artillery? ArtilleryCount { get; set; }

        public void Characteristics()
        {
            Console.WriteLine("England");
            ArmyCount.HP = "240 HP";
            ArmyCount.Stamina = "300%";
            ArmyCount.ArmySize = 20000;
            CavalryCount._Cavalry = 1500;
            CavalryCount.CavalrySpeed = "40 km/h";
            ArtilleryCount._Artillery = 50;
            ArtilleryCount.RateOfFire = "25 shots per minute";
            Console.WriteLine("Have 18th century");
        }

    }
}
