using CosackFactoryMethod.Classes;
using CosackFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod
{
    public class Turkey : ICountry
    {
        public Army? ArmyCount { get; set; }
        public Cavalry? CavalryCount { get; set; }

        public Artillery? ArtilleryCount { get; set; }

        public void Characteristics()
        {
            Console.WriteLine("Turkiye"); 
            ArmyCount.HP = "200 HP"; 
            ArmyCount.Stamina = "300%";
            ArmyCount.ArmySize = 10000;
            CavalryCount._Cavalry = 3000;
            CavalryCount.CavalrySpeed = "55 km/h";
            ArtilleryCount._Artillery = 12;
            ArtilleryCount.RateOfFire = "15 shots per minute";
            Console.WriteLine("no 18th century");
        }


    }
}
