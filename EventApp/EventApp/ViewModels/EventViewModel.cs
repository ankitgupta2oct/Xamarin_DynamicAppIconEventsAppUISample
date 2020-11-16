using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EventApp.ViewModels
{
    public class EventViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Update([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public ObservableCollection<Event> Events { get; private set; }

        public EventViewModel()
        {
            Events = new ObservableCollection<Event>
            {
                new Event { Name = "Apple 2020", ImageName = "Apple.jpg", Venue = "72 S Linden Ave, San Francisco"},
                new Event { Name = "Fasion Fair 2020", ImageName = "Model.png", Venue = "72 S Linden Ave, San Francisco"},
                new Event { Name = "Google IO", ImageName = "Google.png", Venue = "72 S Linden Ave, San Francisco"}
            };
        }
    }

    public class Event
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Venue { get; set; }
    }
}