using System;
using System.Collections.Generic;
using System.Linq;
using The_Ark.enums;

namespace The_Ark.RNG.EntityGenerator
{
    public static partial class RandomEntityGenerator
    {
        public static List<Enum> Generate() 
        {
            var properties = new List<Enum>();

            var temperature = DrawSingleProperty(typeof(TemperatureType), null);
            var size = DrawSingleProperty(typeof(SizeType), null);
            var gravity = DrawSingleProperty(typeof(GravityType), size);
            var atmosphere = DrawSingleProperty(typeof(AtmosphereType), gravity);
            var water = DrawSingleProperty(typeof(WaterResourceType), temperature);
            //flora, fauna and civilization values, which could occur on planet with given temperature and water resource
            var lifeSupporters = _affectedProperties[temperature].Intersect(_affectedProperties[water]).ToList();
            var flora = DrawSingleProperty(typeof(FloraType), lifeSupporters);
            var fauna = DrawSingleProperty(typeof(FaunaType), lifeSupporters);
            var civ = DrawSingleProperty(typeof(CivilizationType), lifeSupporters);
            properties.Add(temperature);
            properties.Add(size);
            properties.Add(gravity);
            properties.Add(atmosphere);
            properties.Add(water);
            properties.Add(flora);
            properties.Add(fauna);
            properties.Add(civ);
            return properties;
        }

        private static Random _random = new Random();
        private static Enum DrawSingleProperty(Type type, Enum? dependantOn)
        {
            //returns a random value from the enum's range
            //TODO: maybe a random list element? XD
            //src of this crap: https://stackoverflow.com/a/27744237/12938809

            var values = Enum.GetValues(type).Cast<Enum>().ToList();
            //the intersection of Enum's values with the affected properties gives us a neat range
            var range = dependantOn != null ? _affectedProperties[dependantOn].Intersect(values).ToArray(): values.ToArray();
            //pick a random number r from 0 to range.Length, take the item on index r, cast to enum, return
            var value = (Enum)range.GetValue(_random.Next(range.Length));
            return value;
        }

        private static Enum DrawSingleProperty(Type type, List<Enum> intersectionOfDependency)
        {
            var values = Enum.GetValues(type).Cast<Enum>().ToList();
            //the range is given by intersection of intersection of two enums and the values of dependant value
            var range = values.Intersect(intersectionOfDependency).ToArray();
            var value = (Enum)range.GetValue(_random.Next(range.Length));
            return value;
        }

        private static List<Enum> GetAvailableProperties(Enum affectingValue, Type affectedType)
        {
            //returns a list of properties from which the generator may draw
            var values = _affectedProperties[affectingValue];
            var available = new List<Enum>();
            foreach (var v in values) 
            {
                //how to check if `v` is of the type `affectedType`?
                /*
                if (v is affectedType)
                {

                }
                */
            }
            throw new NotImplementedException();
        }
    }
}