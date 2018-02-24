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
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Zebrz o jedzenie");
            newWorld.AddAction("Pros o miejsce do spania");
            newWorld.AddPerson("Zarzadca Przytulku", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Pytaj co robi");
            newWorld.AddAction("Daj mu kromke");
            newWorld.AddPerson("Bezdomny", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Ogladaj lokal");
            newWorld.AddBuilding("Przytulek", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfPersons.Clear();
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Kup obiad");
            newWorld.AddPerson("Gospodarz", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Spiewaj wspolnie");
            newWorld.AddPerson("Biesiadnik", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Ogladaj gospode");
            newWorld.AddBuilding("Gospoda", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfPersons.Clear();
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Pytaj o droge");
            newWorld.AddPerson("Straznik", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Pytaj co robi na ulicy");
            newWorld.AddPerson("Zebrak", newWorld.ListOfCardOfAction);
            newWorld.ListOfCardOfAction.Clear();
            newWorld.AddAction("Spaceruj po miescie");
            newWorld.AddLocation("Szare Miasto", 11, 19, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction, "/Gra;component/Images/grayTown.png");
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Chata", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.AddBuilding("Schowek", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.AddLocation("Czarny Staw", 12, 20, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction, "/Gra;component/Images/grass.png");
            newWorld.ListOfCardOfBuildings.Clear();
            newWorld.AddBuilding("Barak", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.AddBuilding("Altana", newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction);
            newWorld.AddLocation("Biała Pustynia", 11, 20, newWorld.ListOfCardOfBuildings, newWorld.ListOfCardOfPersons, newWorld.ListOfCardOfAction, "/Gra;component/Images/grass.png");
            return newWorld;
        }
    }
}
