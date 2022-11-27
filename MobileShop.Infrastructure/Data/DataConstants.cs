namespace MobileShop.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DataConstants
    {
        public class Accessory
        {
            public const int AccessoriesNameMaxLength = 100;
            public const int AccessoriesColorMaxLenth = 10;
        }

        public class Category
        {
            public const int CategoeriesNameMinLength = 2;
            public const int CategoriesNameMaxLength = 50;
        }

        public class Manufacturer
        {
            public const int ManufacturerNameMinLength = 2;
            public const int ManifacturersNameMaxLength = 50;
            public const int ManifacturersCountryMinLetgth = 3;
            public const int ManifacturersCountryMaxLength = 30;
        }

        public class Model
        {
            public const int ModelsTypeBateryMaxLength = 20;
        }

        public class Product
        {
            public const int ProductsNameMinLength = 2;
            public const int ProductsNameMaxLength = 100;
            public const int ProductsOperationSystemMinLength = 5;
            public const int ProductsOperationSystemMaxLength = 30;
            public const int ProductsColourMinLenth = 3;
            public const int ProductsColourMaxLenth = 10;
        }
    }
}
