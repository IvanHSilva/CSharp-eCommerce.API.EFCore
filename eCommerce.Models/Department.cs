namespace eCommerce.Models {
    public class Department {
        // Attributes
        public int Id { get; set; }
        public string? Name { get; set; }

        // Navigation
        public IEnumerable<User>? Users { get; set; }

        // Constructors
        public Department() { }

        public Department(int id, string? name) {
            Id = id;
            Name = name;
        }
    }
}
