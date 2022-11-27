namespace MobileShop.Core.Models.Products
{
    using System;

    public class AddProductsFormModel
    {
        public Guid CategoryId { get; set; }

        public string? Name { get; set; }

        public int Dimension { get; set; }

        public string? OperationSystem { get; set; }

        public string? Colour { get; set; }

        public decimal Price { get; set; }

    }
}
