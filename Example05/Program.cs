Console.Write("Введите имя пользователя: ");
string usrename = Console.ReadLine();

if (usrename.ToLower() == "даша")
{
    Console.WriteLine("Не пиши мне!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(usrename);
}