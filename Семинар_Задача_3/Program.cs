// Задача 32. Напишите прогр замены эл-тов массива: положит эл-ты заменить на 
//соответствующие отрицательные и наоборот.
//[-4.-8.8.2] -> [4.8.-8.-2]

//создаем массив чисел
int[] array = new int [4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
//выводим массив на печать
foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
//преобразуем знаки чисел на обратные
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i] * -1} ");
}

