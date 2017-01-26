using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitBrain.Domain.Model;
using Xamarin.Forms;

namespace BitBrain.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var data = (List<PersonUser>) (BindingContext ?? new List<PersonUser>());

            ListPersonUsers.ItemsSource = data;
        }
    }
}
