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
        break;
      }
    }
  }


  public void Show()
  {
    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine("# - " + Clothes[i].Color + ", " + Clothes[i].Label);
        Console.WriteLine();


      }
    }
  }


  public void Remove()
  {

    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && Clothes[i].Label != "")
      {
        Console.WriteLine("# - " + Clothes[i].Label + ", " + Clothes[i].Color);
      }


    }
    Console.WriteLine("Please write what you want to remove.\n");
    string input = Console.ReadLine().ToLower().Trim();

    for (int i = 0; i < Capacity; i++)
    {
      if (Clothes[i] != null && input == Clothes[i].Label)
      {
        Clothes[i].Label = "";
        Clothes[i].Color = "";
        break;
      }


    }

  }
}