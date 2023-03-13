namespace goStay.Views;

public partial class TourList : ContentPage
{
	public TourList()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Filterzz());
    }
}