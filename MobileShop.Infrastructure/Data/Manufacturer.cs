namespace MobileShop.Infrastructure.Data
{
    using System;

    public class Manufacturer
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? Name { get; set; }

        public string? Country { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();

        //public IList<Model> Models { get; set; } = new List<Model>();
    }
}
