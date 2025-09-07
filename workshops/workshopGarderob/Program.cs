
using System.ComponentModel;

int maxSpace = 4;
int antalKläder = 0;

string[] closet = new string[maxSpace];




bool isRunning = true;
while (isRunning)
{
  Console.WriteLine("\nPress the option you want to select:\n 1 add new stuff to your closet.\n 2 view closet.\n 3 remove stuff from your closet.");
  string inputOption = Console.ReadLine()!;
  inputOption = inputOption.ToLower().Trim();

  if (inputOption == "done")
  {
    Console.WriteLine("program end");
    isRunning = false;
  }


  else
  {

    int.TryParse(inputOption, out int givenInput);

    if (givenInput == 1)
    {
      for (int i = 0; i < maxSpace; i++)
      {
        Console.WriteLine("antalkläder: " + antalKläder);
        if (antalKläder != maxSpace)
        {
          Console.WriteLine("\nPlease write what you want to add to your closet: Write 'done' when you are finish.\n");
          String? inputClothes = Console.ReadLine();
          inputClothes = inputClothes.ToLower().Trim();

          if (inputClothes == "done")
          {
            break;
          }
          else
          {
            closet[i] = inputClothes;
            antalKläder++;
          }


          if (antalKläder == maxSpace)
          {
            Console.WriteLine("\nCloset is full. Please remove some items...");
            break;
          }


        }
        else
        {
          Console.WriteLine("\nCloset is full. Please remove some items...");
          break;
        }


      }
    }





    else if (givenInput == 2)
    {

      for (int j = 0; j < maxSpace; j++)
      {
        if (closet[j] == null)
        {
          Console.WriteLine("\nCloset empty! Please add an item to your closet by selecting 1");
          break;
        }
        else
        {
          break;
        }
      }



      Console.WriteLine("\n\nStuff in your closet:");

      for (int i = 0; i < maxSpace; i++)
      {
        if (closet[i] != null)
        {
          Console.WriteLine((i + 1) + " - " + closet[i]);
        }

      }





    }





    else if (givenInput == 3)
    {
      for (int l = 0; l < maxSpace; l++)
      {
        if (closet[l] == null)
        {
          Console.WriteLine("\nCloset empty! Please add an item to your closet by selecting 1");
          break;
        }

        else
        {
          Console.WriteLine("\nPlease write what you want to remove. Write 'done' when you are finished.\n");

          string givenInputRemove = Console.ReadLine()!;
          givenInputRemove = givenInputRemove.ToLower().Trim();

          if (givenInputRemove == "done")
          {
            break;
          }

          for (int k = 0; k < maxSpace; k++)
          {


            if (closet[k] == givenInputRemove)
            {
              closet[k] = null;

            }

          }





        }
      }

    }

  }
}


