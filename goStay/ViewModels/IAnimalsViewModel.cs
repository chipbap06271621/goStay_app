using goStay.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace goStay.ViewModels
{
    public interface IAnimalsViewModel
    {
        ObservableCollection<Animal> Animals { get; }

        bool IsRefreshing { get; set; }
        ICommand LoadMoreDataCommand { get; }
        ICommand RefreshCommand { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}