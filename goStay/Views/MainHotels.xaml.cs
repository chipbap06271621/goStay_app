
using goStay;
using System.Windows.Input;

namespace goStay.Views;

public partial class MainHotels : ContentPage
{

    public MainHotels()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };

    }

    private async void SearchCollapse(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchCollapse());
    }

  

    private void OnTapped2(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SelectRoom());
    }

    private void AirPlane(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SelectAirplane());
    }

    //private void SelectSeat(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectSeatPlane());
    //}

    //private void SelectTour(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new TourDetail());
    //}

    private async void HotelDetail(object sender, TappedEventArgs e)
    {
      await Navigation.PushAsync(new HotelDetail()); ;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Homepage());
    }

    private async void ItemDetail(object sender, TappedEventArgs e)
    {
       await Navigation.PushAsync(new ItemDetail()); ;
    }
}
