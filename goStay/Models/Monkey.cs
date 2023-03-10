namespace goStay.Models
{
    public class Monkey
    {
        public string Discount1 { get; set; }

        public string Rating1 { get; set; }

        public string Name1 { get; set; }

        public string Location1 { get; set; }
        public string Details1 { get; set; }
        public string ImageUrl1 { get; set; }
        public bool IsFavorite { get; set; }

        public bool IsFavorite1 { get; set; }

        public string Price1 { get; internal set; }
        public string Baseprice1 { get; internal set; }

        public string Name2 { get; set; }
        public string Location2 { get; set; }
        public string Details2 { get; set; }
        public string ImageUrl2 { get; set; }
        public bool IsFavorite2 { get; set; }
        public string Price2 { get; internal set; }

        public string Baseprice2 { get; internal set; }
        public string Rating2 { get; set; }
        public string Discount2 { get; set; }

    }

    public class Images
    {
        public string ImageUrl { get; set; }

    }

    public class Rooms
    {
        public List<Images> Image { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }

    }

    public class Plane
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
