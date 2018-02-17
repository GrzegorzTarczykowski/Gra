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
        private int xCoordinate;
        private int yCoordinate;
        private string locationName;
        private ObservableCollection<CardOfBuilding> listCardOfBuilding;
        private ObservableCollection<CardOfPerson> listCardOfPerson;
        public CardOfLocation()
        {
            listCardOfBuilding = new ObservableCollection<CardOfBuilding>();
            listCardOfPerson = new ObservableCollection<CardOfPerson>();
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
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
