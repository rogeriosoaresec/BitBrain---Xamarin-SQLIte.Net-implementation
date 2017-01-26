using System.Collections.Generic;
using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Repository;
using BitBrain.Domain.Model;
using SQLiteNetExtensions.Extensions;

namespace BitBrain.Domain.Repositories
{
    public class PersonUserRepository : Repository<PersonUser>
    {
        public PersonUserRepository(DatabaseContext db) : base(db)
        {


        }
        public List<PersonUser> GetAllWithChildren()
        {
            //var query = db.Database.GetWithChildren<PersonUser>(id);
            var query = db.Database.GetAllWithChildren<PersonUser>();
            return query;
        }
    }
}