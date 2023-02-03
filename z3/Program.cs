// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int num;
Console.WriteLine("Введите число:");
num = int.Parse(Console.ReadLine()!);

if (num % 2 != 0)
{
   Console.WriteLine("Число  является НЕЧЁТНЫМ");
}
else
{
   Console.WriteLine("Число  является ЧЁТНЫМ");
}
