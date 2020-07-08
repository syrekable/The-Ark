using System;
using System.Collections.Generic;
using System.IO;
using The_Ark.entities.Natural;
using The_Ark.entities.SpaceShip;

namespace The_Ark
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Planet("Testowa Planeta", new List<Enum>()
            {
                CivilizationType.States,
                FloraType.Edible,
                FaunaType.Reptiles,
                AtmosphereType.Thick,
                GravityType.EarthLike,
                SizeType.SuperTerrestrial,
                TemperatureType.Hot
            });
            
            //Zwraca wartosc enuma o danym typie
            //var x = p.GetParameterValue(typeof(FloraType));
            Console.WriteLine(p);

            Console.WriteLine("Howdy, what's your ship called?");
            var vesselName = Console.ReadLine();
            var vessel = new SpaceShip(vesselName);
            Console.WriteLine(vessel);
        }
    }
}
