using Microsoft.EntityFrameworkCore;

namespace FoodAndDrink.Customer
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customers> Customers { get; set; }
    }
}
