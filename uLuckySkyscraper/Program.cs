
Console.Write("Tryck på en våning: ");
int knappTryck = int.Parse(Console.ReadLine()!);




int våning = 0;

while (1 == 1)
{

  våning++;


  if (våning == knappTryck)
  {

    if (knappTryck % 100 == 13 || knappTryck % 10 == 4)
    {
      Console.WriteLine("Du ska till våning: " + (våning + 1));

      break;
    }
    else if (knappTryck >= 4)
    {
      if (knappTryck % 100 == 12 || knappTryck % 10 == 3)
      {
        Console.WriteLine("Du ska till våning: " + (våning + 2));
        break;
      }
      Console.WriteLine("Du ska till våning: " + (våning + 1));


    }
    else
    {
      Console.WriteLine("Du ska till våning: " + (våning));
    }
    break;
  }

  // Console.WriteLine("Du ska till våning: " + (våning + 1));









}



