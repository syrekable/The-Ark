using System;

namespace The_Ark
{
    class Program
    {
        static void Main(string[] args)
        {
            string vesselName;
            SpaceShip vessel;

            Console.WriteLine("Howdy, what's your ship called?");
            vesselName = Console.ReadLine();
            vessel = new SpaceShip(vesselName);
            Console.WriteLine(vessel);
        }
    }
}
