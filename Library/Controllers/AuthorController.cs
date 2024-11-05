using LibraryCorner.Models;
using LibraryCorner.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryCorner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorRepository authorRepository;

        public AuthorController(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(authorRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            authorRepository.Add(author);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(Author author)
        {
            return Ok(authorRepository.GetAll());
        }

        [HttpDelete]
        public IActionResult Delete(Author author)
        {
            authorRepository.Delete(author);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Author author)
        {
            authorRepository.Update(author);
            return Ok();
        }

    }
}
