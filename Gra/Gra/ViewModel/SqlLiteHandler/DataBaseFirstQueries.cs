using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.ViewModel.SqlLiteHandler
{
    class DataBaseFirstQueries
    {
        public string checkRepeatedAccountNameToCreateAccount (string ACCOUNTS_TABLE_ID, string ACCOUNTS_TABLE_ACCOUNT_NAME, string DATABASE_ACCOUNTS_TABLE, string TEXTBOX_ACCOUNT_NAME)
        {
            string sqlString = null;
            sqlString = "SELECT " + ACCOUNTS_TABLE_ID + " FROM " + DATABASE_ACCOUNTS_TABLE + " WHERE " + DATABASE_ACCOUNTS_TABLE
                + "." + ACCOUNTS_TABLE_ACCOUNT_NAME + "='" + TEXTBOX_ACCOUNT_NAME + "';";
            return sqlString;
        }
        public string checkRepeatedCharacterNameToCreateAccount(string PLAYERS_CHARACTERS_TABLE_ID, string PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME, string DATABASE_PLAYERS_CHARACTERS_TABLE, string TEXTBOX_CHARACTER_NAME)
        {
            string sqlString = null;
            sqlString = "SELECT " + PLAYERS_CHARACTERS_TABLE_ID + " FROM " + DATABASE_PLAYERS_CHARACTERS_TABLE + " WHERE " + DATABASE_PLAYERS_CHARACTERS_TABLE
                + "." + PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME + "='" + TEXTBOX_CHARACTER_NAME + "';";
            return sqlString;
        }
        public string checkRepeatedLineageToCreateAccount(string PLAYERS_CHARACTERS_TABLE_ID, string PLAYERS_CHARACTERS_TABLE_LINEAGE, string DATABASE_PLAYERS_CHARACTERS_TABLE, string TEXTBOX_LINEAGE)
        {
            string sqlString = null;
            sqlString = "SELECT " + PLAYERS_CHARACTERS_TABLE_ID + " FROM " + DATABASE_PLAYERS_CHARACTERS_TABLE + " WHERE " + DATABASE_PLAYERS_CHARACTERS_TABLE
                + "." + PLAYERS_CHARACTERS_TABLE_LINEAGE + "='" + TEXTBOX_LINEAGE + "';";
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
        public string insertNewAccoutToAccountsTable(string DATABASE_ACCOUNTS_TABLE, string ACCOUNTS_TABLE_ACCOUNT_NAME, string ACCOUNTS_TABLE_PASSWORD, string TEXT_BOX_ACCOUNT_NAME, string TEXTBOX_PASSWORD)
        {
            string sqlString = null;
            sqlString = "INSERT INTO " + DATABASE_ACCOUNTS_TABLE + " (" + ACCOUNTS_TABLE_ACCOUNT_NAME + ", " + ACCOUNTS_TABLE_PASSWORD + ") values ('" + TEXT_BOX_ACCOUNT_NAME + "','" + TEXTBOX_PASSWORD + "');";
            return sqlString;
        }
        public string insertNewCharacterToPlayersCharactersTable(string PLAYERS_CHARACTERS_TABLE_ID_ACCOUNT, string PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME, string PLAYERS_CHARACTERS_TABLE_LINEAGE, string DATABASE_PLAYERS_CHARACTERS_TABLE, string TEXT_ID_ACCOUNT, string TEXT_BOX_CHARACTER_NAME, string TEXT_BOX_LINEAGE)
        {
            string sqlString = null;
            sqlString = "INSERT INTO " + DATABASE_PLAYERS_CHARACTERS_TABLE + " (" + PLAYERS_CHARACTERS_TABLE_ID_ACCOUNT + ", " + PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME + ", " + PLAYERS_CHARACTERS_TABLE_LINEAGE + ") VALUES ('" + TEXT_ID_ACCOUNT + "','" + TEXT_BOX_CHARACTER_NAME + "','" + TEXT_BOX_LINEAGE + "');";
            return sqlString;
        }
    }
}
