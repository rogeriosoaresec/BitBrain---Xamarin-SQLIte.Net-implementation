using System.Linq;
using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Sample;
using BitBrain.Domain;
using BitBrain.Domain.Model;
using BitBrain.Domain.Repositories;
using BitBrain.Views;
using Xamarin.Forms;

namespace BitBrain
{
    public class App : Application
    {
        private static UserRepository _userRepository;
        private static PersonRepository _personRepository;
        private static PersonUserRepository _personUserRepository;

        private static DatabaseContext _bitBrainDbContext;
        public static DatabaseContext BitbrainDbContext
        {
            get
            {
                if (_bitBrainDbContext == null) _bitBrainDbContext = new BitbrainContext();
                return _bitBrainDbContext;
            }
        }
        
        public App()
        {
            _userRepository = new UserRepository(BitbrainDbContext);
            _personRepository = new PersonRepository(BitbrainDbContext);
            _personUserRepository = new PersonUserRepository(BitbrainDbContext);

            var users = _userRepository.Get<User>();
            if (!users.Any()) new SampleData(); // I entered data if there is no line

            //var d = new BitbrainContext(true); // uncomment to delete the tables
            

            // get datas with children
            var tablePersonUsers = _personUserRepository.GetAllWithChildren();
            MainPage = new NavigationPage(new HomePage() {BindingContext = tablePersonUsers });
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
