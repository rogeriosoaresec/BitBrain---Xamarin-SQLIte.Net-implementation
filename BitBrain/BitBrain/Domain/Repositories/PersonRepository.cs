using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Repository;
using BitBrain.Domain.Model;

namespace BitBrain.Domain.Repositories
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(DatabaseContext db) : base(db)
        {

        }
    }
}