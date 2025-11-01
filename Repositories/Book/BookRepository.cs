using BookBlish.Database;
using BookBlish.Enums;
using BookBlish.Models;
using Microsoft.EntityFrameworkCore;

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
        await _context.Books.AddAsync(book);;
        await _context.SaveChangesAsync();
    }

    public async Task<List<BookModel>> GetAllAsync()
    {
        try
        {
            return await _context.Books.AsNoTracking().ToListAsync();
    }
        catch(Exception ex)
        {
            throw new ApplicationException($"Erro ao buscar os todos os livros : {ex}");
        }
    }

    public async Task<BookModel> GetByIdAsync(int id)
    {
        try
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
        }catch(Exception ex)
        {
            throw new Exception($"Erro ao buscar livro pelo ID : {ex}");
        }
    }

    public async Task<List<BookModel>> GetByGenreAsync(BookGenre genre)
    {
        try
        {
            return await _context.Books.AsNoTracking().Where(b => b.Genre == genre).ToListAsync();
        }
        catch(Exception ex)
        {
            throw new Exception($"Erro ao buscar livros pelo genero : {ex}");
        }
    }

    public async Task<bool> UpdateAsync(int id, BookModel book)
    {
    try
    {
            var existingBook = await _context.Books.FindAsync(book.Id);
            if (existingBook == null)
                return false;

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublicationDate = book.PublicationDate;
            existingBook.Genre = book.Genre;
            existingBook.CoverImage = book.CoverImage;

            await _context.SaveChangesAsync();
            return true;
    }catch(Exception ex)
    {
            throw new Exception($"Erro ao modificar livro : {ex}");
    }
    }

    public async Task<bool> DeleteAsync(int id)
    {
      try
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return false; 

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true; 
        }catch(Exception ex)
    {
            throw new Exception($"Erro ao deletar livro : {ex}");
    }
    }
}