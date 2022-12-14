// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int count = CountNum(num);
int CountNum(int a)
{
    int index = 0;
    while ( a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}
Console.WriteLine($" В данном числе --> {count} <-- цифры ");


SumNumbers(num, count);
void SumNumbers(int b, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum = sum + (b % 10);
        b = b / 10;
    }
    Console.WriteLine($" Сумма этих цифр равна : {sum} ");
}
