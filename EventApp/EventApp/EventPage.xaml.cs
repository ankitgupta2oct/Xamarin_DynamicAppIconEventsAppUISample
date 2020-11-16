using System;
using System.Collections.Generic;
using EventApp.ViewModels;
using Xamarin.Forms;

namespace EventApp
{
    public partial class EventPage : ContentPage
    {
        public EventPage()
        {
            InitializeComponent();
            BindingContext = new EventViewModel();
        }

        void SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count != 0)
            {
                var collectionView = (CollectionView)sender;
                collectionView.SelectedItem = null;

                Navigation.PushAsync(new EventDetail());
            }
        }
    }
}
