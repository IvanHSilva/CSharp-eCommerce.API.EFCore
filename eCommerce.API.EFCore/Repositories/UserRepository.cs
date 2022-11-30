using eCommerce.Models;

namespace eCommerce.API.EFCore.Repositories {
    public class UserRepository : IUserRepository {

        // Fake user list
        public static List<User> _db = new List<User>();

        public List<User> GetUsers() {
            return _db;
        }

        public User GetUser(int id) {
            return _db.Find(u => u.Id == id)!;
        }

        public void InsertUser(User user) {
            _db.Add(user);
        }

        public void UdateUser(User user) {
            _db.Remove(GetUser(user.Id));
            _db.Add(user);
        }

        public void DeleteUser(int id) {
            _db.Remove(GetUser(id));
        }
    }
}
