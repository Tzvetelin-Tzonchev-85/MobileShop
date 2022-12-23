namespace MobileShop.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string? LastName { get; set; }
    }
}
