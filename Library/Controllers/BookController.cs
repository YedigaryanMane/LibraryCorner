using LibraryCorner.Models;
using LibraryCorner.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryCorner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(bookRepository.Get(id));
        }

        [HttpPut]
        public IActionResult Update(Book book)
        {
            bookRepository.Update(book);
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            bookRepository.Add(book);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Book book)
        {
            bookRepository.Delete(book);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(bookRepository.GetAll());
        }
    }
}
