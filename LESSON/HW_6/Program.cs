﻿// зАДАЧА 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и тд.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6 ] -> [6 3 7 6]
// void Fillaray(int [] array)
// {
//      for (int i=0; i < array.Length; i++)
//      {
//         array [i] = new Random().Next(-9,10);
//      }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
// System.Console.WriteLine();
// }

// void ReversArray(int[] array)
// {
//     int temp=0;
//     for (int i=0; i < array.Length/2; i++)
//     {
//         // temp = array[array.Length-1-i];
//         // array[array.Length-1-i] = array[i];
//         // array[i] = temp; 
//         // (x,y)=(y,x);
//         (array[array.Length-1-i], array[i] ) = (array[i], array[array.Length-1-i]); // переводит последний элемент массива в первый и наоборот.
//     }

// }

// Console.Clear();
// System.Console.WriteLine("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// Fillaray(array);     // заполнили массив
// PrintArray(array);   // показали пользователю результат
// ReversArray(array);  // перевернули массив
// PrintArray(array);   // показали пользователю результат


// Задача 40. напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
System.Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите C: ");
int numC = Convert.ToInt32(Console.ReadLine());
if (numA < numB+numC || numB < numA+numC || numB < numA + numC)
    System.Console.WriteLine("Да");
else 
    System.Console.WriteLine("Нет");    