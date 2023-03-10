namespace goStay;

public partial class HotelBooking : ContentPage
{
    private object monkeyNameLabel;

    public HotelBooking()
    {
        InitializeComponent();
    }

    private void CheckBox_Focused(object sender, FocusEventArgs e)
    {

    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.SetBinding(Picker.ItemsSourceProperty, "Monkeys");
        picker.ItemDisplayBinding = new Binding("Name");
    }
}