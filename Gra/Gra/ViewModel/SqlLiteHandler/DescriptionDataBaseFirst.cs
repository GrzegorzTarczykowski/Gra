using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra.ViewModel.SqlLiteHandler
{
    public static class DescriptionDataBaseFirst
    {
        #region ACCOUNTS_TABLE
        public static string DATABASE_ACCOUNTS_TABLE = "Accounts";
        public static string ACCOUNTS_TABLE_ID = "Id";
        public static string ACCOUNTS_TABLE_ACCOUNT_NAME = "AccountName";
        public static string ACCOUNTS_TABLE_PASSWORD = "Password";
        #endregion
        #region PLAYERS_CHARACTERS_TABLE
        public static string DATABASE_PLAYERS_CHARACTERS_TABLE = "PlayersCharacters";
        public static string PLAYERS_CHARACTERS_TABLE_ID = "Id";
        public static string PLAYERS_CHARACTERS_TABLE_ID_ACCOUNT = "IdAccount";
        public static string PLAYERS_CHARACTERS_TABLE_CHARACTER_NAME = "CharacterName";
        public static string PLAYERS_CHARACTERS_TABLE_LINEAGE = "Lineage";
        #endregion
    }
}
