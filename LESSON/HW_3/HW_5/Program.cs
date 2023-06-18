// Задача 31:

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }
// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
// }
// void FindSume (int[] array)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (var item in array)
//         if (item>0)
//             sumP+=item;
//         else
//             sumN+=item;
//     System.Console.WriteLine($"Сумма отрицательных элементов массива равна {sumN}");   
//     System.Console.WriteLine($"Сумма положительных элементов массива равна {sumP}");        
// }
// int[] FindSume2 (int[] array)
// {
//     int sumP=0;
//     int sumN=0;
//     foreach (var item in array)
//         if (item>0)
//             sumP+=item;
//         else
//             sumN+=item;
//     int[] result = {sumN, sumP};   
//     return result;           
// }
// Console.Clear();
// System.Console.WriteLine("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [size];
// FillArray(array);
// PrintArray(array);
// FindSume(array);
// PrintArray(FindSume2(array));

// Задача 32. напишите программу замена элементов массива: положительные поменять на отрицательные и наоборот.

// void ChangeArray(int[] array)
// {
//     for(int i=0; i < array.Length; i++)
//     {
//         array[i]*=-1;
//     }
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     { 
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int [size];

// FillArray(Array);
// PrintArray(Array);
// ChangeArray(Array);
// PrintArray(Array);


// задача 33. задайте массив. напишите программу, которая определяет, присутствует ли заданное чисол в массиве.

// void FindNumberInArray(int[] array, int num)
// {
//     bool Find = false;
//     foreach (var item in array)
//     {
//         if (item == num)
//         {
//             System.Console.WriteLine("Да");
//             Find = true;
//             break;
//         }
//     }
//     if (Find == false) System.Console.WriteLine("Нет");
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     { 
//         System.Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.Write("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] Array = new int [size];

// FillArray(Array);
// PrintArray(Array);
// FindNumberInArray(Array, num);

