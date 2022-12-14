namespace eCommerce.Models {
    public class Department {
        // Attributes
        public int Id { get; set; }
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
