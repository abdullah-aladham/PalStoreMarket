using System.ComponentModel.DataAnnotations;

namespace PalStoreMarket.Models
{
    public class Cupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EdnDate { get; set; }
        public virtual Seller seller { get; set; }
        public virtual Product Product { get; set; }
    }
    
}
