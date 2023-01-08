//  Задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  m = 3, n = 4.

//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-30, 50) / 10.0;  // вещ числа
        }
    }
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    
}


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

double[,] numbers = new double[rows, colums];
FillArray(numbers);
PrintArray(numbers);

