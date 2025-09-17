namespace uBiblioteksystem;


public class Utilities
{

  public static void Colorize(ConsoleColor color, string input, String line = "WriteLine")
  {
    Console.ForegroundColor = color;

    switch (line)
    {
      case "Write":
        Console.Write(input);
        break;
      case "WriteLine":
        Console.WriteLine(input);
        break;
    }
    ;
    Console.ResetColor();
  }


  public static string Capitalize(string input)
  {
    char firstLetter = char.ToUpper(input[0]);
    return input.Length > 1 ? firstLetter + input.Substring(1) : firstLetter.ToString();
  }


  public static bool EmptyCheck(string? input)
  {
    if (string.IsNullOrEmpty(input))
    {
      Console.WriteLine("Please write a valid text (not empty).");
      return false;
    }
    return true;
  }

  public static bool NumCheck(string? input)
  {
    if (int.TryParse(input, out _))
    {
      Console.WriteLine("Please write a valid number (not text).");
      return false;
    }
    return true;
  }




}




