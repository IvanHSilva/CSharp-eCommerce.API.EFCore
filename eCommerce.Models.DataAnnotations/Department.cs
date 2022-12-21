using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    
    [Table("Departamentos")]
    public class Department {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("Nome")]
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // Navigation
        public IEnumerable<User> Users { get; set; } = null!;

        // Constructors
        public Department() { }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
