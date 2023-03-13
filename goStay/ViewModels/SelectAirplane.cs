using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using goStay.Models;

namespace goStay.ViewModels
{
    public class SelectAirplane 
    {
        int itemCount = 10;
        const int MaximumItemCount = 50;
        const int PageSize = 10;
        const int RefreshDuration = 2;
        bool isRefreshing;

        readonly IList<Plane> source;
        public ObservableCollection<Plane> MyPlanes { get; private set; }
        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public SelectAirplane()
        {
            source = new 
                ObservableCollection<Plane>();

            source.Add(new Plane
            {
                Name = "TP Hồ Chí Minh (SGN)",
                Location = "Sân bay quốc tế Tân Sơn Nhất"
            });


            MyPlanes = new ObservableCollection<Plane>(source);
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

