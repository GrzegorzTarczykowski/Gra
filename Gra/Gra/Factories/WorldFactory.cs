using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.Model;

namespace Gra.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation("Szare Miasto", 11, 19);
            newWorld.AddLocation("Czarny Staw", 12, 20);
            newWorld.AddLocation("Biała Pustynia", 11, 20);
            return newWorld;
        }
    }
}
