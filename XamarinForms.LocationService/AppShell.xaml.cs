using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.LocationService.Views;

namespace XamarinForms.LocationService
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Assigned), typeof(Assigned));
            Routing.RegisterRoute(nameof(Available), typeof(Available));
            Routing.RegisterRoute(nameof(JobDetails), typeof(JobDetails));
            Routing.RegisterRoute(nameof(JobDropOff), typeof(JobDropOff));

            Routing.RegisterRoute(nameof(JobPickup), typeof(JobPickup));
            Routing.RegisterRoute(nameof(JobVehicle), typeof(JobVehicle));
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            Routing.RegisterRoute(nameof(OnGoing), typeof(OnGoing));
            Routing.RegisterRoute(nameof(TabbedJobs), typeof(TabbedJobs));
            Routing.RegisterRoute(nameof(TabbedDetails), typeof(TabbedDetails));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}