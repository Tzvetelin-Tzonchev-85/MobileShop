namespace MobileShop.Core
{
    using MobileShop.Core.CustomAttributes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestViewModel
    {
        public DateTime FirstDate { get; set; }

        [IsBefore(nameof(FirstDate), errorMessage:"Boom")]
        public DateTime SecondDate { get; set; }
    }
}
