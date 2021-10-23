using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SMARTECOMM.Infrastructure.Context
{
    public class DataBaseContext : IdentityDbContext /*DbContext*/
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Seed()
        }
    }
}
