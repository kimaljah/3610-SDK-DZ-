// Задача 29
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

Console.Write("Введите длинну массива : ");
int Array = int.Parse(Console.ReadLine());

int[] randomArray = new int[Array];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(-10,20);
    Console.Write($" {randomArray[i]} "+" ");
}
