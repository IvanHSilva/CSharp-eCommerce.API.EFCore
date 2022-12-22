namespace eCommerce.Models.FluentAPI.Models
{
    public class User
    {
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Filiation { get; set; } = string.Empty;
        public string Situation { get; set; } = string.Empty;
        public DateTime RegDate { get; set; }

        // Compositions
        public Contact? Contact { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Department>? Departments { get; set; }

        // Constructors
        public User() { }

        public User(int id, string name, string eMail, string gender, string rg, string cpf, string filiation, string situation, DateTime regDate)
        {
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
