using System;
using System.Collections.Generic;
using SQLite;
using TravelRecordApp.Model;

using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SQLiteConnection con = new SQLiteConnection(App.DataBaseLocation);

            con.CreateTable<Post>();
            postListView.ItemsSource = con.Table<Post>().ToList();
            con.Close();

        }

        void postListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedPost = postListView.SelectedItem as Post;

            if(selectedPost != null)
            {
                Navigation.PushAsync(new PostDetailPage(selectedPost));
            }

        }
    }
}
