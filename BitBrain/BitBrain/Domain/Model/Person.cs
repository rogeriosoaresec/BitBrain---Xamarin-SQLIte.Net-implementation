using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace BitBrain.Domain.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string PersonName { get; set; }

        [OneToMany]
        public List<PersonUser> PersonUser { get; set; }
    }
}