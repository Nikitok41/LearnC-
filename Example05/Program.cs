Console.Write("Введите имя пользователя: ");
string userename = Console.ReadLine();

if (userename.ToLower() == "даша")
{
    Console.WriteLine("Не пиши мне!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(userename);
}