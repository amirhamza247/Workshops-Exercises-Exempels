
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

  private string GetUserInput(string prompt)
  {
    string userInput;
    do
    {
      Utilities.Colorize(ConsoleColor.DarkYellow, $"\n{prompt}:", "WriteLine");
      Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
      userInput = Console.ReadLine()?.ToLower().Trim() ?? "";

    }
    while (!Utilities.EmptyCheck(userInput));

    if (userInput == "done")
    {
      return "done";
    }

    return userInput;
  }

  public void addBook()
  {
    while (true)
    {

      Utilities.Colorize(ConsoleColor.DarkYellow, "Write 'done' to exit.\n\n");
      string inputTitle = GetUserInput("Enter your book tilte");
      if (inputTitle == "done") { return; }

      Console.Write("book title: ");
      Utilities.Colorize(ConsoleColor.Green, inputTitle, "Write");
      Console.Write(" is saved!\n");

      string inputAuthor = GetUserInput("Enter your book author");
      if (inputAuthor == "done") { return; }

      Console.Write("book author: ");
      Utilities.Colorize(ConsoleColor.Green, inputAuthor, "Write");
      Console.Write(" is saved!\n");

      string inputGenre = GetUserInput("Enter your book genre");
      if (inputGenre == "done") { return; }

      Console.Write("book genre: ");
      Utilities.Colorize(ConsoleColor.Green, inputGenre, "Write");
      Console.Write(" is saved!\n");

      string inputIsbn = "";
      bool isbnRunning = true;
      while (isbnRunning)
      {
        inputIsbn = GetUserInput("Enter your book ISBN");
        if (inputIsbn == "done") { return; }

        if (myBookByIsbn.ContainsKey(inputIsbn))
        {
          Utilities.Colorize(ConsoleColor.Red, "ISBN is taken, Try with another one:  ", "WriteLine");

        }
        else
        {

          Console.Write("book ISBN: ");
          Utilities.Colorize(ConsoleColor.Green, inputIsbn, "Write");
          Console.Write(" is saved!\n");

          break;
        }
      }



      Book mybook1 = new Book(inputTitle, inputAuthor, inputGenre, inputIsbn);
      myBookByIsbn.Add(mybook1.ISBN, mybook1);

      break;


    }
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


  public void removeBook()
  {
    Utilities.Colorize(ConsoleColor.DarkYellow, "\nHere is all your books:");
    foreach ((string isbn, Book book) in myBookByIsbn)
    {
      Console.WriteLine($"\nBook: {book.Title}, by {book.Author}, ISBN:{book.ISBN}\n");

    }

    Utilities.Colorize(ConsoleColor.DarkYellow, "\nPlease write ISBN for the book you wan to remove!\n", "WriteLine");
    bool isRemoveRunning = true;
    while (isRemoveRunning)
    {
      Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
      string removeIsbn = Console.ReadLine()?.Trim() ?? "";


      if (removeIsbn != null && myBookByIsbn.TryGetValue(removeIsbn, out Book book))
      {
        Console.Write("book: ");
        Utilities.Colorize(ConsoleColor.Red, book.Title, "Write");
        Console.Write($", by {book.Author} is removed!\n");
        myBookByIsbn.Remove(removeIsbn);
        isRemoveRunning = false;

      }
      else
      {
        Console.WriteLine("\nOpps! the ISBN does not exist.\nTry again:");

      }
    }

  }


}
