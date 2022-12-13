using eCommerce.API.EFCore.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.EFCore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository) {
            _repository = repository;
        }

        // {site}/api/users
        [HttpGet]
        public IActionResult GetUsers() {
            List<User> users = _repository.GetUsers();
            return Ok(users); // convert a object list in json
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id) {
            User user = _repository.GetUser(id);
            if (user == null) return NotFound("Não Encontrado!");
            return Ok(user);
        }

        [HttpPost]
        public IActionResult InsertUser([FromBody]User user) {
            _repository.InsertUser(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody]User user, int id) {
            _repository.UdateUser(user);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) {
            _repository.DeleteUser(id);
            return Ok();
        }
    }
}
