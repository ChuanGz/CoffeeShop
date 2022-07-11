namespace CoffeeShop.GraphQL.Mutation
{
    public record AddBeverageInput(
        int beverageId,
        string beverageName,
        double basePrice,
        double salesPrice);
}
