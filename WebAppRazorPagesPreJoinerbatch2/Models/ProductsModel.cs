using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesPreJoinerbatch2.Models
{
    public class ProductsModel
    {
        [Key]
        public int PID { get; set; }
        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }
    }
}
