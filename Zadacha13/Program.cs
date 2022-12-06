// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int num = ReadInt("Введите число: ");
int num2 = num.ToString().Length;
Console.Write(MakeArray(num, num2));
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
if (b < 3)
{
     Console.Write("Третьей цифры нет и будет равно: ");
}
else
{
     int c = 1;
     for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}        