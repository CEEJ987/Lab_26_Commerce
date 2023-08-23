using Duende.IdentityServer.EntityFramework.Options;
using Lab_26_Commerce.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lab_26_Commerce.Data
{
    public class Lab26DBContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }

        public Lab26DBContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }
    }
}