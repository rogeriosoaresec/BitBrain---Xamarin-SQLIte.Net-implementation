using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BitBrain.Domain;
using BitBrain.Domain.Model;
using BitBrain.Domain.Repositories;
using Splat;

namespace BitBrain.Core.Data.Sample
{
    public class SampleData
    {
        private static PersonRepository _personRepository;
        private static UserRepository _userRepository;
        private static PersonUserRepository _personUserRepository;
        public SampleData()
        {
            _personRepository = new PersonRepository(App.BitbrainDbContext);
            _userRepository = new UserRepository(App.BitbrainDbContext);
            _personUserRepository = new PersonUserRepository(App.BitbrainDbContext);

            InsertRelationship();
        }

        private async Task InsertPersons()
        {
            var r1 = _personRepository.InsertAll(SamplePersons());
        }
        private async Task InsertUsers()
        {
            var r2 = _userRepository.InsertAll(SampleUsers());
        }
        private async Task InsertRelationship()
        {
            await InsertPersons();
            await InsertUsers();

            var users = _userRepository.Get<User>().ToArray();
            var persons = _personRepository.Get<Person>().ToArray();

            if (users.Length == persons.Length)
                for (int i = 0; i < users.Length; i++)
                {
                    _personUserRepository.Insert(new PersonUser()
                    {
                        UserId = users[i].UserId, PersonId = persons[i].PersonID
                    });
                }
        }

        private List<Person> SamplePersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    PersonName = "Mary"
                },
                new Person()
                {
                    PersonName = "Jonh"
                }
            };
        }

        private List<User> SampleUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    UserName = "Admin"
                },
                new User()
                {
                    UserName = "Guest"
                }
            };
        }


    }
}