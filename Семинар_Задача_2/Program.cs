// Задача 31. Задайте массив из 12 эл-тов, заполненный случайными числами из промежутка
//[-9,9]. Найдите сумму отрицат  и положит эл-тои массива.
//Напр. в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положит чисел равна 29, 
//сумма отрицат чисел равна -20

// 1. формируем массив чисел
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}
//выводим массив на печать
foreach (int item in array)
{
     Console.Write($"{item} ");
}
Console.WriteLine();

//2. Ищем сумму цифр массива
int SummPlus = 0;
int SummMinus = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        SummPlus = SummPlus + array[i];
    }

    else
    {
        SummMinus = SummMinus + array[i];
    }
}

Console.Write($"Сумма положит. чисел равна {SummPlus}, сумма отрицательных чисел равна {SummMinus}");





