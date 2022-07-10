using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.GraphQL.CodeFirstDB
{
    public class CoffeeShopApplicationDbContext : DbContext
    {
        public CoffeeShopApplicationDbContext(DbContextOptions<CoffeeShopApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Beverage> Beverages { get; set; }
    }
}
