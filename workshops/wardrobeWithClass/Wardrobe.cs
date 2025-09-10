using System.Data;
using System.Diagnostics.Tracing;

namespace App;

public class Wardrobe
{
  public Clothing[] Clothes;
  public int Capacity;

  public Wardrobe(int capacity)
  {
    Clothes = new Clothing[capacity];
    Capacity = capacity;
  }


  public void Add(string label, string color)
  {
    for (int i = 0; i < Capacity; ++i)
    {
      if (Clothes[i] == null || Clothes[i].Label == "")
      {
        Clothes[i] = new Clothing(label, color);
        Console.Write($"\nYou added ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Clothes[i].Color + ", " + Clothes[i].Label);
        Console.ResetColor();
        Console.Write(" to you wardrobe.\n\n");
        break;
      }
    }
  }


  public void Show()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n__________________________________________"); Console.WriteLine("This is what you have in your wardrobe:\n");
    Console.ResetColor();
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine("# - " + Clothes[i].Color + ", " + Clothes[i].Label);
        Console.WriteLine();
      }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("__________________________________________\n");
    Console.ResetColor();
  }


  public void Remove()
  {

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n__________________________________________"); Console.WriteLine("This is what you have in your wardrobe:\n");
    Console.ResetColor();
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine("# - " + Clothes[i].Label + ", " + Clothes[i].Color);
      }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n__________________________________________");
    Console.ResetColor();


    Console.WriteLine("\nPlease write what you want to remove.\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("►");
    Console.ResetColor();
    string input = Console.ReadLine().ToLower().Trim();

    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && input == Clothes[i].Label)
      {
        Console.Write($"\nYou removed ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Clothes[i].Color + ", " + Clothes[i].Label);
        Console.ResetColor();
        Console.Write(" from you wardrobe.\n\n");
        Clothes[i].Label = "";
        Clothes[i].Color = "";
        break;
      }
      else if (input == "done")
      {
        break;
      }
    }


  }
}