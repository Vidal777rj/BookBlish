using BookBlish.Enums;

namespace BookBlish.Models;

public class BookModel
{
    public int  Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int PublicationDate { get; set; }
    public BookGenre Genre  { get; set; }
    public string? CoverImage { get; set; }
}