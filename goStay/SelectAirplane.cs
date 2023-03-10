namespace goStay;

public partial class SelectAirplane : ContentPage
{
	public SelectAirplane()
	{
		InitializeComponent();
	}
    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }

}