using System.ComponentModel.DataAnnotations.Schema;

namespace BookNestApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
