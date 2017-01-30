using SQLite.Net;

namespace BitBrain.Core.Data.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
