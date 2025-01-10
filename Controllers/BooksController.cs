using Microsoft.AspNetCore.Mvc;
using SUMMARIES.Data;

namespace SUMMARIES.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            try
            {
                if (book.Author != null && book.Author != null && book.Description != null)
                {
                    _service.AddBook(book);
                    return Ok();
                }
                return BadRequest("Book was not added");

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookById(id);
            return Ok(book);
        }
    }
}
