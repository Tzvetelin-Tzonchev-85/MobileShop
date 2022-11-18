namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Model
    {
        public Guid Id { get; set; } = Guid.NewGuid();


        public string? TypeBatery { get; set; }

        public int Size { get; set; }

        
    }
}
