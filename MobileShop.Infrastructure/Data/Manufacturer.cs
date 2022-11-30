namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants.Manufacturer;

    public class Manufacturer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(ManifacturersNameMaxLength)]
        public string? Name { get; set; }

        [StringLength(ManifacturersCountryMaxLength)]
        public string? Country { get; set; }

        //public Product Product { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();

        //public IList<Model> Models { get; set; } = new List<Model>();
    }
}
