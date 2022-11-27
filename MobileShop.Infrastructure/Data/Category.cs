namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Category;
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        //[Required]
        //[StringLength(50)]
        //public string? Brand { get; set; }

        [Required]
        [StringLength(CategoriesNameMaxLength)]
        public string? Name { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
