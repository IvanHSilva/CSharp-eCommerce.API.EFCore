using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database {
    
    public class eCommerceContext : DbContext {
        // Connection without 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;");
        }
    }
}