using CosackFactoryMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod.Interfaces
{
    public interface ICountry
    {
        Army ArmyCount { get; set; }
        Cavalry CavalryCount { get; set; }
        Artillery ArtilleryCount { get; set; }

        public abstract void Characteristics();

        public void Print()
        {
            Console.WriteLine($"Army Count ->{ArmyCount.ArmySize} units");
            Console.WriteLine($"Army Strength->{ArmyCount.HP}");
            Console.WriteLine($"Army Stamina->{ArmyCount.Stamina}");
            Console.WriteLine($"Cavalry Count->{CavalryCount._Cavalry} units");
            Console.WriteLine($"Cavalry Speed->{CavalryCount.CavalrySpeed}");
            Console.WriteLine($"Rate of fire of Artillery->{ArtilleryCount.RateOfFire}");
            Console.WriteLine($"Artillery Power->{ArtilleryCount._Artillery }");

        }


    }
}
