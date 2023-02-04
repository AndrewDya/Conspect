﻿//Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да; a = 2, b = 10 -> нет; a = 9, b = -3 -> да; a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x * x == y)
// {
// Console.Write("Первое число является квадратом второго");
// }
// else
// {
// Console.Write("Первое число НЕ является квадратом второго");
// }

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7. a = 2 b = 10 -> max = 10. a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > y)
// {
// Console.Write($"Max: {x}");
// }
// else if (x < y)
// {
// Console.Write($"Max: {y}");
// }
// else if (x == y)
// {
// Console.Write("Числа равны");
// }

// Задача 3: Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда  5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
// Console.Write("Понедельник");
// }
// else if (number == 2)
// {
// Console.Write("Вторник");
// }
// else if (number == 3)
// {
// Console.Write("Среда");
// }
// else if (number == 4)
// {
// Console.Write("Четверг");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> .7; 44 5 78 -> 78; 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = 0; 
// if (a > b)
// {
// max = a;
// }
// else if (b > a)
// {
// max = b;
// }
// if (c > max)
// {
// max = c;
// }
// Console.Write($"{max}");

// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = N * (-1);
// Console.Write("[");
// while (i < N)
// {
//     Console.Write($"{i}, ");
//     i++;
// }
// Console.Write($"{N}]");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да  -3 -> нет  7 -> нет

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// a = a % 2;
// if (a == 0)
// {
//     Console.Write("Число чётное");
// }
// else
// {
// Console.Write("Число нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4   8 -> 2, 4, 6, 8

// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int b = 2;
// while (b <= N)
// {
//     Console.WriteLine($"{b}");
//     b = b + 2;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5;  782 -> 8; 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (N > 1000 || N < 100)
// {
//     Console.WriteLine("Число не трёхзначное");
// }
// else 
// {
//     a = N % 100; 
//     a = a / 10; 
//     Console.WriteLine($"Вторая цифра трёхзначного числа: {a}");
// }

// Задача 11: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8; 12-> 2; 85 -> 8

// int a = new Random().Next(10,100); 
// int b = 0; 
// int c = 0;
// b = a % 10; 
// c = a / 10; 
// Console.WriteLine($"{a}");
// if (b > c)
// {
// Console.WriteLine($"{b}");
// }
// else
// {
//     Console.WriteLine($"{c}");
// }

// Задача 12: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46; 782 -> 72; 918 -> 98

// Console.Write("Введите трёхзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 100 && N < 1000)
// {int a = 0;
// int b = 0; 
// int c = 0;
// a = N / 100; 
// b = N % 100; 
// b = b / 10; 
// c = N % 10; 
// Console.Write($"{a}");
// Console.Write($"{c}");
// }
// else 
// Console.Write("Число не трёхзначное");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (N < 100) 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if (N < 1000 && N > 100) 
// {
//     a = N % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 10000 && N > 1000) 
// {
//     a = N / 10;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 100000 && N > 10000) 
// {
//     a = N / 100;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 1000000 && N > 100000) 
// {
//     a = N / 1000;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }

// Задача 14: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 ; 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// c = b % a;
// if (b % a == 0)
// {
//     Console.Write("Кратно");
// }
// else
// {
//  Console.Write($"Не кратно, остаток {c}"); 
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет

// Console.Write("Введите номер дня недели, чтобы узнать можно ли сегодня в кино: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
// Console.Write("Нет");
// }
// else if (number == 2)
// {
// Console.Write("Нет");
// }
// else if (number == 3)
// {
// Console.Write("Нет");
// }
// else if (number == 4)
// {
// Console.Write("Нет");
// }
// else if (number == 5)
// {
// Console.Write("Нет");
// }
// else if (number == 6)
// {
// Console.Write("Да");
// }
// else if (number == 7)
// {
// Console.Write("Да");
// }

// Задача 16: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет; 46 -> нет; 161 -> да

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 161 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0) 
// {
//     Console.WriteLine("Вы в четверти 1");
// }
// else if (x > 0 && y < 0) 
// {
//     Console.WriteLine("Вы в четверти 2");
// }
// else if (x < 0 && y < 0) 
// {
//     Console.WriteLine("Вы в четверти 3");
// }
// else if (x < 0 && y > 0) 
// {
//     Console.WriteLine("Вы в четверти 4");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

