using System.Data.SqlTypes;
using System.Reflection;
using App;
Wardrobe wardrobe = new Wardrobe();


bool running = true;

while (running)
{

  Utilities.GenerateMenu(end: "exit", Choices: new[] { "to show", "to add", "to remove" });

  Utilities.Colorize(ConsoleColor.Yellow, "►", "Write");
  string? input = Console.ReadLine();

  switch (input)
  {
    case "1": // Show
      Console.Clear();
      Utilities.Colorize(ConsoleColor.DarkYellow, "This is what you have in your wardrobe!");

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
        Utilities.GenerateMenu(Choices: new[] { "for drawer", "for shelf", "for hanger" });

        Utilities.Colorize(ConsoleColor.Yellow, "►", "Write");
        string? inputSub = Console.ReadLine();

        switch (inputSub)
        {
          case "1": // Drawer
            Console.Clear();
            Utilities.Colorize(ConsoleColor.DarkYellow, "\n______________________\nEnter 'done' to exit.\n\nPlease write what you\nwant to add to your Drawer:\n______________________\n");


            Console.WriteLine(":- label?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");
            string label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");

            string color = Console.ReadLine()?.ToLower().Trim() ?? "";
            wardrobe.drawer.Add(label, color);

            break;

          case "2": // Shelf
            Console.Clear();
            Utilities.Colorize(ConsoleColor.DarkYellow, "\n______________________\nEnter 'done' to exit.\nPlease write what you\nwant to add to your Drawer:\n______________________\n");

            Console.WriteLine(":- label?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");
            label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");
            color = Console.ReadLine()?.ToLower().Trim() ?? "";
            wardrobe.shelf.Add(label, color);

            break;

          case "3": // Hanger
            Console.Clear();
            Utilities.Colorize(ConsoleColor.DarkYellow, "\n______________________\nEnter 'done' to exit.\nPlease write what you\nwant to add to your Drawer:\n______________________\n");

            Console.WriteLine(":- label?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");

            label = Console.ReadLine()?.ToLower().Trim() ?? "";
            if (label == "exit" || label == "done")
            {
              Console.Clear();
              break;
            }
            Console.WriteLine("\n:- color?");
            Utilities.Colorize(ConsoleColor.Green, "►", "Write");

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

    case "3": // Remove
      Console.Clear();
      Utilities.Colorize(ConsoleColor.DarkYellow, "This is what you have in your wardrobe!");
      wardrobe.drawer.Show();
      wardrobe.shelf.Show();
      wardrobe.hanger.Show();

      Utilities.Colorize(ConsoleColor.DarkYellow, "\n______________________\nEnter 'done' to exit.\nPlease select a compartment to remvoe cloth from:\n");

      input = Console.ReadLine();

      bool removeSubMenu = true;
      while (removeSubMenu)
      {
        //Console.Clear();

        switch (input)
        {
          case "1":
            wardrobe.drawer.Remove();
            removeSubMenu = false;
            break;

          case "2":
            wardrobe.shelf.Remove();
            removeSubMenu = false;
            break;

          case "3":
            wardrobe.hanger.Remove();
            removeSubMenu = false;
            break;
          default:
            Console.WriteLine("Please select a valid option...");
            break;
        }
        break;


      }
      wardrobe.drawer.Remove();
      Console.WriteLine("\nPress Enter to continue\n");
      Console.Write("►");
      Console.ReadLine();
      Console.Clear();
      break;


    case "quit":
      running = false;
      break;


  }
}