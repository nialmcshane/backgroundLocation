using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinForms.LocationService.Views;

namespace XamarinForms.LocationService.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {

            await Shell.Current.GoToAsync(nameof(TabbedJobs));

        }

    }
}
