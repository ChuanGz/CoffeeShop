using CoffeeShop.GraphQL.CodeFirstDB;
using HotChocolate;

namespace CoffeeShop.GraphQL.Query
{
    public class BeverageQuery
    {
        public IQueryable<Beverage> GetBeverages([Service] CoffeeShopApplicationDbContext context) => context.Beverages;
    }
}
