﻿
Console.Write("введите имя пользователя : ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МААААШААА!");

}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}