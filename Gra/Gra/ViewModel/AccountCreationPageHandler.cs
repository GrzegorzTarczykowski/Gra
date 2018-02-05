using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Gra.View;

namespace Gra.ViewModel
{
    class AccountCreationPageHandler
    {
        private ICommand buttonCreateAccountCancel;
        private bool _canExecute;
        public AccountCreationPageHandler()
        {
            _canExecute = true;
        }

        private void buttonCreateAccountCancelAction()
        {
            ViewModelLocator.MainWindowHandlerProperty.SlidedFrame = new LoginPage();
        }

        #region Property
        public ICommand ButtonCreateAccountCancel
        {
            get
            {
                return buttonCreateAccountCancel ?? (buttonCreateAccountCancel = new CommandHandler(() => buttonCreateAccountCancelAction(), _canExecute));
            }
        }
        #endregion
    }
}
