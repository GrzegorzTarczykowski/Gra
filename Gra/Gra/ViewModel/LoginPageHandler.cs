using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Gra.View;
using System.ComponentModel;
using Gra.ViewModel.SqlLiteHandler;
using System.Data.SQLite;

namespace Gra.ViewModel
{
    class LoginPageHandler : INotifyPropertyChanged
    {
        private ICommand buttonCreateAccountClickCommand;
        private ICommand buttonEnterGameClickCommand;
        private bool _canExecute;
        private string textBoxAccountName;
        private string textBoxPassword = "";
        private string maskedPassword = "";
        public delegate void MyEventHandler (object o, EventArgs e);
        public event MyEventHandler ClickedButtonEnterGame;

        public LoginPageHandler()
        {
            _canExecute = true;
        }

        protected virtual void OnClickedButtonEnterGame()
        {
            if(ClickedButtonEnterGame != null)
            {
                ClickedButtonEnterGame(this, EventArgs.Empty);
            }
        }

        private void buttonCreateAccountAction()
        {
            ViewModelLocator.MainWindowHandlerProperty.SlidedFrame = new AccountCreationPage();
        }

        private void buttonEnterGameAction()
        {
            string accessedOnAccountId = "0";
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            DataBaseFirstQueries dataBaseFirstQueries = new DataBaseFirstQueries();
            commander.CommandText = dataBaseFirstQueries.checkAccountNameAndPasswordToEnterGame(DescriptionDataBaseFirst.ACCOUNTS_TABLE_ID, DescriptionDataBaseFirst.DATABASE_ACCOUNTS_TABLE, DescriptionDataBaseFirst.ACCOUNTS_TABLE_ACCOUNT_NAME, TextBoxAccountName, DescriptionDataBaseFirst.ACCOUNTS_TABLE_PASSWORD, textBoxPassword);
            SQLiteDataReader cursor = commander.ExecuteReader();
            while (cursor.Read())
            {
                accessedOnAccountId = cursor.GetValue(0).ToString();
            }
            connector.disConnect();
            if(Convert.ToInt32(accessedOnAccountId) == 1)
            {
                OnClickedButtonEnterGame();
            }
        }

        private string maskingPassword(ref string _textBoxPassword, string _maskedPassword)
        {
            if(_maskedPassword.Length == _textBoxPassword.Length + 1)
            {
                _textBoxPassword += _maskedPassword[_maskedPassword.Length - 1];
            }
            else if (_maskedPassword.Length + 1 == _textBoxPassword.Length)
            {
                _textBoxPassword = _textBoxPassword.Remove(_textBoxPassword.Length - 1);
            }
            _maskedPassword = "";
            if (_textBoxPassword != null)
            {
                for (int i = 0; i < _textBoxPassword.Length; i++)
                {
                    _maskedPassword += "*";
                }
            }
            return _maskedPassword;
        }

        #region Property
        public ICommand ButtonCreateAccountClickCommand
        {
            get
            {
                return buttonCreateAccountClickCommand ?? (buttonCreateAccountClickCommand = new CommandHandler(() => buttonCreateAccountAction(), _canExecute));
            }
        }
        public ICommand ButtonEnterGameClickCommand
        {
            get
            {
                return buttonEnterGameClickCommand ?? (buttonEnterGameClickCommand = new CommandHandler(() => buttonEnterGameAction(), _canExecute));
            }
        }
        public string TextBoxAccountName
        {
            get { return textBoxAccountName; }
            set
            {
                if(value != textBoxAccountName)
                {
                    textBoxAccountName = value;
                    OnPropertyChanged("TextBoxAccountName");
                }
            }
        }
        public string TextBoxPassword
        {
            get { return maskingPassword(ref textBoxPassword, maskedPassword); }
            set
            {
                if (value != maskedPassword)
                {
                    maskedPassword = value;
                    OnPropertyChanged("TextBoxPassword");
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
