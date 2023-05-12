using System.ComponentModel.DataAnnotations;

namespace PalStoreMarket.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string type {get; set; }
        [Required]
        public int currency { get; set; }
        [Required]
        public int shownprice { get; set; } = 0;// 0 for true 1 for false
        public virtual Seller Seller { get; set; }

        public Product(int id, string name, string description, double price, string type, int currency, int shownprice, Seller seller)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            this.type = type;
            this.currency = currency;
            this.shownprice = shownprice;
            Seller = seller;
        }

    }

}
