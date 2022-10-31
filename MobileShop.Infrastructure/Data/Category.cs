namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
  
        [Required]
        [StringLength(50)]
        public string? Brand { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
