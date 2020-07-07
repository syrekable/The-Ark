namespace The_Ark
{
    public class Planet : Desired
    {
        public SizeType size;
        public AtmosphereType atmosphere;
        public GravityType gravity;
        public TemperatureType temperature;
        public WaterType water;
        public Planet(string name, int size)
        {
            this.name = name;
            this.size = (SizeType) size;
        }
    }
}