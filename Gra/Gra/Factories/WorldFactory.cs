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
            newWorld.ListOfCardOfPersons.Clear();
            newWorld.AddPerson("Zarzadca Przytulku");
            newWorld.AddPerson("Bezdomny");
            newWorld.AddBuilding("Przytulek", newWorld.ListOfCardOfPersons);
            newWorld.ListOfCardOfPersons.Clear();
            newWorld.AddPerson("Gospodarz");
            newWorld.AddPerson("Biesiadnik");
            newWorld.AddBuilding("Gospoda", newWorld.ListOfCardOfPersons);
            newWorld.ListOfCardOfPersons.Clear();
            newWorld.AddPerson("Straznik");
            newWorld.AddPerson("Zebrak");
            newWorld.AddLocation("Szare Miasto", 11, 19, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons);
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Chata", newWorld.ListOfCardOfPersons);
            newWorld.AddBuilding("Schowek", newWorld.ListOfCardOfPersons);
            newWorld.AddLocation("Czarny Staw", 12, 20, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons);
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Barak", newWorld.ListOfCardOfPersons);
            newWorld.AddBuilding("Altana", newWorld.ListOfCardOfPersons);
            newWorld.AddLocation("Biała Pustynia", 11, 20, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons);
            return newWorld;
        }
    }
}
