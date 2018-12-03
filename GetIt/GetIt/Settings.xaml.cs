using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GetIt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            //var layout = new StackLayout { Padding = new Thickness(5, 10) };
            //var label = new Label { Text = "This is a green label.", TextColor = Color.FromHex("#77d065"), FontSize = 20 };
            //layout.Children.Add(label);
            //this.Content = layout;

        }


	}
}