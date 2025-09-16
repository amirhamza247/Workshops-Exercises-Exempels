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


}