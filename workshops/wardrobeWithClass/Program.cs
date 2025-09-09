using App;
Wardrobe wardrobe = new Wardrobe(20);



bool running = true;

while (running)
{
  Console.WriteLine("\nMain menu:\n");
  Console.WriteLine("[1] to show");
  Console.WriteLine("[2] to add");
  Console.WriteLine("[3] remove");
  Console.WriteLine("enter 'quit' to exit.\n");
  string input = Console.ReadLine();

  switch (input)
  {
    case "1":
      Console.Clear();
      wardrobe.Show();
      Console.WriteLine("\nPress Enter to continue\n");

      Console.ReadLine();
      break;

    case "2":
      Console.Clear();
      Console.WriteLine("label?");
      string label = Console.ReadLine();
      Console.WriteLine("color?");
      string color = Console.ReadLine();
      wardrobe.Add(label, color);
      break;

    case "3":
      Console.Clear();
      wardrobe.Remove();
      Console.WriteLine("\nPress Enter to continue\n");
      Console.ReadLine();
      break;


    case "quit":
      running = false;
      break;
  }
}