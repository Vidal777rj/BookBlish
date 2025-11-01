using System.ComponentModel.DataAnnotations;
using BookBlish.Enums;

namespace BookBlish.DTO.Book;

public class BookCreateDto
{
    [Required(ErrorMessage = "Insira o titulo do livro"), MaxLength(50)]
    public string? Title { get; set; }
    
    [Required(ErrorMessage = "Insira o autor do livro"), MaxLength(50)]
    public string? Author { get; set; }
    
    [Required(ErrorMessage = "Insira o ano de lançamento livro"), MaxLength(5)]
    public int PublicationDate { get; set; }
    
    [Required(ErrorMessage = "Escolha o genero literario  livro"), MaxLength(40)]
    public BookGenre Genre  { get; set; }
    
    public string? CoverImage { get; set; }
}