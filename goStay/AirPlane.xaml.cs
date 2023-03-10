namespace goStay;

public partial class AirPlane : ContentPage
{

    public AirPlane()
    {
        InitializeComponent();
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SelectRoom());
    }
    private void ItemDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ItemDetail()); ;
    }
}