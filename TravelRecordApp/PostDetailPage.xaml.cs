using System;
using System.Collections.Generic;
using SQLite;
using TravelRecordApp.Model;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;

        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();
            this.selectedPost = selectedPost;
            experienceLabelEntry.Text = selectedPost.Experience;
        }

        void Update_Clicked(System.Object sender, System.EventArgs e)
        {
            selectedPost.Experience = experienceLabelEntry.Text;

            SQLiteConnection connection = new SQLiteConnection(App.DataBaseLocation);
            connection.CreateTable<Post>();
            int rows = connection.Update(selectedPost);
            connection.Close();

            if (rows > 0)
            {
                DisplayAlert("Success", "Updated!", "Ok");
            }
            else
            {
                DisplayAlert("Failuer", "Failed!", "Ok");
            }


        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection(App.DataBaseLocation);
            connection.CreateTable<Post>();
            int rows = connection.Delete(selectedPost);
            connection.Close();

            if (rows > 0)
            {
                DisplayAlert("Success", "Deleted!", "Ok");
            }
            else
            {
                DisplayAlert("Failuer", "Failed!", "Ok");
            }

        }
    }
}
