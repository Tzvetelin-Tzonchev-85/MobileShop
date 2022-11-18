namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Accessory
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? Color { get; set; }

        public int Amount { get; set; }
    }
}
