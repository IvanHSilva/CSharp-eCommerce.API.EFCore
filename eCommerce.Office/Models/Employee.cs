namespace eCommerce.Office.Models {
    public class Employee {

        // Attributes
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Constructors
        public Employee() {}

        // Compposition
        public ICollection<Vehicle>? Vehicles { get; set; }
        public ICollection<Sector>? Sectors { get; set; }
        public ICollection<Team>? Teams { get; set; }

        public Employee(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
