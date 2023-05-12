using System.ComponentModel.DataAnnotations;

namespace PalStoreMarket.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; } 

    }
}
