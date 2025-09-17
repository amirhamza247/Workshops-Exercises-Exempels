
namespace uBiblioteksystem;

public class Library
{

  //  public List<Book> myBookList;
  public Dictionary<string, Book> myBookByIsbn = new Dictionary<string, Book>();

  public int BookAmount;

  public Library()
  {
    // myBookList = new List<Book>();

    myBookByIsbn.Add("111111", new Book("Ljuset", "Amir", "Science", "111111"));
    myBookByIsbn.Add("222222", new Book("Mörker", "Amir", "Science", "222222"));
    myBookByIsbn.Add("333333", new Book("Matlagning är livet", "Sabo", "Cooking", "333333"));
    myBookByIsbn.Add("444444", new Book("Rymden", "Tolkien", "Science", "444444"));
    myBookByIsbn.Add("555555", new Book("Mat är mat", "Sabo", "Cooking", "555555"));


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
    bool isbnRunning = true;
    Console.WriteLine("Print this before loop!");
    string inputIsbn = "";

    while (isbnRunning)
    {
      inputIsbn = Console.ReadLine()?.ToLower().Trim() ?? "";
      if (myBookByIsbn.ContainsKey(inputIsbn))
      {
        Utilities.Colorize(ConsoleColor.Red, "ISBN is taken, Try with another one:  ", "WriteLine");

      }
      else
      {

        break;
      }
    }


    Console.Write("book ISBN: ");
    Utilities.Colorize(ConsoleColor.Green, inputIsbn, "Write");
    Console.Write(" is saved!\n");

    Book mybook1 = new Book(inputTitle, inputAuthor, inputGenre, inputIsbn);
    myBookByIsbn.Add(mybook1.ISBN, mybook1);

    BookAmount++;


  }



  public void showAllBooks()
  {
    Console.WriteLine($"You have [{myBookByIsbn.Count}] books in your Library.");
    int num = 1;
    foreach ((string isbn, Book book) in myBookByIsbn)
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
    foreach ((string isbn, Book book) in myBookByIsbn)
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
    foreach ((string isbn, Book book) in myBookByIsbn)
    {
      if (book.Genre.ToLower().Trim() == genre.ToLower().Trim())
      {
        Console.WriteLine($"{num}: {Utilities.Capitalize(book.Title)}, by {Utilities.Capitalize(book.Author)}.");
        num++;
      }
    }
  }


  public void removeBook(string isbn)
  {


    foreach ((string num, Book book) in myBookByIsbn)
    {
      if (myBookByIsbn.ContainsKey(isbn))
      {
        Console.Write("book: ");
        Utilities.Colorize(ConsoleColor.Red, book.Title, "Write");
        Console.Write($", by {book.Author} is removed!\n");
        myBookByIsbn.Remove(isbn);
        break;
      }
      else
      {
        Console.WriteLine("Opps! the ISBN is incorrect.\nTry again:");
      }

    }
  }


}
