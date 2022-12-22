namespace eCommerce.Models.FluentAPI.Models
{
    public class Contact
    {

        // Attributes
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;

        // Navigation
        public User User { get; set; } = null!;

        // Constructors
        public Contact() { }

        public Contact(int id, int userId, string phone, string cellPhone)
        {
            Id = id;
            UserId = userId;
            Phone = phone;
            CellPhone = cellPhone;
        }
    }
}
