// зАДАЧА 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и тд.)
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
// System.Console.WriteLine("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите C: ");
// int numC = Convert.ToInt32(Console.ReadLine());
// if (numA < numB + numC && numB < numA + numC && numC < numA + numB)
//     System.Console.WriteLine("Да");
// else 
//     System.Console.WriteLine("Нет");  

// bool Res(double x, double y, double z)
// {
//     bool flag = false;
//     if (x < z + y && z < x + y && y < z + x)
//     {
//         flag = true;
//     }
//     return flag;
// }
// System.Console.WriteLine("Введите последовательно три числа: ");
// double x = Convert.ToDouble(Console.ReadLine());
// double y = Convert.ToDouble(Console.ReadLine());
// double z = Convert.ToDouble(Console.ReadLine());

// if (Res(x, y, z))
// {
//     System.Console.WriteLine("Построить можно");
// }
// else
//     System.Console.WriteLine("Нельзя");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10;

// string Res(int N)
// {
//     string res = "";
//     while (N > 0)
//     {
//         res = Convert.ToString(N % 2) + res;
//         N = N / 2;
//     }
//     return res;
// }
// System.Console.WriteLine("Введите двоичное число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Res(N));

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void FillArray(int[] arr)
// {
//     arr[0] = 0;
//     arr[1] = 1;
//     arr[2] = 1;
//     for (int i = 3; i < arr.Length; i++)
//     {
//         arr[i] = (arr[i-1])+(arr[i-2]);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество чисел Фибоначчи, которое хотите увидеть");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

// // void FillArray(int[] arr) НЕ ДОДЕЛАЛ!!!
// {
//      arr[0] = 0;
//      arr[1] = 1;
//      arr[2] = 1;
//      for (int i = 3; i < arr.Length; i++)
//      {
//          arr[i] = (arr[i-1])+(arr[i-2]);
//      }
// }

// void PrintArray(int[] array)
// {
//      foreach (var item in array)
//      {
//          Console.Write($"{item} ");
//      }
//      System.Console.WriteLine();
// }

// void NegativNumbers(int[] array)
// {
//      for (int i=0; i < array.Length/2; i++)
//      {
//      (array[array.Length-1-i], array[i] ) = (-array[i], -array[array.Length-1-i]);
//      }
// }

// System.Console.WriteLine("Введите количество чисел Фибоначчи, которое хотите увидеть");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);
// NegativNumbers(array);
// PrintArray(array);


void FillArray(int[] arr) 
{
      for (int i = 0; i < arr.Length; i++)
      {
          arr[i] = new Random().Next(-9,10);;
      }
}

void PrintArray(int[] array)
{
      foreach (var item in array)
      {
          Console.Write($"{item} ");
      }
      System.Console.WriteLine();
}

int PositivNumbers(int[] array) 
{
    int temp=0;
    foreach (var item in array)
        if (item>0)
            temp++;
        else
            temp=temp+0;
    int[] result = {temp};   
    return result;                
}
System.Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
PositivNumbers(array);
PrintArray(array);
