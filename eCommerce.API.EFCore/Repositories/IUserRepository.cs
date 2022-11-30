using eCommerce.Models;

namespace eCommerce.API.EFCore.Repositories {
    public interface IUserRepository {

        public List<User> GetUsers();
        public User GetUser(int id);
        public void InsertUser(User user);
        public void UdateUser(User user);
        public void DeleteUser(int id);

    }
}
