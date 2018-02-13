using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class World
    {
        private List<CardOfLocation> listOfCardOfLocatons = new List<CardOfLocation>();
        internal void AddLocation(string name, int xCoordinate, int yCoordinate)
        {
            CardOfLocation loc = new CardOfLocation();
            loc.LocationName = name;
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            listOfCardOfLocatons.Add(loc);
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
    }
}
