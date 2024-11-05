using LibraryCorner.Models;
using LibraryCorner.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryCorner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository userRepository) 
        {
            this.userRepository = userRepository;
        }

        [HttpDelete]
        public IActionResult Delete(User user)
        {
            userRepository.Delete(user);
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(userRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            userRepository.Add(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            userRepository.Update(user);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(userRepository.GetAll());
        }
    }
}
