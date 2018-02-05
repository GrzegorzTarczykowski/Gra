using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.View;

namespace Gra.ViewModel
{
    static class ViewModelLocator
    {
        private static MainWindowHandler mainWindowHandler = new MainWindowHandler();
        public static MainWindowHandler MainWindowHandlerProperty
        {
            get { return mainWindowHandler; }
        }

        private static LoginPageHandler loginPageHandler = new LoginPageHandler();
        public static LoginPageHandler LoginPageHandlerProperty
        {
             get { return loginPageHandler; }
        }
    }
}
