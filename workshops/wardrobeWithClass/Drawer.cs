using System.Diagnostics.Contracts;
using System.Globalization;
namespace App;

public class Drawer
{
  public Clothing[] Clothes;
  public int Capacity;
  public int DrawerClothesAmount;
  public int Index;

  public Drawer(int capacity)
  {
    Clothes = new Clothing[capacity];
    Capacity = capacity;
    DrawerClothesAmount = 0;
    Index = 0;
  }

  public void Add(string label, string color)
  {
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] == null || Clothes[i].Label == "")
      {
        Clothes[i] = new Clothing(label, color);
        Console.Write("You added ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Clothes[i].Color + ", " + Clothes[i].Label);
        Console.ResetColor();
        Console.Write(" to your Drawer.");
        DrawerClothesAmount++;

        break;
      }
    }
  }



  public void Show()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("______________");
    Console.WriteLine("[1] Drawer:\n");
    Console.ResetColor();
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine($"[{i + 1}] {Clothes[i].Color}, {Clothes[i].Label}");
        Console.WriteLine();
      }
    }
  }

  public void Remove()
  {
    // Utilities.Colorize(ConsoleColor.DarkYellow, "You are in your 'drawer' now:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("►");
    Console.ResetColor();
    string input = Console.ReadLine()?.ToLower().Trim() ?? "";
    int.TryParse(input, out int selectedIndex);

    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && selectedIndex == (i + 1))
      {
        Console.Write($"\nYou removed ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Clothes[i].Color + ", " + Clothes[i].Label);
        Console.ResetColor();
        Console.Write(" from you drawer.\n\n");
        Clothes[i].Label = "";
        Clothes[i].Color = "";
        for (int j = i; j < DrawerClothesAmount - 1; j++)
        {
          Clothes[j] = Clothes[j + 1];
        }
        Clothes[DrawerClothesAmount - 1] = null;
        DrawerClothesAmount--;

        break;
      }
    }
  }

}