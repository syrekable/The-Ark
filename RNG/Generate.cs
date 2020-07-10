using System;
using System.Collections.Generic;
using The_Ark.enums;

namespace The_Ark.RNG.EntityGenerator
{
    public partial class RandomEntityGenerator
    {
        private static Random _random = new Random();
        public static List<Enum> Generate() 
        {
            //for now, we don't care about excluding shit
            //let's make it bad
            var properties = new List<Enum>();
            var types = new List<Type>
            {
                typeof(TemperatureType),
                typeof(SizeType),
                typeof(AtmosphereType),
                typeof(WaterResourceType),
                typeof(FloraType),
                typeof(FaunaType),
                typeof(CivilizationType)
            };
            foreach(var t in types)
            {
                properties.Add(DrawSingle(t));
            }
            return properties;
        }

        private static Enum DrawSingle(Type value)
        {
            //draw a random value from the enum and return it
            var values = Enum.GetValues(value);
            return (Enum)values.GetValue(_random.Next(values.Length));
        }
    }
}