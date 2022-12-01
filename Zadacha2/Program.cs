// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите 1-е число : ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число : ");
int b = int.Parse(Console.ReadLine()!);
int max = a;
int min = b;

if  (a > b)
{
    max = a; min = b;
    }

if (a < b)
{
    max = b; min = a;
    } 

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);