using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using goStay.Models;
namespace goStay.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        readonly IList<Images> source;
        readonly IList<Rooms> sourceRooms;

        public ObservableCollection<Images> Topimage { get; private set; }

        public ObservableCollection<Rooms> ListRoom { get; private set; }

        public ObservableCollection<Monkey> Monkeys { get; private set; }


        public Monkey PreviousMonkey { get; set; }
        public Monkey CurrentMonkey { get; set; }
        public Monkey CurrentItem { get; set; }
        public int PreviousPosition { get; set; }
        public int CurrentPosition { get; set; }
        public int Position { get; set; }

  
        public ICommand ItemChangedCommand => new Command<Monkey>(ItemChanged);
        public ICommand PositionChangedCommand => new Command<int>(PositionChanged);
        public ICommand DeleteCommand => new Command<Monkey>(RemoveMonkey);
        public ICommand FavoriteCommand => new Command<Monkey>(FavoriteMonkey);

        public DetailViewModel()
        {
            source = new List<Images>();
            sourceRooms = new List<Rooms>(); ;
            //  ListRoom = new ObservableCollection<Rooms>();
            CreateMonkeyCollection();

            //CurrentItem = Monkeys.Skip(3).FirstOrDefault();
            //OnPropertyChanged("CurrentItem");
            //Position = 3;
            //OnPropertyChanged("Position");


        }

        void CreateMonkeyCollection()
        {
            source.Add(new Images
            {
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=800,height=600,quality=80//uploads/hotel/1249/1123202274206AM004.jpg"
            });

            Topimage = new ObservableCollection<Images>(source);

            source.Clear();

            //source.Add(new Monkey
            //{
            //    Name = "Baboon",
            //    Location = "Africa & Asia",
            //    Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
            //    ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1477/127202223702AM000.jpeg"
            //});

            
            Images img = new Images()
            {
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1477/127202223702AM000.jpeg"
            };

            List<Images> images = new List<Images>();

            images.Add(img);


            sourceRooms.Add(new Rooms() { Title = "Title Rooms 1", Image = images });
            sourceRooms.Add(new Rooms() { Title = "Title Rooms 2", Image = images });


            ListRoom = new ObservableCollection<Rooms>(sourceRooms);

        }
       
        void ItemChanged(Monkey item)
        {
            PreviousMonkey = CurrentMonkey;
            CurrentMonkey = item;
            OnPropertyChanged("PreviousMonkey");
            OnPropertyChanged("CurrentMonkey");
        }

        void PositionChanged(int position)
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
            OnPropertyChanged("PreviousPosition");
            OnPropertyChanged("CurrentPosition");
        }

        void RemoveMonkey(Monkey monkey)
        {
            if (Monkeys.Contains(monkey))
            {
                Monkeys.Remove(monkey);
            }
        }

        void FavoriteMonkey(Monkey monkey)
        {
            monkey.IsFavorite = !monkey.IsFavorite;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
