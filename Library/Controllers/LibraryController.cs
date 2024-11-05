using LibraryCorner.Models;
using LibraryCorner.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryCorner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly LibraryRepository libraryRepository;

        public LibraryController(LibraryRepository libraryRepository)
        {
            this.libraryRepository = libraryRepository;
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(libraryRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Add(Library library)
        {
            libraryRepository.Add(library);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Library library)
        {
            libraryRepository.Update(library);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(libraryRepository.GetAll());
        }

        [HttpDelete]
        public IActionResult Delete(Library library)
        {
            libraryRepository.Delete(library);
            return Ok();
        }
    }
}
