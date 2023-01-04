namespace eCommerce.Office.Models {
    public class Team {
        
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Composition
        public ICollection<Employee>? Employees { get; set; }

        // Constructors
        public Team() {}

        public Team(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
