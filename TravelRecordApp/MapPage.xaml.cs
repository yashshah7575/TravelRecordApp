using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MapPage : ContentPage
    {
        Slider selectedBarSlider, rotationSlider;

        public MapPage()
        {
            InitializeComponent();

            // we'll add Urho later

            rotationSlider = new Slider(0, 500, 250);

            selectedBarSlider = new Slider(0, 5, 2.5);

            Title = " UrhoSharp + Xamarin.Forms";
            Content = new StackLayout
            {
                Padding = new Thickness(12, 12, 12, 40),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    rotationSlider, 
                    new Label { Text = "SELECTED VALUE:" },
                    selectedBarSlider,
                 }
            };
        }
    }
}
