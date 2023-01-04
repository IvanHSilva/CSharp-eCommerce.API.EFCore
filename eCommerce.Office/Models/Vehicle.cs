namespace eCommerce.Office.Models {
    public class Vehicle {
        
        // Attributes
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Plate { get; set; } = null!;

        // Compposition
        public ICollection<Employee>? Employees { get; set; }

        // Constructors
        public Vehicle() {}

        public Vehicle(int id, string model, string plate) {
            Id = id;
            Model = model;
            Plate = plate;
        }
    }
}
