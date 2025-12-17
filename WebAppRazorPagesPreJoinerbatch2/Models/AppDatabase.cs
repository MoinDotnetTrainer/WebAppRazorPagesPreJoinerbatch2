using Microsoft.EntityFrameworkCore;

namespace WebAppRazorPagesPreJoinerbatch2.Models
{
    public class AppDatabase : DbContext  // instance to db
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_WebAppPreJoinerb2;Integrated security=true;TrustServerCertificate=true");
        }
        public DbSet<Employee> employee { get; set; }  // reprsernt a table
        public DbSet<ProductsModel> productsModels { get; set; }

    }
}
