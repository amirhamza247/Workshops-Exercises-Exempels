using App;
Wardrobe wardrobe = new Wardrobe();
/* Drawer drawer = new Drawer(5);
Shelf shelf = new Shelf(5);
Hanger hanger = new Hanger(5); */



bool running = true;

while (running)
{
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("\n__________________________________");
  Console.WriteLine("Welcome! to your wardrobe menu\n");
  Console.ResetColor();
  Console.WriteLine("[1] to show");
  Console.WriteLine("[2] to add");
  Console.WriteLine("[3] remove");
  Console.WriteLine("enter 'quit' to exit.");
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("__________________________________\n");
  Console.ResetColor();

  Console.Write("►");
  string? input = Console.ReadLine();

  switch (input)
  {
    case "1": // Show
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("This is what you have in your wardrobe!");
      Console.ResetColor();
      wardrobe.drawer.Show();
      wardrobe.shelf.Show();
      wardrobe.hanger.Show();
      Console.WriteLine("\nPress Enter to continue\n");
      Console.ReadLine();
      Console.Clear();
      break;


    case "2": // Add
      Console.Clear();
      bool subIsRunning = true;

      while (subIsRunning)
      {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n__________________________________");
        Console.WriteLine("Please select a compartment:\n");
        Console.ResetColor();
        Console.WriteLine("[1] for drawer");
        Console.WriteLine("[2] for shelf");
        Console.WriteLine("[3] for hanger");
        Console.WriteLine("enter 'done' to exit.");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("__________________________________\n");
        Console.ResetColor();

        Console.Write("►");
        string? inputSub = Console.ReadLine();

        switch (inputSub)
        {
          case "1": // Drawer
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n______________________");
            Console.WriteLine("Enter 'done' to exit.");
            Console.WriteLine("\nPlease write what you\nwant to add to your Drawer:");
            Console.WriteLine("______________________\n");
            Console.ResetColor();

            Console.WriteLine(":- label?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            string label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            string color = Console.ReadLine()?.ToLower().Trim() ?? "";
            wardrobe.drawer.Add(label, color);

            break;

          case "2": // Shelf
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n______________________");
            Console.WriteLine("Enter 'done' to exit.");
            Console.WriteLine("\nPlease write what you\nwant to add to your Drawer:");
            Console.WriteLine("______________________\n");
            Console.ResetColor();

            Console.WriteLine(":- label?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            color = Console.ReadLine()?.ToLower().Trim() ?? "";
            wardrobe.shelf.Add(label, color);

            break;

          case "3": // Hanger
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n______________________");
            Console.WriteLine("Enter 'done' to exit.");
            Console.WriteLine("\nPlease write what you\nwant to add to your Drawer:");
            Console.WriteLine("______________________\n");
            Console.ResetColor();

            Console.WriteLine(":- label?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("►");
            Console.ResetColor();
            color = Console.ReadLine()?.ToLower().Trim() ?? "";
            wardrobe.hanger.Add(label, color);

            break;

          case "done":
            Console.Clear();
            subIsRunning = false;
            break;
        }
      }

      break;

    /*     case "3": // Remove
          Console.Clear();
          wardrobe.Remove();
          Console.WriteLine("\nPress Enter to continue\n");
          Console.Write("►");
          Console.ReadLine();
          Console.Clear();
          break; */


    case "quit":
      running = false;
      break;
  }
}