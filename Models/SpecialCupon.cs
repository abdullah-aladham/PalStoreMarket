namespace PalStoreMarket.Models
{
    public class SpecialCupon
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public virtual Seller Seller{ get; set; }
        public int Seller_Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int Customer_Id { get; set; }


    }
}
