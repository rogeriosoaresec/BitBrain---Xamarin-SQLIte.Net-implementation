using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace BitBrain.Domain.Model
{
    public class PersonUser
    {
        [PrimaryKey, AutoIncrement]
        public int PersonUserId { get; set; }
        [ForeignKey(typeof(Person))]
        public int PersonId { get; set; }
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ManyToOne]
        public Person Person { get; set; }
        [ManyToOne]
        public User User { get; set; }
    }
}