                                        //  ДОМАШНЯЯ РАБОТА  СЕМИНАР 4

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] resultArray = GetArray(8, 0, 100);
// Console.WriteLine($"Массив: [ {String.Join(";", resultArray)} ]");
// int[] GetArray (int size, int min, int max)

// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstV = 0 ;
// int sum = 0;
// if (number > 99 )
//    {
//      firstV = number / 10 ;
//      sum = (number / 100) + (firstV %10) + (number %10);
//    }
// Console.WriteLine($"Сумма числел {number} = {sum}");

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine ("ВВедите число А");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("ВВедите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int digt = A;
// int file = B;

// while(B>1)
// {
//     digt *= A;
//     B-- ;
// }
// Console.WriteLine($"Число {A} во {file} степени = {digt} ");