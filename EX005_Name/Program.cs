Console.Write("введите имя ползователя:");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Ура, Маша пришла");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);   
}
