

namespace uBiblioteksystem;

public class Book(string bookTitle, string bookAuthor, string bookGenre, string bookIsbn)
{
  public string Title = bookTitle;
  public string Author = bookAuthor;
  public string Genre = bookGenre;
  public string ISBN = bookIsbn;

  public override string ToString()
  {
    return $"\nBook: {Utilities.Capitalize(Title)}\nAuthor: {Utilities.Capitalize(Author)}\nGenre: {Utilities.Capitalize(Genre)}\nISBN: {Utilities.Capitalize(ISBN)}\n";
  }


}