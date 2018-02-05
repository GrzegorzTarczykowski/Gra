using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Gra.View;
using Gra.ViewModel.SqlLiteHandler;
using System.Data.SQLite;
using System.Windows;
using System.ComponentModel;

namespace Gra.ViewModel
{
    class AccountCreationPageHandler : INotifyPropertyChanged
    {
        private string textBoxCharacterName = "";
        private string textBoxLineage = "";
        private string textBoxAccountName = "";
        private string textBoxPassword = "";
        private string textBoxPasswordRepeat = "";
        private ICommand buttonCreateAccountCancel;
        private ICommand buttonCreateAccountAccept;
        private bool _canExecute;
        public AccountCreationPageHandler()
        {
            _canExecute = true;
        }

        public string selectInDatabase (string _commandText)
        {
            string resultSelect = "0";
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            commander.CommandText = _commandText;
            SQLiteDataReader cursor = commander.ExecuteReader();
            while (cursor.Read())
            {
                resultSelect = cursor.GetValue(0).ToString();
            }
            connector.disConnect();
            return resultSelect;
        }
        public void insertToDatabase (string _commandText)
        {
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            commander.CommandText = _commandText;
            commander.ExecuteNonQuery();
            connector.disConnect();
        }

        private void buttonCreateAccountCancelAction()
        {
            ViewModelLocator.MainWindowHandlerProperty.SlidedFrame = new LoginPage();
        }
        private void buttonCreateAccountAcceptAction()
        {
            string repeatedAccountNameId = "0";
            string repeatedCharacterNameId = "0";
            string repeatedLineageId = "0";
            string commandText;
            DataBaseFirstQueries dataBaseFirstQueries = new DataBaseFirstQueries();
            commandText = dataBaseFirstQueries.checkRepeatedAccountNameToCreateAccount(DescriptionDataBaseFirst.ACCOUNTS_TABLE_ID, DescriptionDataBaseFirst.ACCOUNTS_TABLE_ACCOUNT_NAME, DescriptionDataBaseFirst.DATABASE_ACCOUNTS_TABLE, textBoxAccountName);
            repeatedAccountNameId = selectInDatabase(commandText);
            commandText = dataBaseFirstQueries.checkRepeatedCharacterNameToCreateAccount(DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_ID, DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME, DescriptionDataBaseFirst.DATABASE_PLAYERS_CHARACTERS_TABLE, textBoxCharacterName);
            repeatedCharacterNameId = selectInDatabase(commandText);
            commandText = dataBaseFirstQueries.checkRepeatedLineageToCreateAccount(DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_ID, DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_LINEAGE, DescriptionDataBaseFirst.DATABASE_PLAYERS_CHARACTERS_TABLE, textBoxLineage);
            repeatedLineageId = selectInDatabase(commandText);
            if (Convert.ToInt32(repeatedAccountNameId) == 0)
            {
                if(Convert.ToInt32(repeatedCharacterNameId) == 0)
                {
                    if(Convert.ToInt32(repeatedLineageId) == 0)
                    {
                        commandText = dataBaseFirstQueries.insertNewAccoutToAccountsTable(DescriptionDataBaseFirst.DATABASE_ACCOUNTS_TABLE, DescriptionDataBaseFirst.ACCOUNTS_TABLE_ACCOUNT_NAME, DescriptionDataBaseFirst.ACCOUNTS_TABLE_PASSWORD, textBoxAccountName, textBoxPassword);
                        insertToDatabase(commandText);
                        commandText = dataBaseFirstQueries.checkRepeatedAccountNameToCreateAccount(DescriptionDataBaseFirst.ACCOUNTS_TABLE_ID, DescriptionDataBaseFirst.ACCOUNTS_TABLE_ACCOUNT_NAME, DescriptionDataBaseFirst.DATABASE_ACCOUNTS_TABLE, textBoxAccountName);
                        string textIdAccount = selectInDatabase(commandText);
                        commandText = dataBaseFirstQueries.insertNewCharacterToPlayersCharactersTable(DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_ID_ACCOUNT, DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME, DescriptionDataBaseFirst.PLAYERS_CHARACTERS_TABLE_LINEAGE, DescriptionDataBaseFirst.DATABASE_PLAYERS_CHARACTERS_TABLE, textIdAccount, textBoxCharacterName, textBoxLineage);
                        insertToDatabase(commandText);
                    }
                    else
                    {
                        MessageBox.Show("Lineage already exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Character name already exist!");
                }
            }
            else
            {
                MessageBox.Show("Account name already exist!");
            }
        }

        #region Property
        public string TextBoxCharacterName
        {
            get { return textBoxCharacterName; }
            set
            {
                if (value != textBoxCharacterName)
                {
                    textBoxCharacterName = value;
                    OnPropertyChanged("TextBoxCharacterName");
                }
            }
        }
        public string TextBoxLineage
        {
            get { return textBoxLineage; }
            set
            {
                if (value != textBoxLineage)
                {
                    textBoxLineage = value;
                    OnPropertyChanged("TextBoxLineage");
                }
            }
        }
        public string TextBoxAccountName
        {
            get { return textBoxAccountName; }
            set
            {
                if (value != textBoxAccountName)
                {
                    textBoxAccountName = value;
                    OnPropertyChanged("TextBoxAccountName");
                }
            }
        }
        public string TextBoxPassword
        {
            get { return textBoxPassword; }
            set
            {
                if (value != textBoxPassword)
                {
                    textBoxPassword = value;
                    OnPropertyChanged("TextBoxPassword");
                }
            }
        }
        public string TextBoxPasswordRepeat
        {
            get { return textBoxPasswordRepeat; }
            set
            {
                if ( value != textBoxPasswordRepeat)
                {
                    textBoxPasswordRepeat = value;
                    OnPropertyChanged("TextBoxPasswordRepeat");
                }
            }
        }
        public ICommand ButtonCreateAccountCancel
        {
            get
            {
                return buttonCreateAccountCancel ?? (buttonCreateAccountCancel = new CommandHandler(() => buttonCreateAccountCancelAction(), _canExecute));
            }
        }
        public ICommand ButtonCreateAccountAccept
        {
            get
            {
                return buttonCreateAccountAccept ?? (buttonCreateAccountAccept = new CommandHandler(() => buttonCreateAccountAcceptAction(), _canExecute));
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
