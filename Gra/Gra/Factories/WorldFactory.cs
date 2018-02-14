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
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Przytulek");
            newWorld.AddBuilding("Gospoda");
            newWorld.AddLocation("Szare Miasto", 11, 19, newWorld.ListOfCardOfBuildings);
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Chata");
            newWorld.AddBuilding("Schowek");
            newWorld.AddLocation("Czarny Staw", 12, 20, newWorld.ListOfCardOfBuildings);
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Barak");
            newWorld.AddBuilding("Altana");
            newWorld.AddLocation("Biała Pustynia", 11, 20, newWorld.ListOfCardOfBuildings);
            return newWorld;
        }
    }
}
