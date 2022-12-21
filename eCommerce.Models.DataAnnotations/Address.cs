using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {
    
    [Table("Enderecos")]
    public class Address {
        // Attributes
        [Key]
        public int Id { get; set; }
        [Column("UsuId")]
        [ForeignKey("Usu")]
        [Required]
        public int UserId { get; set; }
        [Column("Descricao")]
        [Required, MaxLength(100)]
        public string Description { get; set; } = string.Empty;
        [Column("Endereco")]
        [Required, MaxLength(150)]
        public string Street { get; set; } = string.Empty;
        [Column("Numero")]
        [MaxLength(10)]
        public string Number { get; set; } = string.Empty;
        [Column("Complemento")]
        [MaxLength(30)]
        public string Comp { get; set; } = string.Empty;
        [Column("Bairro")]
        [Required, MaxLength(50)]
        public string District { get; set; } = string.Empty;
        [Column("Cidade")]
        [Required, MaxLength(60)]
        public string City { get; set; } = string.Empty;
        [Column("Estado")]
        [Required, MaxLength(2)]
        public string State { get; set; } = string.Empty;
        [Column("CEP")]
        [Required, MaxLength(10)]
        public string ZipCode { get; set; } = string.Empty;

        // Navigation
        public User User { get; set; } = null!;

        // Constructors
        public Address() { }

        public Address(int id, int userId, string description, string street, string number, string comp, string district, string city, string state, string zipCode) {
            Id = id;
            UserId = userId;
            Description = description;
            Street = street;
            Number = number;
            Comp = comp;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
