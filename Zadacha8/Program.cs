// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.WriteLine("Введите число от 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до N: ");
int b = int.Parse(Console.ReadLine());



for (int diapazon = a; diapazon <= b; diapazon++)
 {
        if (diapazon % 2 == 0) 
 {
        Console.Write(diapazon + " ");
 }
 }
    