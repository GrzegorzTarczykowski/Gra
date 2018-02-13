using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Gra.ViewModel;
using System.ComponentModel;
using System.Windows.Controls;
using Gra.View;

namespace Gra.ViewModel.PlaygroundHandler
{
    class MainPlaygroundPageHandler : INotifyPropertyChanged
    {
        private Page frameMap;
        private Page frameCharacterPlace;
        private Page frameActionPlace;
        public MainPlaygroundPageHandler()
        {
            ViewModelLocator.LoginPageHandlerProperty.ClickedButtonEnterGame += OnClickedButtonEnterGame;
            frameMap = new MapPage();
            frameActionPlace = new ActionPlacePage();
        }

        private void OnClickedButtonEnterGame(object o, AccountInformationEventArgs e)
        {
            MessageBox.Show(e.accessedOnAccountId);            
        }

        #region Property
        public Page FrameMap
        {
            get { return frameMap; }
            set
            {
                if (value != frameMap)
                {
                    frameMap = value;
                    OnPropertyChanged("FrameMap");
                }
            }
        }
        public Page FrameCharacterPlace
        {
            get { return frameCharacterPlace; }
            set
            {
                if (value != frameCharacterPlace)
                {
                    frameCharacterPlace = value;
                    OnPropertyChanged("FrameCharacterPlace");
                }
            }
        }
        public Page FrameActionPlace
        {
            get { return frameActionPlace; }
            set
            {
                if (value != frameActionPlace)
                {
                    frameActionPlace = value;
                    OnPropertyChanged("FrameActionPlace");
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
