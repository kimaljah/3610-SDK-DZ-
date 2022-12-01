// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите 1-е число : ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число : ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число : ");
int c = int.Parse(Console.ReadLine()!);
int max;

 if (a >= b)
 {

    if (c >= a)
    {
       max = c;
    }
    else
    {
       max = a;
        }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
 }

Console.Write("max = ");
Console.WriteLine(max);