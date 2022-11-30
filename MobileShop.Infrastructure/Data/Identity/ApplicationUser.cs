namespace MobileShop.Infrastructure.Data.Identity
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.ApplicationUser;

    public class ApplicationUser : IdentityUser
    {
        [StringLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [StringLength(LastNameMaxLength)]
        public string? LastName { get; set; }
    }
}
