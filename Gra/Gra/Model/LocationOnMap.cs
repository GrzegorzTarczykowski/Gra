﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.Model;

namespace Gra.Model
{
    class LocationOnMap : INotifyPropertyChanged
    {
        private int xCoordinate;
        private int yCoordinate;
        private string pathToImage;
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
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
