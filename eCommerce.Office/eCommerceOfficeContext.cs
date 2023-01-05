using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Office {
    public class eCommerceOfficeContext : DbContext {

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Sector>? Sectors { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<Team>? Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerceOffice;Integrated Security=True;");
        }
    }
}
