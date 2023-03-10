
using goStay;
using System.Windows.Input;

namespace goStay;

public partial class Homepage : ContentPage
{

    public Homepage()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };

    }

    //private async void OnTapped(object sender, EventArgs e)
    //{
    //   await Navigation.PushAsync(new SearchCollapse());
    //}


    //private void OnTapped2(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectRoom());
    //}

    //private void AirPlane(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectAirPlane());
    //}

    //private void SelectSeat(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectSeatPlane());
    //}

    //private void SelectTour(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new TourDetail());
    //}

    private void HotelDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new HotelDetail()); ;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Homepage());
    }

    private void ItemDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ItemDetail()); ;
    }
}
