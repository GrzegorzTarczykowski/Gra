using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class World
    {
        private List<CardOfPerson> listOfCardOfPersons = new List<CardOfPerson>();
        private List<CardOfBuilding> listOfCardOfBuildings = new List<CardOfBuilding>();
        private List<CardOfLocation> listOfCardOfLocatons = new List<CardOfLocation>();
        internal void AddPerson(string name)
        {
            CardOfPerson person = new CardOfPerson();
            person.PersonName = name;
            listOfCardOfPersons.Add(person);
        }
        internal void AddBuilding(string name, List<CardOfPerson> persons)
        {
            CardOfBuilding building = new CardOfBuilding();
            building.BuildingName = name;
            foreach (CardOfPerson card in persons)
            {
                building.ListCardOfPerson.Add(card);
            }
            listOfCardOfBuildings.Add(building);
        }
        internal void AddLocation(string name, int xCoordinate, int yCoordinate, List<CardOfBuilding> buildings, List<CardOfPerson> persons)
        {
            CardOfLocation location = new CardOfLocation();
            location.LocationName = name;
            location.XCoordinate = xCoordinate;
            location.YCoordinate = yCoordinate;
            foreach (CardOfPerson card in persons)
            {
                location.ListCardOfPerson.Add(card);
            }
            foreach (CardOfBuilding card in buildings)
            {
                location.ListCardOfBuilding.Add(card);
            }
            listOfCardOfLocatons.Add(location);
        }
        public CardOfLocation CardOfLocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (CardOfLocation loc in listOfCardOfLocatons)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
        #region Property
        public List<CardOfPerson> ListOfCardOfPersons
        {
            get { return listOfCardOfPersons; }
        }
        public List<CardOfBuilding> ListOfCardOfBuildings
        {
            get { return listOfCardOfBuildings; }
        }
        #endregion
    }
}
