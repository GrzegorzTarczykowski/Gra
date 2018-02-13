using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.Model;
using Gra.Factories;

namespace Gra.ViewModel.Game
{
    class GameSession
    {
        private CardOfLocation currentCardOfLocation;
        private World currentWorld;
        public GameSession()
        {
            WorldFactory factory = new WorldFactory();
            currentWorld = factory.CreateWorld();

            currentCardOfLocation = currentWorld.CardOfLocationAt(11, 19);
        }
        #region Property
        public CardOfLocation CurrentCardOfLocation
        {
            get { return currentCardOfLocation; }
            set
            {
                if (value != currentCardOfLocation)
                {
                    currentCardOfLocation = value;
                    //OnPropertyChanged("CurrentCardOfLocation");
                }
            }
        }
        public World CurrentWorld
        {
            get { return currentWorld; }
            set
            {
                if (value != currentWorld)
                {
                    currentWorld = value;
                    //OnPropertyChanged("CurrentWorld");
                }
            }
        }
        #endregion
    }
}
