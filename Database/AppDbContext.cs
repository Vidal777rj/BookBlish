using BookBlish.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBlish.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<BookModel> Books { get; set; }
}