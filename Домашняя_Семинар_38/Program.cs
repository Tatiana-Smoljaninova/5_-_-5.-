// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементом массива.
//[3 7 22 2 78] -> 76

int [] array = new int [4];
int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}

foreach (int item in array)
{
    Console.Write($"{item} ");
}
    
for (int i = 0; i < array.Length; i++)
{ 
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
       min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Минимальная сумма = {min}, максимальная сумма = {max}, разница {max-min}");
