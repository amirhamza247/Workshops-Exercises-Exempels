using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace App;


public class Utilities
{
  //  public static Wardrobe autoWardrobe = new Wardrobe();
  public static void GenerateMenu(string tile = "Main menu", string end = "done", params string[] Choices)
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n__________________________________");
    Console.WriteLine(tile);

    for (int i = 0; i < Choices.Length; i++)
    {
      Console.WriteLine($"[{i + 1}] {Choices[i]}");
    }

    Console.WriteLine($"enter '{end}' to exit.");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("__________________________________\n");
    Console.ResetColor();
  }

  public static void Colorize(ConsoleColor color, string input, string line = "WriteLine")
  {

    Console.ForegroundColor = color;
    if (line == "Write" || line == "")
    {
      Console.Write(input);
    }
    if (line == "WriteLine")
    {
      Console.WriteLine(input);
    }

    Console.ResetColor();
  }

  /*     Wardrobe wardrobe = new Wardrobe();
    public static void autoGenerateClothes()
    {
      warderbe.drawer.Add("shirt", "black");
      Wardrobe.drawer.Add("jeans", "blue");
      Wardrobe.drawer.Add("pants", "yellow");

      Wardrobe.drawer.Add("hat", "red");  
      Wardrobe.drawer.Add("tie", "green");
      Wardrobe.drawer.Add("top", "cyan");

      Wardrobe.drawer.Add("skirt", "orange");
      Wardrobe.drawer.Add("jacket", "magenta");
      Wardrobe.drawer.Add("scarf", "brown");
    } */




}