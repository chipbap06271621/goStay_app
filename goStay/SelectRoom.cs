namespace goStay;

public partial class SelectRoom : ContentPage
{
	public SelectRoom()
	{
		InitializeComponent();
	}

    void OnStepper(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel.Text = string.Format("{0}", value);
    }
    void OnStepper1(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel1.Text = string.Format("{0}", value);
    }
    void OnStepper2(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel2.Text = string.Format("{0}", value);
    }

    private void OnCounterClicked5(object sender, EventArgs e)
	{
        Navigation.PushAsync(new SearchCollapse()); 
    }
}

