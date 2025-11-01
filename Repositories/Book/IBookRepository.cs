using BookBlish.Enums;
using BookBlish.Models;

namespace BookBlish.Repositories;

public interface IBookRepository
{
    Task AddAsync(BookModel book);    

    Task<List<BookModel>> GetAllAsync(); 

    Task<BookModel> GetByIdAsync(int id);

    Task<List<BookModel>> GetByGenreAsync(BookGenre genre);

    Task<bool> UpdateAsync(int id, BookModel book); 

    Task<bool> DeleteAsync(int id); 
}