// Console.Write("Введите номер четверти: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1)
// {
//  Console.WriteLine("В диапазоне x > 0; y > 0");
// }
// else if (a == 2)
// {
//  Console.WriteLine("В диапазоне x > 0; y < 0");
// }
// else if (a == 3)
// {
//  Console.WriteLine("В диапазоне x < 0; y > 0");
// }
// else if (a == 4)
// {
//  Console.WriteLine("В диапазоне x < 0; y > 0");
// }
// else if (a < 1 || a > 4);
// {
//     Console.WriteLine("За пределами номера четверти");
// }

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int a1 = 0;
// int b = 0;
// int b1 = 0;
// a = N / 10000;
// a1 = N % 10;
// b = (N / 1000) % 10;
// b1 = (N / 10) % 10;
// if (N > 9999 && N < 100000 && a == a1 && b == b1) 
// {
//     Console.WriteLine("Палиндром");
// }
// else if (N < 10000 || N > 100000)
// {
//     Console.WriteLine("Прочтите условие внимательнее");
// }
// if (a != a1 || b != b1) 
// {
//     Console.WriteLine("Не палиндром");
// }

// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите x первой координаты: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y первой координаты: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x второй координаты: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y второй координаты: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// double c = Math.Sqrt((Math.Pow((a1-b1),2)) + Math.Pow((a2-b2),2));
// c = Math.Round(c,3);
// Console.WriteLine(c);

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите x первой координаты: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y первой координаты: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z первой координаты: ");
// int a3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x второй координаты: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y второй координаты: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z второй координаты: ");
// int b3 = Convert.ToInt32(Console.ReadLine());
// double c = Math.Pow((a1-b1),2) + Math.Pow((a2-b2),2) + Math.Pow((a3-b3),2);
// double d = Math.Sqrt(c);
// d = Math.Round(d,2);
// Console.WriteLine($"Расстояние между отрезками: {d}");

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28;  4 -> 10 8 -> 36

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// int i = 0;
// while (i <= a)
// {
//     sum = sum + i;
//     i++;
// }
// Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine()); 
// int deg = 1;
// int i = 0;
// while (i < b)
// {
//     deg = deg * a;
//     i++;
// }
// Console.WriteLine($"{a} в степени {b} = {deg}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// while (a > 0)
// {
//     a = a / 10;
//     sum = sum + 1;
// }
// Console.WriteLine($"Количество цифр в числе {sum}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// int b = 0;
// while (a > 0)
// {
//     b = a % 10;
//     sum = sum + b;
//     a = a / 10;
// }
// Console.WriteLine($"Сумма цифр в числе {sum}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int num = 1;
// int i = 1;
// while (i <= a)
// {
//     num = num * i;
//     i++;
// }
// Console.WriteLine($"Произведение чисел от 1 до {a} = {num}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

// int [] numbers = new int[8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 30);
//     Console.Write($"{numbers [i]}, ");
//  }
// Console.Write("]");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] numbers = new int[8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 2);
//     Console.Write($"{numbers [i]}, ");
//  }
// Console.Write("]");

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] nums = new int[12];
// void array(int[] nums)
// {
//     Console.Write("[");
//     for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(-9, 9);
//     Console.Write($"{nums [i]}, ");
//  }
//     Console.Write("]");
// }
// array(nums);
// int sum1 = 0;
// int sum2 = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] < 0)
//     {
//         sum1 = sum1 + nums[i];
//     }
//     else 
//     {
//         sum2 = sum2 + nums[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных {sum1}");
// Console.WriteLine($"Сумма положительных {sum2}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int [] nums = new int[4];
// void array1(int[] nums)
// {
//     Console.Write("[");
//     for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(-20, 20);
//     Console.Write($"{nums [i]}, ");
//  }
//     Console.Write("]");
// }
// array1(nums);
// void array2(int[] nums)
// {
//     Console.Write("[");
//     for (int i = 0; i < nums.Length; i++)
// {
//     nums[i] = nums[i] * (-1);
//     Console.Write($"{nums [i]}, ");
// }
//     Console.Write("]");
// }
// Console.WriteLine();
// array2(nums);

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

