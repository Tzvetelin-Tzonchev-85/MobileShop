namespace MobileShop.Models.Products
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static MobileShop.Infrastructure.Data.DataConstants.Product;
    public class AddProductsFormModel
    {

        [Required]
        [StringLength(ProductsColourMaxLenth, MinimumLength = ProductsNameMinLength, ErrorMessage = "Maximum {0}")]
        [Display(Name = "Име")]
        public string? Name { get; set; }

        [Display(Name = "Размери")]
        public int Dimension { get; set; }

        [Required]
        [StringLength(ProductsOperationSystemMaxLength, MinimumLength = ProductsOperationSystemMinLength, ErrorMessage = "Maximum {0}")]
        [Display(Name = "Операционна система")]
        public string? OperationSystem { get; set; }

        [Required]
        [StringLength(ProductsColourMaxLenth, MinimumLength = ProductsColourMinLenth, ErrorMessage = "Maximum {0}")]
        [Display(Name = "Цвят")]
        public string? Colour { get; set; }

        [Display(Name = "Цена")]
        //[Range(200, 2000)]
        public double Price { get; set; }

        [Display(Name = "Категория")]
        public Guid CategoryId { get; set; }

        [Display(Name = "Производител")]
        public Guid ManifacturerId { get; set; }

        [Display(Name = "Тип на батерията")]
        public Guid ModelId { get; set; }

        public IEnumerable<ProductCategoryViewModel> Categories { get; set; }
        public IEnumerable<ProductManifacurerViewModel> Manifactures { get; set; }
        public IEnumerable<ProductModelViewModel> Models { get; set; }
    }
}
