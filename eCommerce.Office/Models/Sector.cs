namespace eCommerce.Office.Models {
    public class Sector {
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Composition
        public ICollection<Employee>? Employees { get; set; }

        // Constructors
        public Sector() { }

        public Sector(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
