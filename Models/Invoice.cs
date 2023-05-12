using System.ComponentModel.DataAnnotations;

namespace PalStoreMarket.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        [Required]
        public virtual List<Product> Products { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual Seller Seller { get; set; }
    }
}
