using goStay.Models;

namespace goStay.Views
{
    [QueryProperty(nameof(Bear), "Bear")]
    public partial class BearDetailPage : ContentPage
    {
        Animal bear;
        public Animal Bear
        {
            get => bear;
            set
            {
                bear = value;
                OnPropertyChanged();
            }
        }

        public BearDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
