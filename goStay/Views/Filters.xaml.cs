

using System.Globalization;

namespace goStay;

public partial class Filters : ContentPage
{
	public Filters()
	{
		InitializeComponent();
	}
    //public string binlabel(double rating)
    //{
       
    //}
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {

        lbPrice.Text = "Khoảng giá: 0 - "+string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", 100000 * Math.Round(e.NewValue, 0)) +" vnđ";
        
    }

    
}
