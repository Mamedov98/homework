using CosackFactoryMethod.Classes;
using CosackFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod
{
    public class Ukraine : ICountry
    {
        public Army? ArmyCount { get; set; }
        public Cavalry? CavalryCount { get; set; }

        public Artillery? ArtilleryCount { get; set; }

        public void Characteristics()
        {
            Console.WriteLine("Ukraine");
            ArmyCount.HP = "400 HP";
            ArmyCount.Stamina = "400%";
            ArmyCount.ArmySize = 10000;
            CavalryCount._Cavalry = 1500;
            CavalryCount.CavalrySpeed = "70 km/h";
            ArtilleryCount._Artillery = 10;
            ArtilleryCount.RateOfFire = "10 shots per minute";
            Console.WriteLine("no 18th century");
        }
    }
}
