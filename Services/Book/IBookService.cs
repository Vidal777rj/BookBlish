using BookBlish.DTO.Book;
using BookBlish.Models;

namespace BookBlish.Services.Book;

public interface IBookService
{
    Task AddBook(BookModel book);
    Task<List<BookModel>> GetAllBooks();
    Task<BookModel> GetBookById(int id);
    Task<List<BookModel>> GetBooksByGenre(string genre);
    Task UpdateBook(BookModel book);
    Task DeleteBook(int id);
}