// int [] nums = new int[5];
// Console.Write("[");
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i] = new Random().Next(0, 20);
//     Console.Write($"{nums[i]}, ");
// }
// Console.Write("]");
// Console.WriteLine();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string b = "Нет такого значения в массиве";
// for (int j = 0; j < nums.Length; j++)
// {
//    if (nums[j] == a)
//    {
//       b = "Да, есть такое число в массиве";
//    }
// } 
// Console.Write(b);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] nums = new int[10];
// void array(int[] nums)
// {
// Console.Write("[");
// for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(100, 1000);
//     Console.Write($"{nums [i]}, ");
//  }
// Console.Write("]");
// }
// array(nums);
// int b = 0; 
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] % 2 == 0)
//     {
//         b = b + 1; 
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Число чётных цифр в массиве: {b}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// int [] nums = new int[10];
// void array(int[] nums)
// {
// Console.Write("[");
// for (int i = 0; i < nums.Length-1; i++)
//  {
//     nums [i] = new Random().Next(5, 20);
//     Console.Write($"{nums [i]}, ");
//  }
//     nums [nums.Length-1] = new Random().Next(5, 20);
//     Console.Write($"{nums [nums.Length-1]}]");
// }
// array(nums);
// int sum = 0; 
// for (int i = 0; i < nums.Length; i = i + 2)
// {
//  sum = nums [i] + sum;
// }
// Console.WriteLine();
// Console.Write($"Сумма элементов стоящих на нечётных позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int [] nums = new int[10];
// void array(int[] nums)
// {
// Console.Write("[");
// for (int i = 0; i < nums.Length; i++)
//  {
//     nums [i] = new Random().Next(0, 80);
//     Console.Write($"{nums [i]}, ");
//  }
// Console.Write("]");
// }
// array(nums);
// int min = nums [0];
// for (int i = 0; i < nums.Length; i++)
// { 
//    if (nums[i] < min)
//    { 
//       min = nums[i];
//    }
// }
// int max = nums [0];
// for (int i = 0; i < nums.Length; i++)
// { 
//    if (nums[i] > max)
//    { 
//       max = nums[i];
//    }
// }
// int dif = 0; 
// dif = max - min;
// Console.WriteLine();
// Console.Write($"Разница самого большого и самого маленького элементов массива: {dif}");

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]; [6 7 3 6] -> [6 3 7 6]

// int [] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// foreach (int aloy in nums)
// {
//     Console.Write($"{aloy} ");
// }
// int a = 0;
// int j = nums.Length;
// for (int i = 0; i < j - i; i++)
// {
//     a = nums[i];
//     nums[i] = nums[j - 1 - i];
//     nums[j - 1 - i] = a;
// }
// Console.WriteLine();
// foreach (int aloy in nums)
// {
//     Console.Write($"{aloy} ");
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// Console.Write("Введите число a, первая сторона треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число b, вторая сторона треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число c, третья сторона треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine()); 
// if (a + b <= c | b + c <= a | a + c <= b)
// {
//     Console.WriteLine("Треугольника с такими сторонами не существует");
// }
// else 
// {
//     Console.WriteLine("Треугольник с такими сторонами существует");
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество элементов массива, M: ");
// int M = Convert.ToInt32(Console.ReadLine()); 
// int [] nums = new int[M];
// for (int i = 0; i < nums.Length; i++)
//  {
//      Console.Write($"Введите элементы массива под индексом {i}: ");
//      nums[i] = Convert.ToInt32(Console.ReadLine()); 
//  }
// int sum = 0;
// for (int i = 0; i < nums.Length; i++)
// { 
//    if (nums[i] > 0)
//    { 
//       sum = sum + 1;
//    }
// }
// Console.WriteLine();
// Console.Write($"Чисел больше нуля ввёл пользователь: {sum}");

// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101; 3  -> 11; 2  -> 10

