using goStay.Models;
using System.Collections.ObjectModel;

namespace goStay.ViewModels
{
    public class MonkeysViewModelWithDelay
    {
        public ObservableCollection<Monkey> Monkeys { get; private set; } = new ObservableCollection<Monkey>();

        public MonkeysViewModelWithDelay()
        {
            CreateMonkeyCollection();
        }

        async Task CreateMonkeyCollection()
        {
            Monkeys.Add(new Monkey
            {
                Name1 = "Baboon",
                Location1 = "Africa & Asia",
                Details1 = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl1 = "https://cdn.realtech.com.vn/uploads/hotel/1478/127202224040AM000.jpg"
            });

            await Task.Delay(2000);

            Monkeys.Add(new Monkey
            {
                Name1 = "Capuchin Monkey",
                Location1 = "Central & South America",
                Details1 = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl1 = "hotel/img1.jpg"
            });

            
        }
    }
}
