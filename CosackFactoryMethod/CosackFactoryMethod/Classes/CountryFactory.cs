using CosackFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod.Classes
{
    internal class CountryFactory : ICountryFactory
    {
        public ICountry CountryProduction<T>(Army army, Cavalry cavalry, Artillery artillery) where T : ICountry, new()
        {
            var a = Activator.CreateInstance<T>(); 
            a.ArmyCount = army;
            a.CavalryCount = cavalry;
            a.ArtilleryCount = artillery;
            return a;
        }
    }
}
