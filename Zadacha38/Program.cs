﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("Введите длинну массива : ");
int size = int.Parse(Console.ReadLine());;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 999);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
