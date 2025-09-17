using uBiblioteksystem;
Library myLibrary = new();

Book myBook = new Book("Sagan om ringen", "tyson", "Fantasy", "123456789");
Book myBook2 = new Book("darkmatter", "amir", "science", "123456789");
Book myBook3 = new Book("cooking is life", "sabo", "cooking", "123456789");
Book myBook4 = new Book("space", "Tolkien", "amir", "science");
Book myBook5 = new Book("food is food", "sabo", "cooking", "123456789");

bool isRunning = true;
while (isRunning)
{

  Utilities.Colorize(ConsoleColor.DarkYellow, "\nWelcome to your library!\n[1] Add books\n[2] Show books\n[3] Remove books\n", "WriteLine");
  Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");

  string input = Console.ReadLine()?.Trim() ?? "";
  switch (input)
  {
    case "1":
      Console.Clear();
      myLibrary.addBook();

      break;

    case "2":

      Console.Clear();
      bool subisrunning = true;
      while (subisrunning)
      {
        Utilities.Colorize(ConsoleColor.DarkYellow, "\nPlease select an option!\n[1] Show all books\n[2] Filter books by Author\n[3] Filter books by Genre\n", "WriteLine");
        Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");

        string subInput = Console.ReadLine()?.Trim() ?? "";
        switch (subInput)
        {
          case "1":
            Console.Clear();
            myLibrary.showAllBooks();
            subisrunning = false;

            break;
          case "2":
            Console.Clear();
            Utilities.Colorize(ConsoleColor.DarkYellow, "\nPlease write the name of an author!\n", "WriteLine");
            Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
            string author = Console.ReadLine() ?? "";
            myLibrary.showBookAuthor(author);
            subisrunning = false;

            break;

          case "3":
            Console.Clear();
            Utilities.Colorize(ConsoleColor.DarkYellow, "\nPlease write the name of a genre!\n", "WriteLine");
            Utilities.Colorize(ConsoleColor.DarkYellow, "► ", "Write");
            string genre = Console.ReadLine() ?? "";
            myLibrary.showBooksGenre(genre);
            subisrunning = false;

            break;

          default:
            Console.WriteLine("Please enter a valid option..");
            break;

        }
      }
      break;

    case "3":
      Console.Clear();
      myLibrary.removeBook();

      break;

    default:
      Console.WriteLine("Please enter a valid option..");
      break;


  }

}
