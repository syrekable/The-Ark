using System;
using System.Collections.Generic;
using System.IO;
using The_Ark.entities.Natural;
using The_Ark.RNG.EntityGenerator;

namespace The_Ark
{
    class Program
    {
        static void Main()
        {
            for(var i=0; i<20; i++)
            {
                Planet p = new Planet($"Planet {i}", RandomEntityGenerator.Generate());
                Console.WriteLine(p);
            }
        }
    }
}
