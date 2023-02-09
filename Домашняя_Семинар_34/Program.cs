// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[10];
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

foreach (int item in array)
{
    Console.Write($"{item} ");
    if (item % 2 == 0)
    {
        countEven = countEven + 1;
    }
}

Console.WriteLine($"Четных - {countEven}");