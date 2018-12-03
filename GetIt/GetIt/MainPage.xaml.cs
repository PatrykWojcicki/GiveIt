using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GetIt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_GetIt(object sender, EventArgs s)
        {
           await Navigation.PushAsync(new GetItList());
 
        }
        private async void Button_GiveThat(object sender, EventArgs s)
        {
            await Navigation.PushAsync(new GiveThat());

        }
        private async void Button_Settings(object sender, EventArgs s)
        {
            await Navigation.PushAsync(new Settings());

        }
    }
}
