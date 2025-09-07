

using System.ComponentModel;
using System.Security.Cryptography;

Console.WriteLine("Hello, Switchers!");


string[] clothes = new string[64];

clothes[0] = "shirt";
clothes[1] = "pants";
clothes[2] = "tie";

bool isRunning = true;

while (isRunning)
{
  Console.WriteLine("show: display current content");
  Console.WriteLine("add: lets you add another piece of clothing");
  Console.WriteLine("remove: lets you remove a piece of clothing");
  Console.WriteLine("quit: exits the program");

  string? input = Console.ReadLine();


  switch (input)
  {
    case "add":
      Console.WriteLine("\nPlease enter what you would like to add\n");
      input = Console.ReadLine();
      for (int i = 0; i < 64; i++)
      {
        string current = clothes[i];

        if (current == "" || current == null)
        {
          clothes[i] = input;
          break;
        }

      }
      break;

    case "remove":
      Console.Clear();
      for (int i = 0; i < 64; i++)
      {
        string current = clothes[i];
        int fake_index = i + 1;

        if (current != "" && current != null)
        {
          Console.WriteLine(fake_index + ". " + current);
        }
        Console.WriteLine("Please enter the index of the item you wish to remove.");
        input = Console.ReadLine();

        if (int.TryParse(input, out int selected_index) && selected_index <= 64 && selected_index > 0)
        {

          clothes[selected_index - 1] = "";

        }
        else
        {
          Console.WriteLine("Invalid index selected, press Enter to continue...");
          Console.ReadLine();

        }
      }
      break;


    case "show":
      Console.Clear();
      for (int i = 0; i < 64; i++)
      {
        string current = clothes[i];

        if (current != "" && current != null)
        {
          Console.WriteLine(current);

        }
      }

      Console.WriteLine("Press Enter to continue");
      break;


    case "quit":
      isRunning = false;
      break;


    default:
      Console.WriteLine("\nPlease enter a valid command...\n");
      break;


  }











}




