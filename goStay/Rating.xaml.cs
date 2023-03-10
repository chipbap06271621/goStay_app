
using System.Linq.Expressions;

namespace goStay;

public partial class Rating : ContentPage
{
	public Rating()
	{
		InitializeComponent();
	}

 

    public string binlabel(double rating)
    {
        switch (rating)
        {
            case <=1:
                return "Kém";
            case <=2:
                return "Trung bình";
            case <=3:
                return "Khá";
            case <=4:
                return "Tốt";
            default:
                return "Rất tốt";
        }
    }

    public string binTong(double rating1, double rating2, double rating3, double rating4, double rating5 )
    {
        double Temp = Math.Round(((rating1 + rating2 + rating3 + rating4 + rating5) / 5), 1);
        lbCapTong.Text = binlabel(Temp);
     
            return Temp.ToString();
    }

    private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        lbvesinh.Text = sender.ToString();
        double value = Math.Round(e.NewValue, 0);
        lbvesinh.Text = "Vệ sinh: " + value.ToString() + " sao: " + binlabel((int)value);
        lbValTong.Text = binTong (value, sltiennghi.Value,slphucvu.Value,slgiaca.Value,slvitri.Value);
    }

    private void Slider_ValueChanged_3(object sender, ValueChangedEventArgs e)
    {
        lbphucvu.Text = sender.ToString();
        double value = Math.Round(e.NewValue, 0);
        lbphucvu.Text = "Phục vụ: " + value.ToString() + " sao: " + binlabel((int)value);
        lbValTong.Text = binTong(value, sltiennghi.Value, slvesinh.Value, slgiaca.Value, slphucvu.Value);
    }

    private void Slider_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        lbgiaca.Text = sender.ToString();
        double value  =  Math.Round(e.NewValue, 0);
        lbgiaca.Text = "Giá cả: " + value.ToString() + " sao: " + binlabel((int)value);
        lbValTong.Text = binTong(value, sltiennghi.Value, slphucvu.Value,slvitri.Value, slvesinh.Value);
    }

    private void Slider_ValueChanged_4(object sender, ValueChangedEventArgs e)
    {
        lbvitri.Text = sender.ToString();
        double value = Math.Round(e.NewValue, 0);
        lbvitri.Text = "Vị trí: " + value.ToString() + " sao: " + binlabel((int)value);
        lbValTong.Text = binTong(value,slgiaca.Value, slphucvu.Value, slvesinh.Value, sltiennghi.Value);
    }
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs args)
    {
        lbTiennghi.Text = sender.ToString();
        double value = Math.Round(args.NewValue, 0);
        lbTiennghi.Text = "Tiện nghi: " + value.ToString() + " sao: " + binlabel((int)value);
        lbValTong.Text = binTong(value, slvesinh.Value, slphucvu.Value, slgiaca.Value, slvitri.Value);
    }



}