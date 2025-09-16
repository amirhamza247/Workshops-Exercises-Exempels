namespace App;

public class Shelf
{
  public Clothing[] Clothes;
  public int Capacity;
  public int ShelfClothesAmount;


  public Shelf(int capacity)
  {
    Clothes = new Clothing[capacity];
    Capacity = capacity;
    ShelfClothesAmount = 0;
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
        Console.Write(" to your Shelf.");
        break;
      }
    }
  }

  public void Show()
  {
    // Utilities.Colorize(ConsoleColor.DarkYellow, "You are in your 'shlef' now:");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n______________");
    Console.WriteLine("[2] Shelf:\n");
    Console.ResetColor();
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine($"[{i + 1}] {Clothes[i].Color}, {Clothes[i].Label}");
        Console.WriteLine();
      }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    //Console.WriteLine("__________________________________________\n");
    Console.ResetColor();
  }


  public void Remove()
  {
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
        Console.Write(" from you shelf.\n\n");
        Clothes[i].Label = "";
        Clothes[i].Color = "";
        //DrawerClothesAmount--;
        break;
      }
    }

  }

}