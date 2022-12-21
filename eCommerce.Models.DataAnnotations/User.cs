using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models {

    // Schema:
    // [Table] -> Nome da tabela
    // [Column] -> Nome do campo
    // [NotMapped] -> Não mapear
    // [ForeignKey] -> Vínculo da chave estrangeira
    // [InverseProperty] -> Define a referência para cada FK vinda da mesma tabela
    // [DatabaseGenerated] -> Define campos gerenciados pelo Banco de Dados ou não

    // DataAnnotations:
    // [Key] -> Define que o campo é a PK (chave primária)
    // [Index] -> Define ou cria um Índice na tabela (unique)

    // Mappers: DataAnnotations, FluentAPI
    // Code-First -> Código primeiro, a aplicação cria o Banco de Dados
    // DataBase-First -> Banco de Dados primeiro, a aplicação é feita de acordo com ele

    [Table("Usuarios")]
    public class User {
        // Attributes
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        [Column("Nome")]
        public string Name { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        [Column("Sexo")]
        public string Gender { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        [Column("Filiacao")] 
        public string Filiation { get; set; } = string.Empty;
        [Column("Situacao")]
        public string Situation { get; set; } = string.Empty;
        [Column("DataCad")]
        public DateTime RegDate { get; set; }

        // Compositions
        //[ForeignKey("UsuId")]
        public Contact? Contact { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Department>? Departments { get; set; }

        // Constructors
        public User() { }

        public User(int id, string name, string eMail, string gender, string rg, string cpf, string filiation, string situation, DateTime regDate) {
            Id = id;
            Name = name;
            EMail = eMail;
            Gender = gender;
            RG = rg;
            CPF = cpf;
            Filiation = filiation;
            Situation = situation;
            RegDate = regDate;
        }
    }
}
