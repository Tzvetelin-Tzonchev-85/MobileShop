namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid CategoryId { get; set; }

        public string? Name { get; set; }

        public int Dimension { get; set; }

        public string? OperationSystem { get; set; }

        public string? Colour { get; set; }

        public decimal Price { get; set; }

        public Guid AccessoryId { get; set; }

        [ForeignKey(nameof(AccessoryId))]
        public Accessory? Accessory { get; set; }

        [ForeignKey(nameof(CategoryId))]
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
