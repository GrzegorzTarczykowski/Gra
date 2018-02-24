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
        private List<CardOfAction> listOfCardOfAction = new List<CardOfAction>();
        private List<CardOfPerson> listOfCardOfPersons = new List<CardOfPerson>();
        private List<CardOfBuilding> listOfCardOfBuildings = new List<CardOfBuilding>();
        private List<CardOfLocation> listOfCardOfLocatons = new List<CardOfLocation>();
        internal void AddAction(string name)
        {
            CardOfAction action = new CardOfAction();
            action.ActionName = name;
            listOfCardOfAction.Add(action);
        }
        internal void AddPerson(string name, List<CardOfAction> action)
        {
            CardOfPerson person = new CardOfPerson();
            person.PersonName = name;
            foreach (CardOfAction card in action)
            {
                person.ListCardOfAction.Add(card);
            }
            listOfCardOfPersons.Add(person);
        }
        internal void AddBuilding(string name, List<CardOfPerson> persons, List<CardOfAction> action)
        {
            CardOfBuilding building = new CardOfBuilding();
            building.BuildingName = name;
            foreach (CardOfAction card in action)
            {
                building.ListCardOfAction.Add(card);
            }
            foreach (CardOfPerson card in persons)
            {
                building.ListCardOfPerson.Add(card);
            }
            listOfCardOfBuildings.Add(building);
        }
        internal void AddLocation(string name, int xCoordinate, int yCoordinate, List<CardOfBuilding> buildings, List<CardOfPerson> persons, List<CardOfAction> action, string pathToImage)
        {
            CardOfLocation location = new CardOfLocation();
            location.LocationName = name;
            location.XCoordinate = xCoordinate;
            location.YCoordinate = yCoordinate;
            location.PathToImage = pathToImage;
            foreach (CardOfAction card in action)
            {
                location.ListCardOfAction.Add(card);
            }
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
        public List<CardOfAction> ListOfCardOfAction
        {
            get { return listOfCardOfAction; }
        }
        public List<CardOfPerson> ListOfCardOfPersons
        {
            get { return listOfCardOfPersons; }
        }
        public List<CardOfBuilding> ListOfCardOfBuildings
        {
            get { return listOfCardOfBuildings; }
        }
        public List<CardOfLocation> ListOfCardOfLocatons
        {
            get { return listOfCardOfLocatons; }
        }
        #endregion
    }
}
