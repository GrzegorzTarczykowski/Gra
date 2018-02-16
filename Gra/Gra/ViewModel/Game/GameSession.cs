using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.Model;
using Gra.Factories;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;

namespace Gra.ViewModel.Game
{
    class GameSession : INotifyPropertyChanged
    {
        private ICommand chosenBuildingButtonClickCommand;
        private CardOfBuilding currentCardOfBuilding;
        private CardOfLocation currentCardOfLocation;
        private World currentWorld;
        public GameSession()
        {
            WorldFactory factory = new WorldFactory();
            currentWorld = factory.CreateWorld();

            currentCardOfLocation = currentWorld.CardOfLocationAt(11, 19);
            currentCardOfBuilding = currentCardOfLocation.ListCardOfBuilding[0];
        }
        private void chosenBuildingButtonAction(object parameter)
        {
            CurrentCardOfBuilding = (CardOfBuilding)parameter;
        }
        #region Property
        public ICommand ChosenBuildingButtonClickCommand
        {
            get
            {
                return chosenBuildingButtonClickCommand ?? (chosenBuildingButtonClickCommand = new CommandHandlerWithParameter(parameter => chosenBuildingButtonAction(parameter), true));
            }
        }
        public CardOfBuilding CurrentCardOfBuilding
        {
            get { return currentCardOfBuilding; }
            set
            {
                if (value != currentCardOfBuilding)
                {
                    currentCardOfBuilding = value;
                    OnPropertyChanged("CurrentCardOfBuilding");
                }
            }
        }
        public CardOfLocation CurrentCardOfLocation
        {
            get { return currentCardOfLocation; }
            set
            {
                if (value != currentCardOfLocation)
                {
                    currentCardOfLocation = value;
                    OnPropertyChanged("CurrentCardOfLocation");
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
                    OnPropertyChanged("CurrentWorld");
                }
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
