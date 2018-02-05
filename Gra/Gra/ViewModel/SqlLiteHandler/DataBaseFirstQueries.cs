using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.ViewModel.SqlLiteHandler
{
    class DataBaseFirstQueries
    {
        public string checkRepeatedAccountNameToCreateAccount (string ACCOUNTS_TABLE_ACCOUNT_NAME, string DATABASE_ACCOUNTS_TABLE, string TEXTBOX_ACCOUNT_NAME)
        {
            string sqlString = null;
            sqlString = "SELECT " + ACCOUNTS_TABLE_ACCOUNT_NAME + " FROM " + DATABASE_ACCOUNTS_TABLE + " WHERE " + DATABASE_ACCOUNTS_TABLE
                + "." + ACCOUNTS_TABLE_ACCOUNT_NAME + "=" + TEXTBOX_ACCOUNT_NAME + ";";
            return sqlString;
        }
        public string checkAccountNameAndPasswordToEnterGame (string ACCOUNTS_TABLE_ID, string DATABASE_ACCOUNTS_TABLE, string ACCOUNTS_TABLE_ACCOUNT_NAME, string TEXT_BOX_ACCOUNT_NAME, string ACCOUNTS_TABLE_PASSWORD, string TEXTBOX_PASSWORD)
        {
            string sqlString = null;
            sqlString = "SELECT " + ACCOUNTS_TABLE_ID + " FROM " + DATABASE_ACCOUNTS_TABLE + " WHERE " + DATABASE_ACCOUNTS_TABLE
                + "." + ACCOUNTS_TABLE_ACCOUNT_NAME + "='" + TEXT_BOX_ACCOUNT_NAME + "' AND " + DATABASE_ACCOUNTS_TABLE
                + "." + ACCOUNTS_TABLE_PASSWORD + "='" + TEXTBOX_PASSWORD + "';";
            return sqlString;
        }
    }
}
