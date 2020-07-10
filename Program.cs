using System;
using System.Collections.Generic;
using System.IO;
using The_Ark.entities.Natural;
using The_Ark.entities.SpaceShip;
using The_Ark.enums;
using The_Ark.RNG.EntityGenerator;

namespace The_Ark
{
    class Program
    {
        static void Main()
        {
            var p = new Planet("XAEA-12", new List<Enum>()
            {
                //order matters
                TemperatureType.Hot,
                SizeType.SuperTerrestrial,
                AtmosphereType.Thick,
                GravityType.EarthLike,
                WaterResourceType.Trace,
                FloraType.Edible,
                FaunaType.Reptiles,
                CivilizationType.States
            });

            Console.WriteLine(p);
            var r = new RandomEntityGenerator();
            //RandomEntityGenerator r = new RandomEntityGenerator();
            //Console.WriteLine(RandomEntityGenerator.SetsOfValuesOfEnums.ToString());
        }
    }
}
