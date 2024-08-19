using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAndDrink.Payment
{
    public class Payments
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PaymentMethod { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal Amount { get; set; }

    }
}
