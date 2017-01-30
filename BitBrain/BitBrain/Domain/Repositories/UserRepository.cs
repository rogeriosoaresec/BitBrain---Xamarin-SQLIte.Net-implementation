using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Repository;
using BitBrain.Domain.Model;

namespace BitBrain.Domain.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DatabaseContext db) : base(db)
        {

        }
    }
}