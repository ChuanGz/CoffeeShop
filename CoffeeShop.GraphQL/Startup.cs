using CoffeeShop.GraphQL.CodeFirstDB;
using CoffeeShop.GraphQL.Mutation;
using CoffeeShop.GraphQL.Query;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.GraphQL
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CoffeeShopApplicationDbContext>(options => options.UseSqlite("Data Source=CoffeeShop.db"));

            services.AddGraphQLServer()
                    .AddQueryType<BeverageQuery>()
                    .AddMutationType<BeverageMutation>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
