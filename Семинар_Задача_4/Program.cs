// Задача 33. Задайте массив. Напишите прогр, кот определяет, присутствует ли 
//заданное число в массиве (создать массив случайных чисел)
//4; массив [6.7.19.345.3] - нет
//-3; массив [6.7.19.345.-3] - да

int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 30);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

//проверяем, присутствует ли число в массиве
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == N)
//     {
//     Console.Write("Такое число есть");
//     }
// }

// Console.Write("Такого числа нет");   
//string A = "Нет такого значения"; ИЛИ ТАК (ВАР 1)
bool flag = false;
foreach (int item in array)
{
    if (item == N)
    {
      //A = "Такое значение есть";  ИЛИ ТАК (ВАР 1)
      flag = true; // и далее ссылаться на true or folse
    }
}
Console.Write(A);
