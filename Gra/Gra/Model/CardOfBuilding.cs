using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfBuilding : INotifyPropertyChanged
    {
        private string buildingName;
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
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
