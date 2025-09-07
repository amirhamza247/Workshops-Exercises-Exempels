


Console.Write("Skriv antal riskorn: "); //Skriver detta på terminalen.
ulong antalKorn = ulong.Parse(Console.ReadLine()!);  //Läser in vad användaren skriver.



int ruta = 0;

ulong risKorn = 0;



for (int i = 1; i <= 64; i++) // En for loop för att gå genom ruta 1 till ruta 64 på brädet.
{
  if (i == 1) //  Denna if satsen är för att hantera uppgiften när det är 1 riskorn. 
  {
    risKorn = 1;
    if (antalKorn == 1)
    {
      Console.WriteLine(antalKorn + " riskorn hittar du i ruta nr: " + i);
      break;
    }
    else if (antalKorn == 0)
    {
      Console.WriteLine("Var vänlig och ange giltig antal riskorn!");
      break;
    }

  }

  else // Här för dubblas alla riskorn för varje ruta. 
  {
    risKorn += risKorn;
    if (risKorn >= antalKorn)
    {
      ruta = i;

      Console.WriteLine(antalKorn + " riskorn hittar du i ruta nr: " + ruta);
      Console.WriteLine("ruta_" + i + ": " + risKorn + "st");

      break;

    }


  }


}





/* int user_input = 250;


int result = 1;

for (int i = 1; user_input > 0; i *= 20)
{
  user_input -= i;
  result += 1;
}

Console.WriteLine("svar hittar du på nr: " + result); */