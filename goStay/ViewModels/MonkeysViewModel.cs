using goStay.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace goStay.ViewModels
{
    public class MonkeysViewModel 
    {
        readonly IList<Monkey> source;

        public ObservableCollection<Monkey> Monkeys { get; private set; }
        public IList<Monkey> EmptyMonkeys { get; private set; }

        public Monkey PreviousMonkey { get; set; }
        public Monkey CurrentMonkey { get; set; }
        public Monkey CurrentItem { get; set; }
        public int PreviousPosition { get; set; }
        public int CurrentPosition { get; set; }
        public int Position { get; set; }

        public ICommand FilterCommand => new Command<string>(FilterItems);
        public ICommand ItemChangedCommand => new Command<Monkey>(ItemChanged);
        public ICommand PositionChangedCommand => new Command<int>(PositionChanged);
        public ICommand DeleteCommand => new Command<Monkey>(RemoveMonkey);
        public ICommand FavoriteCommand => new Command<Monkey>(FavoriteMonkey);

        public MonkeysViewModel()
        {
            source = new List<Monkey>();
            CreateMonkeyCollection();

            CurrentItem = Monkeys.Skip(3).FirstOrDefault();
            OnPropertyChanged("CurrentItem");
            Position = 3;
            OnPropertyChanged("Position");
        }

        void CreateMonkeyCollection()
        {
            source.Add(new Monkey
            {
                Name1 = "Khách Sạn Wink Đà Nẵng Centre ...",
                Discount1 = "-30%",
                Location1 = "Quận Sơn Trà",
                Price1 = "1.056.279",
                Baseprice1 = "1.056.465",
                Rating1 = "\uf005; \uf005; \uf005; \uf005; ",
                ImageUrl1 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1477/127202223702AM000.jpeg",

                Name2 = "Khách sạn Diamond Bay Nha Trang ",
                Discount2 = "-30%",
                Location2 = "Quận Ngũ Hành Sơn",
                Price2 = "1.056.279",
                Baseprice2 = "1.056.465",
                Rating2 = "\uf005;\uf005;\uf005;\uf005;\uf005",
                ImageUrl2 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1428/125202241029AM000.jpg"
            });

            source.Add(new Monkey
            {
                Name1 = "Khách Sạn Maximilan Đà Nẵng",
                Location1 = "Quận Sơn Trà",
                Discount1 = "-30%",
                Price1 = "1.056.279",
                Baseprice1 = "1.056.465",
                Rating1 = "\uf005;\uf005;\uf005;\uf005;\uf005",
                ImageUrl1 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1516/129202231616AM000.jpg",

                Name2 = "Khách sạn Anya Premier Quy Nhơn",
                Discount2 = "-30%",
                Location2 = "Quận Ngũ Hành Sơn",
                Price2 = "1.056.279",
                Baseprice2 = "1.056.465",
                Rating2 = "\uf005;\uf005;\uf005;\uf005;\uf005",
                ImageUrl2 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1249/1123202274206AM000.jpg"
            });

            Monkeys = new ObservableCollection<Monkey>(source);
        }

        void FilterItems(string filter)
        {
            var filteredItems = source.Where(monkey => monkey.Name1.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var monkey in source)
            {
                if (!filteredItems.Contains(monkey))
                {
                    Monkeys.Remove(monkey);
                }
                else
                {
                    if (!Monkeys.Contains(monkey))
                    {
                        Monkeys.Add(monkey);
                    }
                }
            }
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
            monkey.IsFavorite1 = !monkey.IsFavorite1;
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
