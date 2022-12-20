﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write("Введите длинну массива : ");
int size = int.Parse(Console.ReadLine());;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

int sumNumbersEvenIndex = 0;

for (int i = 1; i < numbers.Length; i = i + 2)
{
    sumNumbersEvenIndex = sumNumbersEvenIndex + numbers[i];
}
Console.Write(sumNumbersEvenIndex);