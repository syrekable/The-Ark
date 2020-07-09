using System;
using System.Collections.Generic;
using System.Linq;
using The_Ark.enums;

namespace The_Ark.RNG.EntityGenerator
{
    public class RandomEntityGenerator
    {
        public List<Enum> EntityParameters { get; private set; }
        private IDictionary<Type, HashSet<Enum>> SetsOfValuesOfEnums; //>this name
        public RandomEntityGenerator()
        {
            var SetsOfValuesOfEnums = GetSetsOfValuesOfEnums();
        }

        private IDictionary<Type, HashSet<Enum>> GetSetsOfValuesOfEnums()
        {
            //populate the dictionary with key being the type of enum,
            //and values being elements of set of enum's values
            //why use a HashSet? 
            //https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.generic.hashset-1.exceptwith
            //deleting elements at ease
            var Dict = new Dictionary<Type, HashSet<Enum>>();
            Dict.Add(typeof(TemperatureType), new HashSet<Enum>());//how to actually feed this enum to HashSet?
            throw new NotImplementedException();
        }
    }
}