using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Gra;

namespace Gra.ViewModel
{
    class MainWindowHandler : INotifyPropertyChanged
    {
        private Page slidedFrame;
        
        public Page SlidedFrame
        {
            get { return slidedFrame; }
            set
            {
                if (value != slidedFrame)
                {
                    slidedFrame = value;
                    OnPropertyChanged("SlidedFrame");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
