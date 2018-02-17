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
        private ICommand endTheConversationClickCommand;
        private ICommand leaveTheBuildingClickCommand;
        private ICommand hitTheRoadClickCommand;
        private ICommand chosenActionButtonInPersonClickCommand;
        private ICommand chosenActionButtonInBuildingClickCommand;
        private ICommand chosenPersonButtonInBuildingClickCommand;
        private ICommand chosenActionButtonInLocationClickCommand;
        private ICommand chosenPersonButtonInLocationClickCommand;
        private ICommand chosenBuildingButtonInLocationClickCommand;
        private bool _canExecuteEndTheConversationClickCommand;
        private bool _canExecuteLeaveTheBuildingClickCommand;
        private bool _canExecuteHitTheRoadClickCommand;
        private bool _canExecuteChosenActionButtonInPersonClickCommand;
        private bool _canExecuteChosenActionButtonInBuildingClickCommand;
        private bool _canExecuteChosenPersonButtonInBuildingClickCommand;
        private bool _canExecuteChosenActionButtonInLocationClickCommand;
        private bool _canExecuteChosenPersonButtonInLocationClickCommand;
        private bool _canExecuteChosenBuildingButtonInLocationClickCommand;
        private CardOfPerson currentCardOfPerson;
        private CardOfBuilding currentCardOfBuilding;
        private CardOfLocation currentCardOfLocation;
        private World currentWorld;
        public GameSession()
        {
            WorldFactory factory = new WorldFactory();
            currentWorld = factory.CreateWorld();

            _canExecuteEndTheConversationClickCommand = false;
            _canExecuteLeaveTheBuildingClickCommand = false;
            _canExecuteHitTheRoadClickCommand = true;
            _canExecuteChosenActionButtonInPersonClickCommand = false;
            _canExecuteChosenActionButtonInBuildingClickCommand = false;
            _canExecuteChosenPersonButtonInBuildingClickCommand = false;
            _canExecuteChosenActionButtonInLocationClickCommand = false;
            _canExecuteChosenPersonButtonInLocationClickCommand = false;
            _canExecuteChosenBuildingButtonInLocationClickCommand = true;

            currentCardOfLocation = currentWorld.CardOfLocationAt(11, 19);
        }
        private void endTheConversationAction(object parameter)
        {
            CurrentCardOfPerson = null;
        }
        private void leaveTheBuildingAction(object parameter)
        {
            CurrentCardOfBuilding = null;
            _canExecuteLeaveTheBuildingClickCommand = false;
            _canExecuteHitTheRoadClickCommand = true;
            _canExecuteChosenPersonButtonInBuildingClickCommand = false;
            _canExecuteChosenBuildingButtonInLocationClickCommand = true;
            LeaveTheBuildingClickCommand = null;
            HitTheRoadClickCommand = null;
            ChosenPersonButtonInBuildingClickCommand = null;
            ChosenBuildingButtonInLocationClickCommand = null;
        }
        private void hitTheRoadAction(object parameter)
        {
            CurrentCardOfLocation = null;
        }
        private void chosenActionButtonInPersonAction(object parameter)
        {
            
        }
        private void chosenActionButtonInBuildingAction(object parameter)
        {
            
        }
        private void chosenPersonButtonInBuildingAction(object parameter)
        {
            CurrentCardOfPerson = (CardOfPerson)parameter;
        }
        private void chosenActionButtonInLocationAction(object parameter)
        {
            
        }
        private void chosenPersonButtonInLocationAction(object parameter)
        {
             CurrentCardOfPerson = (CardOfPerson)parameter;
        }
        private void chosenBuildingButtonInLocationAction(object parameter)
        {
             CurrentCardOfBuilding = (CardOfBuilding)parameter;
            _canExecuteLeaveTheBuildingClickCommand = true;
            _canExecuteHitTheRoadClickCommand = false;
            _canExecuteChosenPersonButtonInBuildingClickCommand = true;
            _canExecuteChosenBuildingButtonInLocationClickCommand = false;
            LeaveTheBuildingClickCommand = null;
            HitTheRoadClickCommand = null;
            ChosenPersonButtonInBuildingClickCommand = null;
            ChosenBuildingButtonInLocationClickCommand = null;
        }
        #region Property
        public ICommand EndTheConversationClickCommand
        {
            get
            {
                return endTheConversationClickCommand ?? (endTheConversationClickCommand = new CommandHandlerWithParameter(parameter => endTheConversationAction(parameter), _canExecuteEndTheConversationClickCommand));
            }
            set
            {
                if (value != endTheConversationClickCommand)
                {
                    endTheConversationClickCommand = value;
                    OnPropertyChanged("EndTheConversationClickCommand");
                }
            }
        }
        public ICommand LeaveTheBuildingClickCommand
        {
            get
            {
                return leaveTheBuildingClickCommand ?? (leaveTheBuildingClickCommand = new CommandHandlerWithParameter(parameter => leaveTheBuildingAction(parameter), _canExecuteLeaveTheBuildingClickCommand));
            }
            set
            {
                if (value != leaveTheBuildingClickCommand)
                {
                    leaveTheBuildingClickCommand = value;
                    OnPropertyChanged("LeaveTheBuildingClickCommand");
                }
            }
        }
        public ICommand HitTheRoadClickCommand
        {
            get
            {
                return hitTheRoadClickCommand ?? (hitTheRoadClickCommand = new CommandHandlerWithParameter(parameter => hitTheRoadAction(parameter), _canExecuteHitTheRoadClickCommand));
            }
            set
            {
                if (value != hitTheRoadClickCommand)
                {
                    hitTheRoadClickCommand = value;
                    OnPropertyChanged("HitTheRoadClickCommand");
                }
            }
        }
        public ICommand ChosenActionButtonInPersonClickCommand
        {
            get
            {
                return chosenActionButtonInPersonClickCommand ?? (chosenActionButtonInPersonClickCommand = new CommandHandlerWithParameter(parameter => chosenActionButtonInPersonAction(parameter), _canExecuteChosenActionButtonInPersonClickCommand));
            }
            set
            {
                if (value != chosenActionButtonInPersonClickCommand)
                {
                    chosenActionButtonInPersonClickCommand = value;
                    OnPropertyChanged("ChosenActionButtonInPersonClickCommand");
                }
            }
        }
        public ICommand ChosenActionButtonInBuildingClickCommand
        {
            get
            {
                return chosenActionButtonInBuildingClickCommand ?? (chosenActionButtonInBuildingClickCommand = new CommandHandlerWithParameter(parameter => chosenActionButtonInBuildingAction(parameter), _canExecuteChosenActionButtonInBuildingClickCommand));
            }
            set
            {
                if (value != chosenActionButtonInBuildingClickCommand)
                {
                    chosenActionButtonInBuildingClickCommand = value;
                    OnPropertyChanged("ChosenActionButtonInBuildingClickCommand");
                }
            }
        }
        public ICommand ChosenPersonButtonInBuildingClickCommand
        {
            get
            {
                return chosenPersonButtonInBuildingClickCommand ?? (chosenPersonButtonInBuildingClickCommand = new CommandHandlerWithParameter(parameter => chosenPersonButtonInBuildingAction(parameter), _canExecuteChosenPersonButtonInBuildingClickCommand));
            }
            set
            {
                if (value != chosenPersonButtonInBuildingClickCommand)
                {
                    chosenPersonButtonInBuildingClickCommand = value;
                    OnPropertyChanged("ChosenPersonButtonInBuildingClickCommand");
                }
            }
        }
        public ICommand ChosenActionButtonInLocationClickCommand
        {
            get
            {
                return chosenActionButtonInLocationClickCommand ?? (chosenActionButtonInLocationClickCommand = new CommandHandlerWithParameter(parameter => chosenActionButtonInLocationAction(parameter), _canExecuteChosenActionButtonInLocationClickCommand));
            }
            set
            {
                if (value != chosenActionButtonInLocationClickCommand)
                {
                    chosenActionButtonInLocationClickCommand = value;
                    OnPropertyChanged("ChosenActionButtonInLocationClickCommand");
                }
            }
        }
        public ICommand ChosenPersonButtonInLocationClickCommand
        {
            get
            {
                return chosenPersonButtonInLocationClickCommand ?? (chosenPersonButtonInLocationClickCommand = new CommandHandlerWithParameter(parameter => chosenPersonButtonInLocationAction(parameter), _canExecuteChosenPersonButtonInLocationClickCommand));
            }
            set
            {
                if (value != chosenPersonButtonInLocationClickCommand)
                {
                    chosenPersonButtonInLocationClickCommand = value;
                    OnPropertyChanged("ChosenPersonButtonInLocationClickCommand");
                }
            }
        }
        public ICommand ChosenBuildingButtonInLocationClickCommand
        {
            get
            {
                return chosenBuildingButtonInLocationClickCommand ?? (chosenBuildingButtonInLocationClickCommand = new CommandHandlerWithParameter(parameter => chosenBuildingButtonInLocationAction(parameter), _canExecuteChosenBuildingButtonInLocationClickCommand));
            }
            set
            {
                if (value != chosenBuildingButtonInLocationClickCommand)
                {
                    chosenBuildingButtonInLocationClickCommand = value;
                    OnPropertyChanged("ChosenBuildingButtonInLocationClickCommand");
                }
            }
        }
        public CardOfPerson CurrentCardOfPerson
        {
            get { return currentCardOfPerson; }
            set
            {
                if (value != currentCardOfPerson)
                {
                    currentCardOfPerson = value;
                    OnPropertyChanged("CurrentCardOfPerson");
                }
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
