// строка - это массив символов с типом char
//пробел это тоже символ

// string s = "Tantiana"; //все, что в кавычках = это строка
// Console.WriteLine(s[6]); // вывести символ с индексом 6 - это буква n

// s[6] = 'a'; //в строке мы не можем так изменить символ (это не изменяемый тип данных)
// Console.WriteLine(s[6]);

// string s = "Tantiana "; 
// string s1 = "Sergeevna "; 
// string s2 = "Smoljaninova "; 
// string s3 = s + s1 + " " + s2;
// string s4 = string.Concat(s, s1, s2); // второй вариант
// Console.WriteLine(s3);
// Console.WriteLine(s4);


// int[] nums = {1, 2, 3, 4, 5}; // есть массив, я хочу вывести его на экран
// string s5 = string.Join(" ", nums); //сепаратор символов - расставл символы между 
//                                    //значениями массива/
//                                   // в скобках показываем как мы объединяем
// Console.WriteLine(s5);


// string s7 = "1, 2, 3, 4, 5, 6, 7";
// foreach(var item in s7) // Var-неявный тип, кот/ означает, что сист сама определит тип данных
// {
//     Console.WriteLine(item);
// }

// //ПРИМЕР: получим массив данных из строки

// string s8 = "1, 2, 3, 4, 5, 6, 7.";
// string[] nums = s8.Split(new char[]{' ', ',', '.'}, System.StringSplitOptions.RemoveEmptyEntries);
//                              //System.StringSplitOptions.RemoveEmptyEntries удаляет пустые строки
//                             //убрали пробелы, запятые, точки. 
//                            //все, что м/ду пробелами, точками, запятыми,
//                           //записалось в отдельн ячейку
// int[] n = nums.Select (Int32.Parse).ToArray(); //создаем массив целых чисел
//                                                //берем массив и к кажд эл-ту применяем
//                                               // конвертацию то же, что Convert
// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }

// // второй способ
// string s9 = "10, 21, 35, 45, 57, 68, 79.";
// int[] = Array.ConvertAll(s9.Split() int.Parse);

//Split ищет символ, кот мы указываем и разбивает строку на коллекцию данных (на массив)

//Пример
string s10 = "fghhYbbhhYbbbY";
string[] nums = s10.Split(new char[]{'Y'}, System.StringSplitOptions.RemoveEmptyEntries);
//                  //System.StringSplitOptions.RemoveEmptyEntries удаляет Y
//                             //убрали Y. Все, что м/ду Y, записалось в отдельн ячейку

foreach (var item in nums)
{
     Console.WriteLine(item);
}