using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.Model
{
    class CardOfAction
    {
        private string actionName;
        #region Property
        public string ActionName
        {
            get { return actionName; }
            set
            {
                if (value != actionName)
                {
                    actionName = value;
                    OnPropertyChanged("ActionName");
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
