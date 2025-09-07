

using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;




int maxSpace = 9;
string[] clothes = new string[maxSpace];
int amountOfClothes = 0;


int maxSpaceDrawer = 3;
string[] drawer = new string[maxSpaceDrawer];
int drawerClothesAmount = 0;

int maxSpaceShelve = 3;
string[] shelve = new string[maxSpaceShelve];
int shelveClothesAmount = 0;

int maxSpaceHanger = 3;
string[] hanger = new string[maxSpaceHanger];
int hangerClothesAmount = 0;



bool isRunning = true;

while (isRunning)
{
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("\n__________________________________");
  Console.WriteLine("Welcome! to your wardrobe menu");
  if (amountOfClothes == 1)
  {
    Console.WriteLine($"You have [{amountOfClothes}] cloth in total.\n");
  }
  else
  {
    Console.WriteLine($"You have [{amountOfClothes}] clothes in total.\n");
  }
  Console.ResetColor();

  Console.WriteLine("write [1] to add item.");
  Console.WriteLine("write [2] to view your wardrobe.");
  Console.WriteLine("write [3] to remove item.");
  Console.WriteLine("write 'exit' if you wish to exit.");
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("__________________________________\n");
  Console.ResetColor();

  Console.Write("►");
  string? input = Console.ReadLine()?.ToLower().Trim();




  switch (input)
  {
    case "exit":
      Console.Clear();
      Console.WriteLine("Program has ended, bye!");
      isRunning = false;

      break;


    case "1":
      Console.Clear();
      if (amountOfClothes == maxSpace)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo more space left in wardrobe. Please remove old items to add new ones. \n");
        Console.ResetColor();
        break;
      }



      bool subIsRunning = true;
      while (subIsRunning)
      {
        // Inner switch for submenu.
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nPlease select a compartment:\nWrite 'done' to go to main menu.\n");
        Console.ResetColor();
        Console.WriteLine("Write [1] for Drawer\n"
        + "Write [2] for Shelve\n"
        + "Write [3] for Hanger");


        Console.Write("\n►");
        input = Console.ReadLine()?.ToLower().Trim();

        switch (input)
        {

          case "done":
            Console.Clear();
            subIsRunning = false;
            break;

          case "1":
            Console.Clear();
            if (drawerClothesAmount == maxSpaceDrawer)
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Sorry your Drawer is full..");
              Console.ResetColor();
              break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWrite 'done' to go to previous menu.\nWrite 'main' to go to main menu.");
            Console.ResetColor();
            Console.WriteLine("Please write what you want to add to your drawer:\n");


            while (drawerClothesAmount != maxSpaceDrawer || input != "done")
            {
              if (drawerClothesAmount == maxSpaceDrawer)
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry your Drawer is full..");
                Console.ResetColor();
                break;
              }

              Console.Write("►");
              input = Console.ReadLine()?.ToLower().Trim();

              if (input == "main")
              {
                Console.Clear();
                subIsRunning = false;
                break;

              }
              else if (input == "done")
              {
                break;
              }
              else if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input))
              {
                Console.WriteLine("Please write a vlid peice of cloth...");
              }
              else
              {
                Console.Write($"\nYou added ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(input);
                Console.ResetColor();
                Console.Write(" to you drawer.\n\n");

                for (int i = 0; i < maxSpaceDrawer; i++)
                {
                  if (string.IsNullOrEmpty(drawer[i]))
                  {
                    drawer[i] = input;
                    drawerClothesAmount++;
                    amountOfClothes++;
                    break;
                  }
                }
              }
            }
            break;

          default:
            Console.Clear();
            Console.WriteLine("Please enter a valid option..");
            if (input == "done")
            {
              subIsRunning = false;
            }

            break;

        }
        // End of inner switch for submenu.

      }




      // Console.WriteLine("\nPlease write what you want to add:\nWrite 'done' to go to main menu.\n");


      break;

    case "2":
      Console.Clear();
      Console.WriteLine("\nThis is what you have in your wardrobe:\n");
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("_____________");
      Console.WriteLine("Drawer");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceDrawer; i++)
      {
        if (!string.IsNullOrEmpty(drawer[i]))
        {
          Console.WriteLine($"# - {drawer[i]}");

        }


      }
      if (drawerClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("\n_____________");
      Console.WriteLine("Shelv");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceShelve; i++)
      {
        if (!string.IsNullOrEmpty(shelve[i]))
        {
          Console.WriteLine($"# - {shelve[i]}");

        }

      }
      if (shelveClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("\n_____________");
      Console.WriteLine("Hanger");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceHanger; i++)
      {
        if (!string.IsNullOrEmpty(hanger[i]))
        {
          Console.WriteLine($"# - {hanger[i]}");

        }

      }
      if (hangerClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }

      break;


    case "3":
      Console.Clear();
      Console.WriteLine("\nPlease write what you want to remove:\nWrite 'done' to go to main menu.\n");
      Console.WriteLine("\nThis is what you have in your wardrobe:\n");
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("_____________");
      Console.WriteLine("Drawer");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceDrawer; i++)
      {
        if (!string.IsNullOrEmpty(drawer[i]))
        {
          Console.WriteLine($"# - {drawer[i]}");

        }


      }
      if (drawerClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("\n_____________");
      Console.WriteLine("Shelv");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceShelve; i++)
      {
        if (!string.IsNullOrEmpty(shelve[i]))
        {
          Console.WriteLine($"# - {shelve[i]}");

        }

      }
      if (shelveClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("\n_____________");
      Console.WriteLine("Hanger");
      Console.ResetColor();
      for (int i = 0; i < maxSpaceHanger; i++)
      {
        if (!string.IsNullOrEmpty(hanger[i]))
        {
          Console.WriteLine($"# - {hanger[i]}");

        }

      }
      if (hangerClothesAmount == 0)
      {

        Console.WriteLine("Empty");
      }



      while (input != "done")
      {


        Console.Write("\n►");

        input = Console.ReadLine()?.ToLower().Trim();



        if (input == "done")
        {
          break;
        }


        bool itemFound = false;
        for (int i = 0; i < maxSpace; i++)
        {
          if (input == clothes[i])
          {
            itemFound = true;
            break;
          }

        }

        if (!itemFound || input == "")
        {
          Console.WriteLine("Please Enter a valid item...");
        }
        else
        {
          Console.Write("You removed ");
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write(input);
          Console.ResetColor();
          Console.Write(" from your wardrobe.\n");
          for (int j = 0; j < maxSpace; j++)
          {

            if (input == clothes[j])
            {
              clothes[j] = "";
              amountOfClothes--;
              //break;
            }

          }
        }
      }

      break;



    default:
      Console.Clear();
      Console.WriteLine("\nPlease Enter a valid option...\n");

      break;



  }

}






























