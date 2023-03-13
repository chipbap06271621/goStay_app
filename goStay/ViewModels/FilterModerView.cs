using goStay.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace goStay.ViewModels
{
    public class FilterModerView 
    {
        
        public ObservableCollection<Listtour> myPlane { get; private set; } = new ObservableCollection<Listtour>();

        public FilterModerView()
        {
            myPlane.Add(new Listtour() { image= "Vietjet.jpg", Title= "VietjetAir" });
            myPlane.Add(new Listtour() { image = "vna.jpg", Title = "Vietnam Airline" });
            myPlane.Add(new Listtour() { image = "bamboo.jpg", Title = "Bamboo Airways" });
            myPlane.Add(new Listtour() { image = "jestar.jpg", Title = "Jestar Pacifics" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
