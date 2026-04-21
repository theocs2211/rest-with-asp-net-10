using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Data.DTO.V1;
using RestWithASPNET10.Services;

namespace RestWithASPNET10.Controllers.V1
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _service;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService service, ILogger<BookController> logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<BookDTO>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult FindAll()
        {
            _logger.LogInformation("Fetching all books");
            return Ok(_service.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(BookDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult FindById(int id)
        {
            _logger.LogInformation($"Fetching book with id {id}");
            var book = _service.FindById(id);
            if (book == null)
            {
                _logger.LogWarning($"Book with ID {id} not found");
                return NotFound();
            }
            _logger.LogInformation($"Book with id {id} found");
            return Ok(book);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(BookDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Create([FromBody] BookDTO book)
        {
            _logger.LogInformation($"Creating new book: {book.Title}");
            var createdBook = _service.Create(book);
            if (createdBook == null) 
            {
                _logger.LogError($"Failed to create book with title {book.Title}");
                return NotFound();
            }
            _logger.LogInformation($"Book with title {book.Title} Created Successfully");
            return Ok(createdBook);
        }

        [HttpPut] 
        [ProducesResponseType(200, Type = typeof(BookDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Update([FromBody] BookDTO book)
        {
            _logger.LogInformation($"Updating book with id {book.Id}");
            var updatedBook = _service.Update(book);
            if (updatedBook == null)
            {
                _logger.LogError($"Failed to update book with ID {book.Id}");
                return NotFound();
            }
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Deleting book with id {id}");
            _service.Delete(id);
            _logger.LogInformation($"Book with id {id} Deleted successfully");
            return NoContent();
        }
    }
}
