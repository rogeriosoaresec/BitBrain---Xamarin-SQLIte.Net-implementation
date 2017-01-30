using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Sample;
using BitBrain.Domain.Model;

namespace BitBrain.Domain
{
    public class BitbrainContext : DatabaseContext
    {
        public BitbrainContext(bool drop = false)
        {
            if (!drop)
            {
                if (!TableExists("User")) Database.CreateTable<User>();
                if (!TableExists("Person")) Database.CreateTable<Person>();
                if (!TableExists("PersonUser")) Database.CreateTable<PersonUser>();
                
            }
            else
            {
                if (TableExists("User")) Database.DropTable<User>();
                if (TableExists("Person")) Database.DropTable<Person>();
                if (TableExists("PersonUser")) Database.DropTable<PersonUser>();
            }
        }
    }
}