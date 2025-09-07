


bool reached_five = false;
for (int i = 0; i < 10; ++i)
{
  if (i % 2 == 0)
  {
    Console.WriteLine("for loop " + i);

  }
  if (false)
  {
    Console.WriteLine("This should never appear");
  }


  if (i == 5)
  {
    reached_five = true;
  }

  if (reached_five)
  {
    Console.WriteLine("i is greter than 5");
  }
  else
  {
    Console.WriteLine("i is less than 5");
  }
}

Console.WriteLine("done with the loop");


