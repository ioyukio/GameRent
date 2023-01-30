using Microsoft.AspNetCore.Identity;

namespace GameRent.Models.Domain
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }    
    }
}
