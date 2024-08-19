using Microsoft.EntityFrameworkCore;

namespace FoodAndDrink.Payment
{
    public class PaymentsDbContext: DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> pickups)
            : base(pickups)
        { 

        }
        public DbSet<Payments> Payments { get; set; }
    }

}
