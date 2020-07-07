using System.Collections.Generic;

namespace The_Ark
{
    public class Planet : Desired
    {
        public SizeType size;
        public AtmosphereType atmosphere;
        public GravityType gravity;
        public TemperatureType temperature;
        public WaterResourceType water;
        public FloraType flora;
        public FaunaType fauna;
        public CivilizationType civilization;
        public Planet(string name, IDictionary<string,int> parameters)
        {
            this.name = name;
            size = (SizeType)parameters["SizeType"];
            atmosphere = (AtmosphereType)parameters["AtmosphereType"];
            //well, that's ugly af
            if (parameters.ContainsKey("GravityType"))
            {
                gravity = (GravityType)parameters["GravityType"];
            }
            if (parameters.ContainsKey("TemperatureType"))
            {
                temperature = (TemperatureType)parameters["TemperatureType"];
            }
            if (parameters.ContainsKey("WaterResourceType"))
            {
                water = (WaterResourceType)parameters["WaterResourceType"];
            }
            if (parameters.ContainsKey("FloraType"))
            {
                flora = (FloraType)parameters["FloraType"];
            }
            if (parameters.ContainsKey("FaunaType"))
            {
                fauna = (FaunaType)parameters["FaunaType"];
            }
            if (parameters.ContainsKey("CivilizationType"))
            {
                civilization = (CivilizationType)parameters["CivilizationType"];
            }
        }
    }
}