using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesPreJoinerbatch2.Models
{
    // table 
    public class Employee
    {
        // pk and auto 
        [Key]
        public int Eid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
