using System.IO;
using Windows.Storage;
using BitBrain.Core.Data.Interfaces;
using BitBrain.WinPhone.Data;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteWinPhone81))]
namespace BitBrain.WinPhone.Data
{
    public class SQLiteWinPhone81 : ISQLite
    {

        #region ISQLite implementation

        #endregion
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "database.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            var conn = new SQLiteConnection(new SQLitePlatformWinRT(), path, false);

            // Return the database connection 
            return conn;
        }

    }
}