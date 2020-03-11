using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFFonts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var label = new Label
            {
                Text = "Welcome to Xamarin.Forms! From C#",
                FontFamily = Device.RuntimePlatform == Device.Android ? "Bellota-Regular.ttf#Bellota" : null
            };
            label.HorizontalOptions = LayoutOptions.Center;          
            stackLayout.Children.Add(label);
        }
    }
}
