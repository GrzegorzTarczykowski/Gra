using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfPerson : INotifyPropertyChanged
    {
        private string personName;
        private ObservableCollection<CardOfAction> listCardOfAction;
        public CardOfPerson()
        {
            listCardOfAction = new ObservableCollection<CardOfAction>();
        }
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
