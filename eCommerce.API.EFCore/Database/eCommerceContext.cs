using eCommerce.Models.FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{

    public class eCommerceContext : DbContext {

        // Connection without execution enviroment distinction
        #region connection
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlServer("Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;");
        //}
        #endregion

        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) {}

        public DbSet<User> Users  { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Department>().HasData(
                    new Department(1, "Informática"),
                    new Department(2, "Games"),
                    new Department(3, "Quadrinhos"),
                    new Department(4, "Livros"),
                    new Department(5, "Celulares"),
                    new Department(6, "Eletrônicos"),
                    new Department(7, "Som")
                );
        }
    }
}