namespace goStay;

public partial class PromotionTourDetail : ContentPage
{
	public PromotionTourDetail()
	{
		InitializeComponent();
	}
    private void AirPlane(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AirPlane()); ;
    }
    private void HotelDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new HotelDetail()); ;
    }
}