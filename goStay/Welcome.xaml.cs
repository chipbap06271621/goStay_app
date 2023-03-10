namespace goStay;

public partial class Welcome : ContentPage
{
    public Welcome()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new AirPlane());
    }
}

