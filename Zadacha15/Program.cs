// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7:  ");
int a = int.Parse(Console.ReadLine()!);

if (a > 0 && a < 8)
    {
     if (a == 7 || a == 6)
     {
       Console.Write("День номер " + a + " - Выходной");
    }
     else
     {
      Console.Write("День номер " + a + " - Рабочий");
     }
    }
 else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7 ");
    }
