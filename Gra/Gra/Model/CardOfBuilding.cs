using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfBuilding : INotifyPropertyChanged
    {
        private string buildingName;
        private ObservableCollection<CardOfPerson> listCardOfPerson;
        public CardOfBuilding()
        {
            listCardOfPerson = new ObservableCollection<CardOfPerson>();
        }
        #region Property
        public string BuildingName
        {
            get { return buildingName; }
            set
            {
                if (value != buildingName)
                {
                    buildingName = value;
                    OnPropertyChanged("BuildingName");
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
