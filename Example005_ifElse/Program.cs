Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "вова")
{
    Console.WriteLine("Ура, это Вовочка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}