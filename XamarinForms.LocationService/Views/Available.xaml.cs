using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.LocationService.ViewModels;

namespace XamarinForms.LocationService.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Available : ContentPage
    {
        private readonly AvailableViewModel vm;

        public Available()
        {
            InitializeComponent();
            vm = new AvailableViewModel();
            BindingContext = vm;
        }
    }
}