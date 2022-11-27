namespace MobileShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MobileShop.Infrastructure.Data;
    using MobileShop.Models.Products;
    using System.Collections.Generic;

    public class ProductsController : Controller
    {
        private readonly MobileShopDbContext data;

        public ProductsController(MobileShopDbContext data)
        => this.data = data;

        public IActionResult Add() => View(new AddProductsFormModel
        {
            Categories = this.GetProductCategories(),
            Manifactures = this.GetProductManifactures(),
            Models = this.GetProductModels(),
        });



        [HttpPost]

        public IActionResult Add(AddProductsFormModel product)
        {
            if (!this.data.Categories.Any(c => c.Id == product.CategoryId))
            {
                this.ModelState.AddModelError(nameof(product.CategoryId), "Category does not exist.");
            }
            //Don't work with decimal!!
            if (ModelState.IsValid)
            {
                product.Categories = this.GetProductCategories();

                return View(product);
            }

            if (!this.data.Manufactures.Any(m => m.Id == product.ManifacturerId))
            {
                this.ModelState.AddModelError(nameof(product.ManifacturerId), "Manifacturer does not exist.");
            }
            //Don't work with decimal!!
            if (ModelState.IsValid)
            {
                product.Manifactures = this.GetProductManifactures();

                return View(product);
            }

            if (!this.data.Models.Any(m => m.Id == product.ModelId))
            {
                this.ModelState.AddModelError(nameof(product.ModelId), "Model does not exist.");
            }
            //Don't work with decimal!!
            if (ModelState.IsValid)
            {
                product.Models = this.GetProductModels();

                return View(product);
            }


            var productData = new Product
            {
                Name = product.Name,
                Dimension = product.Dimension,
                OperationSystem = product.OperationSystem,
                Colour = product.Colour,
                Price = product.Price,
                CategoryId = product.CategoryId,
                ManufacturerId = product.ManifacturerId,
                ModelId = product.ModelId
            };



            this.data.Products.Add(productData);

            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<ProductCategoryViewModel> GetProductCategories()
            => this.data
            .Categories
            .Select(c => new ProductCategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();

        private IEnumerable<ProductManifacurerViewModel> GetProductManifactures()
           => this.data
           .Manufactures
           .Select(c => new ProductManifacurerViewModel
           {
               Id = c.Id,
               Name = c.Name,
               Country = c.Country,
           })
           .ToList();

        private IEnumerable<ProductModelViewModel> GetProductModels()
           => this.data
           .Models
           .Select(m => new ProductModelViewModel
           {
               Id = m.Id,
               TypeBatery = m.TypeBatery,
               Size = m.Size,
           })
           .ToList();

    }
}
