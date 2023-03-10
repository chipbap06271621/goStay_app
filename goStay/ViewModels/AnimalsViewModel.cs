using goStay.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace goStay.ViewModels
{
    public class AnimalsViewModel : INotifyPropertyChanged
    {
        int itemCount = 10;
        const int MaximumItemCount = 50;
        const int PageSize = 10;
        const int RefreshDuration = 2;
        bool isRefreshing;

        public ObservableCollection<Animal> Animals { get; private set; } = new ObservableCollection<Animal>();

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public AnimalsViewModel()
        {
            AddBears();
        }

        void AddBears()
        {
            Animals.Add(new Animal
            {
                Name = "Khách sạn Diamond Bay Nha Trang",
                Location = "Thành Phố Nha Trang - Khánh Hòa",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1428/125202241029AM000.jpg"
            });
            Animals.Add(new Animal
            {
                Name = "Khách sạn Anya Premier Quy Nhơn",
                Location = "Thành Phố Quy Nhơn - Bình Định",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1477/127202223702AM000.jpeg"
            });
            Animals.Add(new Animal
            {
                Name = "Le Belhamy Hội An Resort & Spa",
                Location = "TP Hội An - Quảng Nam",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/2496/2272023101046AM000.jpeg"
            });
            Animals.Add(new Animal
            {
                Name = "Khách sạn TTC Premium Hội An",
                Location = "Thành Phố Quy Nhơn - Bình Định",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/2506/228202333644AM001.jpg"
            });
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
