using System;
using System.Collections.Generic;
using SQLite;
using TravelRecordApp.Model;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            SQLiteConnection connection = new SQLiteConnection(App.DataBaseLocation);
            connection.CreateTable<Post>();
            int rows = connection.Insert(post);
            connection.Close();

            if(rows > 0)
            {
                DisplayAlert("Success", "Inserted!", "Ok");
            }
            else
            {
                DisplayAlert("Failuer", "Failed!", "Ok");
            }
        }
    }
}
