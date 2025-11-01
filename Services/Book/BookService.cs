using BookBlish.Models;
using BookBlish.Repositories;

namespace BookBlish.Services.Book;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    public async Task AddBook(BookModel book)
    {
        await _bookRepository.AddAsync(book);
    }

    public async Task<List<BookModel>> GetAllBooks()
    {
        return await _bookRepository.GetAllAsync();
    }

    public Task<BookModel> GetBookById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookModel>> GetBooksByGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBook(BookModel book)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBook(int id)
    {
        throw new NotImplementedException();
    }
}