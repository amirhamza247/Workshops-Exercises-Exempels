using MyApp;

User user1 = new User();

user1.Name = "Amir";
user1.Age = 24;

user1.WriteOutInfo();

string user1Info = user1.Info();

Console.WriteLine(user1Info);
Console.WriteLine(user1.Info());

user1.Greet("Pierino");