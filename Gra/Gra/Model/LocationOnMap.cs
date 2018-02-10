using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class LocationOnMap : INotifyPropertyChanged
    {
        private int xCoordinate;
        private int yCoordinate;
        private string pathToImage;
        private string nameLocation;
        #region Property
        public string PathToImage
        {
            get { return pathToImage; }
            set
            {
                if(value != pathToImage)
                {
                    pathToImage = value;
                    OnPropertyChanged("PathToImage");
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
