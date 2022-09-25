using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesDeliveryApp.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        public int StoreID { get; set; }
        public string OrderDetails { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}