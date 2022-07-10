using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.GraphQL.CodeFirstDB
{
    public class Beverage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Catalog { get; set; }

        public double BasePrice { get; set; }
        public double SalesPrice { get; set; }
    }
}
