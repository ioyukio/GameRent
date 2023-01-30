using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameRent.Models.Domain
{
    public class DataBContext : IdentityDbContext<AppUser>
    {
        public DataBContext(DbContextOptions<DataBContext> options) : base(options)
        {

        }
    }
}
