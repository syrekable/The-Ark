using System;
using System.Collections.Generic;
using System.Linq;
using The_Ark.enums;

namespace The_Ark.RNG.EntityGenerator
{
    public class RandomEntityGenerator
    {
        public List<Enum> EntityParameters { get; private set; }
        private IDictionary<Type, List<Enum>> SetsOfValuesOfEnums; //>this name
        public RandomEntityGenerator()
        {
            var SetsOfValuesOfEnums = GetSetsOfValuesOfEnums();
        }

        private IDictionary<Type, List<Type>> GetSetsOfValuesOfEnums()
        {
            //populate the dictionary with key being the type of enum,
            //and values being elements of set of enum's values
            var Dict = new Dictionary<Type, List<Enum>>();//kurwa listê enumów chcê
            Dict.Add(typeof(TemperatureType), Enum.GetValues(typeof(TemperatureType)).Cast<TemperatureType>().ToList());//co ty pierdolisz, przecie¿ List<T> dziedziczy z IEnumerable
            throw new NotImplementedException();
        }
    }
}