using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.GraphQL.CodeFirstDB
{
    public class Beverage
    {
        public int BeverageId { get; set; }

        [Required]
        [StringLength(200)]
        public string BeverageName { get; set; }

        public double BasePrice { get; set; }
        public double SalesPrice { get; set; }
    }
}
