using Microsoft.EntityFrameworkCore;

namespace FoodAndDrink.Product
{
    public class ProductsDbContext: DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> actions)
            :base(actions)
        {

        }

        public DbSet<Products> Product { get; set; }
    }
}
