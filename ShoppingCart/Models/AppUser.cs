using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
