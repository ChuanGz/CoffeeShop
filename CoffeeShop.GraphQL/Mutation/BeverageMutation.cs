using CoffeeShop.GraphQL.CodeFirstDB;
using HotChocolate;

namespace CoffeeShop.GraphQL.Mutation
{
    public class BeverageMutation
    {
        public async Task<AddBeveragePayload> AddSpeakerAsync(
            AddBeverageInput input,
            [Service] CoffeeShopApplicationDbContext context)
        {
            var beverage = new Beverage
            {
                BeverageId = input.beverageId,
                BeverageName = input.beverageName,
                BasePrice = input.basePrice,
                SalesPrice = input.salesPrice
            };

            context.Beverages.Add(beverage);
            await context.SaveChangesAsync();

            return new AddBeveragePayload(beverage);
        }
    }
}
