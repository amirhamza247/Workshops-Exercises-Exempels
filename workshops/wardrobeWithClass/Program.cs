using App;
Wardrobe wardrobe = new Wardrobe(20);



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
      wardrobe.Show();
      Console.WriteLine("\nPress Enter to continue\n");
      Console.ReadLine();
      Console.Clear();
      break;

    case "2": // Add
      Console.Clear();
      Console.WriteLine("label?");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("►");
      Console.ResetColor();
      string label = Console.ReadLine().ToLower().Trim();
      if (label == "exit" || label == "done")
      {
        Console.Clear();
        break;
      }
      Console.WriteLine("\ncolor?");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("►");
      Console.ResetColor();
      string color = Console.ReadLine().ToLower().Trim();
      wardrobe.Add(label, color);
      break;

    case "3": // Remove
      Console.Clear();
      wardrobe.Remove();
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