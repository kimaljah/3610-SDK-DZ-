// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.Write("Введите индекс строки: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int colums = int.Parse(Console.ReadLine());
int[,] numbers = new int[5, 5];

FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))


    Console.WriteLine($"значение элемента в указанной позиции равно: ->  {numbers[rows, colums]}");


 else Console.WriteLine($"элемента в строке: -> {rows} и столбце -> {colums} не существует, так как он за пределами массива ");
         


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




