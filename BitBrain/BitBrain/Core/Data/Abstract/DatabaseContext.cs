using BitBrain.Core.Data.Interfaces;
using SQLite.Net;
using Xamarin.Forms;

namespace BitBrain.Core.Data.Abstract
{
    public abstract class DatabaseContext
    {
        public static object Locker { get; } = new object();
        public SQLiteConnection Database { get; }

        protected DatabaseContext()
        {
            Database = DependencyService.Get<ISQLite>().GetConnection();
        }

        public bool TableExists(string tableName)
        {
            return Database.GetTableInfo(tableName).Count > 0;
        }
    }
}
