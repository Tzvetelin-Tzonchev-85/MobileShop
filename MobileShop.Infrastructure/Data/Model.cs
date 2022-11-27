namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Data.DataConstants.Model;

    public class Model
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(ModelsTypeBateryMaxLength)]
        public string? TypeBatery { get; set; }

        public int Size { get; set; }

        
    }
}
