using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;

namespace GetIt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GiveThat : ContentPage
    {
        public GiveThat()
        {
            InitializeComponent();
            takePhoto.Clicked += CameraButton_Clicked;
        }
        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            var photo = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
            });
        }


    }
}