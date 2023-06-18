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

// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100,101);
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

// int FindAndMemo(int[] array)
// {
//     int count = 0;
//     for(int i=0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//            count ++; 
//     }
//     return count;  
// }

// Console.Clear();

// int[] array = new int [123];

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(FindAndMemo(array));

// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// парой считаем первый и последний элемент, второй и предпоследний и тд. результат записать в новом массиве.

void FillArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = new Random().Next(-100, 101); 
    } 
} 
 
void PrintArray(int[] array) 
{ 
    foreach (var item in array) 
    { 
        System.Console.Write($"{item} "); 
    } 
    System.Console.WriteLine(); 
} 
 
void ProizArray (int[] array, int[] arrayProiz) 
{ 
    int size = array.Length/2; 
    for (int i = 0; i < size; i++) 
    { 
        arrayProiz[i] = array[i] * array[array.Length-1-i]; 
    } 
    if (size%2==1) 
        arrayProiz[arrayProiz.Length-1] = array[array.Length/2]; 
    System.Console.WriteLine(); 
} 
 
Console.Clear(); 
System.Console.Write("Введите диапазон массива: "); 
int size = Convert.ToInt32(System.Console.ReadLine()); 
 
int[] array = new int[size]; 
int[] arrayProiz = new int[size/2 + size%2]; 
 
FillArray(array); 
PrintArray(array); 
ProizArray(array, arrayProiz); 
PrintArray(arrayProiz);