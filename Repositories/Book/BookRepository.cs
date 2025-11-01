using BookBlish.Database;
using BookBlish.Models;

namespace BookBlish.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;
    public BookRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(BookModel book)
    {
        if (book is null)
            throw new ArgumentNullException(nameof(book));
        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
    }

    public Task<List<BookModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BookModel> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookModel>> GetByGenreAsync(string genre)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, BookModel book)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}