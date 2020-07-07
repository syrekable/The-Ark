using System.Runtime.InteropServices.ComTypes;

namespace The_Ark
{
    public class Planet : Desired
    {
        public SizeType size;
        public AtmosphereType atmosphere;
        public GravityType gravity;
        public TemperatureType temperature;
        public WaterType water;
        public Planet(string name, int size, int atmosphere, int gravity, int temperature, int water)
        {
            this.name = name;
            this.size = (SizeType)size;
            this.atmosphere = (AtmosphereType)atmosphere;
            this.gravity = (GravityType)gravity;
            this.temperature = (TemperatureType)temperature;
            this.water = (WaterType)water;
        }
    }
}