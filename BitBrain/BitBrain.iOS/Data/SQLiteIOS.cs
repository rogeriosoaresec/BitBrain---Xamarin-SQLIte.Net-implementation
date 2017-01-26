using System;
using System.IO;
using BitBrain.Core.Data.Interfaces;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;

namespace BitBrain.iOS.Data
{
    public class SQLiteIOS : ISQLite
    {

        #region ISQLite implementation
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "database.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLiteConnection(new SQLitePlatformIOS(), path);

            // Return the database connection 
            return conn;
        }
        #endregion
    }
}