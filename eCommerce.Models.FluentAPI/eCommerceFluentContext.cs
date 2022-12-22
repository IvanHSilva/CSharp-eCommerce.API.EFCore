using eCommerce.Models.FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.FluentAPI {
    public class eCommerceFluentContext : DbContext {

        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
    }
}
