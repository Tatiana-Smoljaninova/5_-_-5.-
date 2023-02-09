﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.  
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = new int[4];
int summ = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}

foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        summ = summ + array[i];
    }
}
Console.WriteLine($"Сумма равна {summ}");   