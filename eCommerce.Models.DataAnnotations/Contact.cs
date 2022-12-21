using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    
    [Table("Contatos")]
    public class Contact {

        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("UsuId")]
        [ForeignKey("Usu")]
        [Required]
        public int UserId { get; set; }
        [Column("Telefone")]
        [MaxLength(15)]
        public string Phone { get; set; } = string.Empty;
        [Column("Celular")]
        [MaxLength(15)]
        public string CellPhone { get; set; } = string.Empty;

        // Navigation
        //[ForeignKey("UsuId")]
        public User User { get; set; } = null!;

        // Constructors
        public Contact() { }

        public Contact(int id, int userId, string phone, string cellPhone) {
            Id = id;
            UserId = userId;
            Phone = phone;
            CellPhone = cellPhone;
        }
    }
}
