using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinForms.LocationService.Views;

namespace XamarinForms.LocationService.ViewModels
{
    public class AvailableViewModel
    {
        public Command DetailsCommand { get; }

        public AvailableViewModel()
        {
            DetailsCommand = new Command(OnDetailsClicked);
        }

        private async void OnDetailsClicked(object obj)
        {
            await Shell.Current.GoToAsync(nameof(TabbedDetails));

        }
    }

    
}
