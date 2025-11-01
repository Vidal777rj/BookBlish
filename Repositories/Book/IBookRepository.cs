using BookBlish.Models;

namespace BookBlish.Repositories;

public interface IBookRepository
{
    Task AddAsync(BookModel book);    

    Task<List<BookModel>> GetAllAsync(); 

    Task<BookModel> GetByIdAsync(int id);

    Task<List<BookModel>> GetByGenreAsync(string genre);

    Task UpdateAsync(int id, BookModel book); 

    Task DeleteAsync(int id); 
}