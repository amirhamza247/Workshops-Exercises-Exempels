using System.Diagnostics.Contracts;
using System.Drawing;
namespace App;

public class Hanger
{
  public new Clothing[] Clothes;
  public int Capacity;
  public int AmountClothesHanger;


  public Hanger(int capacity)
  {
    Clothes = new Clothing[capacity];
    Capacity = capacity;
    AmountClothesHanger = 0;
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
        Console.Write(" to your Hanger.");
        break;
      }
    }
  }

  public void Show()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n______________");
    Console.WriteLine("Hanger:\n");
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
    //Console.WriteLine("__________________________________________\n");
    Console.ResetColor();
  }



}