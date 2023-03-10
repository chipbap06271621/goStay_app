namespace goStay;

public partial class PromotionListing : ContentPage
{
    public PromotionListing()
    {
        InitializeComponent();
    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Homepage());
    }
    private void PromotionTourDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PromotionTourDetail()); ;
    }
    private void PromotionPlaneDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PromotionPlaneDetail()); ;
    }
}