using eCommerce.Models.FluentAPI.Configurations;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.FluentAPI
{
    public class eCommerceFluentContext : DbContext {

        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //modelBuilder.Entity<User>().ToTable("Usuarios");
            //modelBuilder.Entity<User>().HasKey(u => u.Id);
            //modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedNever();
            //modelBuilder.Entity<User>().Property(u => u.Name).HasColumnName("Nome").HasMaxLength(80).IsRequired();
            //modelBuilder.Entity<User>().HasIndex(u => u.Name).HasDatabaseName("Idx_Usu_Nome");
            //modelBuilder.Entity<User>().HasAlternateKey(u => u.EMail);

            //modelBuilder.Entity<User>().HasOne(u => u.Contact).WithOne(c => c.User).HasForeignKey<Contact>(c => c.UserId).OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<User>().HasMany(u => u.Addresses).WithOne(a => a.User).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<User>().HasMany(u => u.Departments).WithMany(d => d.Users);
            modelBuilder.ApplyConfiguration(new UserConfigurations());
        }
    }
}
