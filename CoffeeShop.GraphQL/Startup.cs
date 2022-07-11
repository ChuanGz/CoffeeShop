using CoffeeShop.GraphQL.CodeFirstDB;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.GraphQL
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CoffeeShopApplicationDbContext>(options => options.UseSqlite("Data Source=CoffeeShop.db"));
        }
    }
}