// Console.Write("Введите десятичное число a: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// string result = String.Empty;
// while (a > 0)
// {
//     result = a % 2 + result;
//     a = a / 2;
// }
// Console.WriteLine(result);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 1,5)

// //Нашли решение системы уранений и заменили х и y найденными параметрами
// Console.Write("Введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine()); 
// double x = 0;
// double y = 0;
// x = (b2 - b1) / (k1 - k2);
// y = (k1 * x) + b2;
// Console.Write($"Координаты пересечения прямых: ({x};{y})");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// // Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine()); 
// int Fib1 = 0;
// int Fib2 = 1;
// int Fib3 = 1;
// for (int i = 2; i <= N; i++)
// {
//      Fib1 = Fib2;
//      Fib2 = Fib3;
//      Fib3 = Fib1 + Fib2;
//      Console.WriteLine($"{Fib3}");
// }
//хз как решать

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     matrix [i,0] = new Random().Next(-50, 50);
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().Next(-50, 50);
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     matrix [i,0] = i;
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = i + j;
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] matrix = new double[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().Next(-10, 10);
//         matrix [i,j] = matrix [i,j] / new Random().Next(1, 10);
//         Console.Write($"{Math.Round(matrix[i, j], 2)} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//             matrix [i,j] =  matrix [i,j] * matrix [i,j];
//             }
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите строку m: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите столбец n: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
// {
//     Console.Write($"Под индексом ({m},{n}), находится элемент: {matrix[m, n]} ");
// }
// else
// {
//     Console.Write("Такого элемента нет в массиве");
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//             if (i == j)
//             {
//             sum = matrix [i,j] + sum;
//             Console.Write($"{matrix[i, j]} +");
//             }
//     }
// }
// Console.Write($" Cумма элементов главной диагонали {matrix[0,0]} + {matrix[1,1]} + {matrix[2,2]}: {sum}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {   
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix [i,j] = new Random().Next(0, 10);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// double sum1 = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {   
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         sum1 = sum1 + matrix[i, j];
//     }
//     double sum2 = sum1 / 3;
//     sum1 = 0;
// Console.WriteLine($" Среднее арифметическое {j} столбца = {Math.Round(sum2, 2)}");
// }

// Бонусная задача
// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа

// for (int i = 1; i < 25; i++)
//     {  
//         for (int j = 22; j < 50; j++)
//             {  
//                 for (int k = 1; k < 25; k++)
//                     {  
//                         for (int l = 1; l < 25; l++)
//                             {  
//                                 for (int m = 1; m < 25; m++)
//                                     {
//                                         if (Math.Pow(i, 5) == Math.Pow(j, 5) + Math.Pow(k, 5) + Math.Pow(l, 5) + Math.Pow(m, 5))
//                                         {
//                                         Console.WriteLine($"Очень сильно соответствуют x1 ={j}, x2 ={k}, x3 ={l}, x4 ={m}, x5 ={i}, Праздник");
//                                         break;
//                                         }
//                                         else if (Math.Pow(i, 5) != Math.Pow(j, 5) + Math.Pow(k, 5) + Math.Pow(l, 5) + Math.Pow(m, 5))
//                                         {
//                                         Console.WriteLine("-");
//                                         }
//                                     }
//                             }
//                     }

//             }
//         } 
// Console.Write($"Не нашли:(");
// хз как решать

// Теория 1 (Работа с Git)
// git remote add origin https://github.com/AndrewDya/Conspect.git - Команды для выгрузки на удалённый репозиторий с ПК
// git branch -M master
// git push -u origin master; git push origin <branch> - branch имя ветки которую надо отправить
// git clone https://github.com/AndrewDya/Conspect.git - склонировать внешний репозиторий на ПК
// git pull - скачать всё из удалённого репозитория и merge
// git init - инициализация локального репозитория
// git status - состояние git
// git add ... - добавить файлы к следующему коммиту
// git commit -m "message" - создание коммита
// git log - вывод на экран истории всех коммитов
// git log --graph - вывод на экран истории всех коммитов в виде графа
// git checkout ... - переход от одного коммита к другому, переключиться
// git checkout master - вернуться к ветке master и продолжить
// git diff - увидеть разницу между текущим и закомиченным файлом
// git branch - просмотр имеющихся веток
// git brach -d ... - удаление ветки
// git merge ... - объединение двух веток (слияние с основной)
// - Pull request (предложение изменения кода в чужом репозитории):
// - Делаем fork репозитория
// - Делаем clone СВОЕЙ версии репозитория
// - Создаём новую ветку и в неё вносим свои изменения
// - Фиксируем изменения (делаем коммиты)
// - Отправляем свою версию в свой GitHub
// - На сайте GitHub нажимаем кнопку Pull request
// dotnet new console - создать новый проект
// dotnet run - запустить проект
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// ctrl + c прекратить выполнение программы

// Теория 2 (Операции)
// || Условный оператор ИЛИ (хотя бы одно из условий должно выполняться); && Условный оператор И (оба условия должны выполняться); ! логическое отрицание
// & оператор И (Оператор & вычисляет оба операнда); | оператор ИЛИ (Оператор | вычисляет оба операнда)
// int a = new Random().Next(1,3); генерация случайного числа от 1 до 3
// for (int i = 0; i < 10; i++) - цикл с условием; где i++ инкримент эквивалентный i = i + 1
// Console.WtiteLine(Math.Abs(a)) модуль a
// Console.WtiteLine(Math.Round(a, 2)) округление a до 2 знаков после запятой
// Math.Sqrt(x); квадратный корень х
// Math.Pow(x, 3); возведение в х степень 3
// % отстаток от деления: Например 11 % 2 == 1

// Одномерные Массивы
// string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; - массив строк название weekDays с элементами {} без указания длины
// int[] array1 = new int[] { 1, 3, 5, 7, 9 }; - массив числовой название array1 с элементами {} без указания длины
// int[] array = new int[5] - оператор new создаёт одномерный массив и указывается тип (int) и число (5) элементов
// for (int i = 0; i < array.Length; i++) - цикл с перебором числа элементов
// Console.WriteLine(array.Length); - вывод длины массива array
// Console.WriteLine(weekDays[6]); - вывод шестого элемента массива weekDays
// Пример вывода элементов массива через цикл foreach (обрабатывает элементы в порядке возрастания индекса, начиная с индекса 0 и заканчивая индексом Length - 1:), 
// где i - может быть любым другим названием
// int[] array1 = new int[] { 1, 3, 5, 7, 9 };
// foreach (int i in array1)
// {Console.Write($"{i} ");}

// Оператор break завершает выполнение ближайшего оператора
// int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// foreach (int number in numbers)
// {
//     if (number == 3)
//     {break;}
//     Console.Write($"{number} ");
// }
// Console.WriteLine();
// Console.WriteLine("End of the example.");

// Двумерные Массивы
// string[,] table = new string[2,3] - [,] - двумерный массив типа string подназванием table 2 строки и 3 столбца
// table[1,2] = "слово";
// int[,] array2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// array2[2, 1] = 25; - присвоить значение 25 элементу массива array2 в строке 2 и столбце 1
// String.Empty - инициализация пустой строки
// Пример двумерного массива
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// Методы; функции
// метод (1) который ничего НЕ принимает, ничего НЕ возвращает
// void Method()
// {Console.WriteLine("Автор")} - {содержание метода}
// Method1() - вызов метода
// метод (2) который принимает, но НЕ возвращает
// метод (3) который ничего НЕ принимает, но возвращает
// метод (4) который принимает и возвращает

//Строки (из семинара)
// string s = "Hello World";
// string s1 = "Hello";
// string s2 = "World";
// int[] nums = {1, 2, 3, 4, 5};
// string s3 = s1 + " " + s2;
// string s4 = string.Concat(s1, s2);
// string s5 = string.Join(" ", nums);
// string s = "1, 2, 3, 4, 5, 6, 7";
// foreach (var item in s)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine(s5);
// string s = "1, 2, 3, 4, 5, 6, 7.";
// string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
// int[] n = nums.Select(Int32.Parse).ToArray();
// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }
// string s1 = "10 21 35 45 57 68 79";
// int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);
