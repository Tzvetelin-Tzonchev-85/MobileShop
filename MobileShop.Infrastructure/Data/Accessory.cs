namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Data.DataConstants.Accessory;
    public class Accessory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(AccessoriesNameMaxLength)]
        public string? Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(AccessoriesColorMaxLenth)]
        public string? Color { get; set; }

        public int Amount { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
