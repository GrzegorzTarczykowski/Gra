using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfLocation : INotifyPropertyChanged
    {
        private string locationName;
        private string pathToImage;
        private int xCoordinate;
        private int yCoordinate;
        private ObservableCollection<CardOfBuilding> listCardOfBuilding;
        private ObservableCollection<CardOfPerson> listCardOfPerson;
        private ObservableCollection<CardOfAction> listCardOfAction;
        public CardOfLocation()
        {
            listCardOfBuilding = new ObservableCollection<CardOfBuilding>();
            listCardOfPerson = new ObservableCollection<CardOfPerson>();
            listCardOfAction = new ObservableCollection<CardOfAction>();
        }
        #region Property
        public string LocationName
        {
            get { return locationName; }
            set
            {
                if (value != locationName)
                {
                    locationName = value;
                    OnPropertyChanged("LocationName");
                }
            }
        }
        public string PathToImage
        {
            get { return pathToImage; }
            set
            {
                if (value != pathToImage)
                {
                    pathToImage = value;
                    OnPropertyChanged("PathToImage");
                }
            }
        }
        public int XCoordinate
        {
            get { return xCoordinate; }
            set
            {
                if (value != xCoordinate)
                {
                    xCoordinate = value;
                    OnPropertyChanged("XCoordinate");
                }
            }
        }
        public int YCoordinate
        {
            get { return yCoordinate; }
            set
            {
                if (value != yCoordinate)
                {
                    yCoordinate = value;
                    OnPropertyChanged("YCoordinate");
                }
            }
        }
        public ObservableCollection<CardOfBuilding> ListCardOfBuilding
        {
            get { return listCardOfBuilding; }
            set
            {
                if (value != listCardOfBuilding)
                {
                    listCardOfBuilding = value;
                    OnPropertyChanged("ListCardOfBuilding");
                }
            }
        }
        public ObservableCollection<CardOfPerson> ListCardOfPerson
        {
            get { return listCardOfPerson; }
            set
            {
                if (value != listCardOfPerson)
                {
                    listCardOfPerson = value;
                    OnPropertyChanged("ListCardOfPerson");
                }
            }
        }
        public ObservableCollection<CardOfAction> ListCardOfAction
        {
            get { return listCardOfAction; }
            set
            {
                if (value != listCardOfAction)
                {
                    listCardOfAction = value;
                    OnPropertyChanged("ListCardOfAction");
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
