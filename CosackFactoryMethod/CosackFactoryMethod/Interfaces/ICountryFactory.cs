using CosackFactoryMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosackFactoryMethod.Interfaces
{
    internal interface ICountryFactory
    {
        public ICountry CountryProduction<T>(Army army,Cavalry covalry,Artillery artillery) where T : ICountry,new(); 
    }
}
