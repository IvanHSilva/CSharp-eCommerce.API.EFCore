using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    public class Contact {

        // Attributes
        [Key]
        public int Id { get; set; }
        [ForeignKey("Usu")]
        public int UserId { get; set; }
        public string Phone { get; set; } = string.Empty;
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
