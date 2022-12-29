using eCommerce.API.Database;

namespace eCommerce.API.EFCore.Repositories
{
    // UserController > IUserRepository (Abstraction) > UserRepository
    public class UserRepository : IUserRepository {

        private readonly eCommerceContext _db;

        public UserRepository(eCommerceContext db) {
            _db = db;
        }

        public List<User> GetUsers() {
            return _db.Users.OrderBy(u => u.Id).ToList();
        }

        public User GetUser(int id) {
            return _db.Users.Find(id)!;
        }

        public void InsertUser(User user) {
            // Unit of Works
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void UdateUser(User user) {
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public void DeleteUser(int id) {
            _db.Users.Remove(GetUser(id));
            _db.SaveChanges();
        }
    }
}
