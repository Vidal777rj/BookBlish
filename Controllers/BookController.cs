using BookBlish.Models;
using BookBlish.Services.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookBlish.Controllers;

[ApiController, Route("api")]
public class BookController : ControllerBase
{
    private readonly IBookService  _bookService;
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost, Route("createbook")]
    public async Task<IActionResult> CreateBook([FromBody] BookModel book)
    {
        try
        {
            await _bookService.AddBook(book);
            return CreatedAtAction(nameof(CreateBook), new { id = book.Id }, book);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet, Route("getallbook")]
     public async Task<ActionResult<List<BookModel>>> GetAllBooks()
    {
        var books = await _bookService.GetAllBooks(); // Chama o método do serviço
        if (books == null || !books.Any())
            return NotFound("Nenhum livro encontrado.");

        return Ok(books);
    }
}