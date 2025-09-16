
namespace uBiblioteksystem;

public class Library
{

  public List<Book> myBookList;
  public int BookAmount;

  public Library()
  {
    myBookList = new List<Book>()
    {
      new Book("Sagan om ringen", "Tolkien", "Fantasy", "9789173291580"),
      new Book("Mörker", "Amir", "Science", "9789173291590"),
      new Book("Matlagning är livet", "Sabo", "Cooking", "9789173291600"),
      new Book("Rymden", "Tolkien", "Science", "9789173291610"),
      new Book("Mat är mat", "Sabo", "Cooking", "9789173291620")
    }
    ;
    BookAmount = 0;
  }


  public void addBook()
  {
    Utilities.Colorize(ConsoleColor.DarkYellow, "\nEnter your book title:", "WriteLine");
    Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
    string inputTitle = Console.ReadLine()?.ToLower().Trim() ?? "";
    Console.Write("book title: ");
    Utilities.Colorize(ConsoleColor.Green, inputTitle, "Write");
    Console.Write(" is saved!\n");

    Utilities.Colorize(ConsoleColor.DarkYellow, "\nEnter your book author:", "WriteLine");
    Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
    string inputAuthor = Console.ReadLine()?.ToLower().Trim() ?? "";
    Console.Write("book author: ");
    Utilities.Colorize(ConsoleColor.Green, inputAuthor, "Write");
    Console.Write(" is saved!\n");

    Utilities.Colorize(ConsoleColor.DarkYellow, "\nEnter your book genre:", "WriteLine");
    Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
    string inputGenre = Console.ReadLine()?.ToLower().Trim() ?? "";
    Console.Write("book genre: ");
    Utilities.Colorize(ConsoleColor.Green, inputGenre, "Write");
    Console.Write(" is saved!\n");

    Utilities.Colorize(ConsoleColor.DarkYellow, "\nEnter your book ISBN:", "WriteLine");
    Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
    string inputIsbn = Console.ReadLine()?.ToLower().Trim() ?? "";
    Console.Write("book ISBN: ");
    Utilities.Colorize(ConsoleColor.Green, inputIsbn, "Write");
    Console.Write(" is saved!\n");

    Book mybook1 = new Book(inputTitle, inputAuthor, inputGenre, inputIsbn);
    myBookList.Add(mybook1);
    BookAmount++;


  }



  public void showAllBooks()
  {
    Console.WriteLine($"You have [{BookAmount}] books in your Library.");
    int num = 1;
    foreach (Book book in myBookList)
    {
      Console.WriteLine($"\nBook nr: {num}\n{book}\n");
      num++;
    }
  }

  public void showBookAuthor(string author)
  {
    Console.Clear();

    Console.WriteLine($"\nBooks filterd by author: {Utilities.Capitalize(author)}\n");
    int num = 1;
    foreach (Book book in myBookList)
    {
      if (book.Author.ToLower().Trim() == author.ToLower().Trim())
      {
        Console.WriteLine($"{num}: {Utilities.Capitalize(book.Title)}");
        num++;
      }
    }
  }

  public void showBooksGenre(string genre)
  {
    Console.Clear();
    Console.WriteLine($"\nBooks filterd by genre: {Utilities.Capitalize(genre)}\n");
    int num = 1;
    foreach (Book book in myBookList)
    {
      if (book.Genre.ToLower().Trim() == genre.ToLower().Trim())
      {
        Console.WriteLine($"{num}: {Utilities.Capitalize(book.Title)}, by {Utilities.Capitalize(book.Author)}.");
        num++;
      }
    }
  }


}
