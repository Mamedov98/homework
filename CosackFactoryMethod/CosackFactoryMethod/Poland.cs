using CosackFactoryMethod.Classes;
using CosackFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod
{
    public class Poland : ICountry 
    {
        public Army? ArmyCount { get; set; }
        public Cavalry? CavalryCount { get; set; }

        public Artillery? ArtilleryCount { get; set; }

        public void Characteristics()
        {
            Console.WriteLine("Poland");
            ArmyCount.HP = "200 HP";
            ArmyCount.Stamina = "400%";
            ArmyCount.ArmySize = 8000;
            CavalryCount._Cavalry = 1500;
            CavalryCount.CavalrySpeed = "43 km/h";
            ArtilleryCount._Artillery = 40;
            ArtilleryCount.RateOfFire = "15 shots per minute";
            Console.WriteLine("Have 18th century");
        }
    }
}
