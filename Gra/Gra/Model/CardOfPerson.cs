﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfPerson : INotifyPropertyChanged
    {
        private string personName;
        #region Property
        public string PersonName
        {
            get { return personName; }
            set
            {
                if (value != personName)
                {
                    personName = value;
                    OnPropertyChanged("PersonName");
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
