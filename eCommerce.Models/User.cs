namespace eCommerce.Models {
    public class User {
        // Attributes
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? EMail { get; set; }
        public string? Gender { get; set; }
        public string? RG { get; set; }
        public string? CPF { get; set; }
        public string? Filiation { get; set; }
        public string? Situation { get; set; }
        public DateTime RegDate { get; set; }

        // Compositions
        public Contact? Contact { get; set; }

        // Constructors
        public User() { }

        public User(int id, string name, string? eMail, string? gender, string? rG, string? cPF, string? filiation, string? situation, DateTime regDate) {
            Id = id;
            Name = name;
            EMail = eMail;
            Gender = gender;
            RG = rG;
            CPF = cPF;
            Filiation = filiation;
            Situation = situation;
            RegDate = regDate;
        }
    }
}
