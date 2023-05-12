namespace PalStoreMarket.Models
{
    public class Ads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
    }
}
