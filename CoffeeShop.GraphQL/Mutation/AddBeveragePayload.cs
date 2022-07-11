using CoffeeShop.GraphQL.CodeFirstDB;

namespace CoffeeShop.GraphQL.Mutation
{
    public class AddBeveragePayload
    {
        public AddBeveragePayload(Beverage beverage)
        {
            Beverage = beverage;
        }

        public Beverage Beverage { get; }
    }
}
