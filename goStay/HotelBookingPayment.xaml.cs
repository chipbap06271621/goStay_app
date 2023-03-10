namespace goStay;

public partial class HotelBookingPayment : ContentPage
{
    public HotelBookingPayment()
    {
        InitializeComponent();
    }
    private bool _collapsed = false;
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        icon.RotateTo(_collapsed ? 180 : 0);

        items.IsVisible = !_collapsed;
        _collapsed = !_collapsed;
    }
    private bool _collapsed1 = false;
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        icon1.RotateTo(!_collapsed1 ? 180 : 0);

        items1.IsVisible = !_collapsed1;
        _collapsed1 = !_collapsed1;
    }
    private bool _collapsed2 = false;
    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        icon2.RotateTo(!_collapsed2 ? 180 : 0);

        items2.IsVisible = !_collapsed2;
        _collapsed2 = !_collapsed2;
    }
}