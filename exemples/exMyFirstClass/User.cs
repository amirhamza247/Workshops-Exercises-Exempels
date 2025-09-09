namespace MyApp;

public class User
{
  public string? Name;
  public int Age;

  public void WriteOutInfo()
  {
    Console.WriteLine(Name + " " + Age);
  }


  // here we are making a method called info.
  public string Info()
  {
    string result = "";
    result = Name + " " + Age;
    return result;
  }

  public void Greet(string person)
  {
    Console.WriteLine("Hello, " + person + "! from " + Name + ".");

  }


}