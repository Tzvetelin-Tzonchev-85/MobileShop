namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Data.DataConstants.Product;

    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(ProductsNameMaxLength)]
        public string? Name { get; set; }

        public int Dimension { get; set; }

        [Required]
        [StringLength(ProductsOperationSystemMaxLength)]
        public string? OperationSystem { get; set; }

        [Required]
        [StringLength(ProductsColourMaxLenth)]
        public string? Colour { get; set; }

        public double Price { get; set; }

        [ForeignKey(nameof(CategoryId))]

        [Required]
        public Guid CategoryId { get; set; }

        public Category? Category { get; set; }

        public Guid? ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; }

        public Guid? ModelId { get; set; }

        [ForeignKey(nameof(ModelId))]
        public Model Model { get; set; }

        //public IList<Accessory> Accessories { get; set; } = new List<Accessory>();

       // public IList<Model> Models { get; set; } = new List<Model>();
    }
}
