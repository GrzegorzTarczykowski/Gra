using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

namespace Gra.ViewModel.SqlLiteHandler
{
    class ConnectorSqlLite
    {
        public static SQLiteConnection connection;
        private SQLiteCommand commander;
        public static string dataBase = "DataBaseFirst.db";
        public static string dataBaseConnector = "Data Source=" + dataBase + ";Version=3;New=False;Compress=True;";
        public SQLiteCommand connect()
        {
            try
            {
                connection = new SQLiteConnection(dataBaseConnector);
                connection.Open();
                commander = connection.CreateCommand();
            }
            catch
            {
                MessageBox.Show("Nie mozna polaczyc sie z baza danych");
            }
            return commander;
        }
        public void disConnect()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Nie mozna rozlaczyc sie z baza danych");
            }
        }
    }
}
