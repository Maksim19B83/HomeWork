// // Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// int num = new Random().Next(10,100);
// System.Console.WriteLine($"было сгенерировано случайное число {num}");
// int x1=num/10;
// int x2=num%10;
// if (x1>x2)
//    System.Console.WriteLine($"наибольшая цифра этого числа {x1}");
// else if (x1<x2)
//    System.Console.WriteLine($"наибольшая цифра этого числа {x2}");
// else
//    System.Console.WriteLine("обе цифры этого числа равны");   

// for (int i=1;i<10;i++)
//     System.Console.Write($" {i}");
 
// напишите программу, которая выводит случайное число и удаляет вторую цифру этого числа.
// int num = new Random().Next(100,1000);
// System.Console.WriteLine($"было сгенерировано случайное число {num}");
// int x1=num/100;
// int x3=num%10;
// System.Console.WriteLine($"{x1}{x3}");
// Напишите программу, корая принимает на вход целое число и удаляет вторую цифру слева на право этого числа

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным 
// первому. Если число 2 не кратно число 1, то вывести остаток от деления.
// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1%num2!=0)
//    System.Console.WriteLine($"Остаток от деления {num1%num2}");
// else 
//    System.Console.WriteLine($"Число {num2} кратно числу {num1}");   

// Напишите программу, которая на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23.
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num%7==0)&&(num%23==0))
//    System.Console.WriteLine($"{num} кратно 7 и 23");
// else
//    System.Console.WriteLine($"{num} не кратно 7 и 23");

// Напишите программу, котрая принимает на вход два числа и проверяет, яиляется ли одно число квадратом другого.
// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int doubleNum1 = num1*num1;
// int doubleNum2 = num2*num2;

// if (doubleNum1==num2 || doubleNum2==num1)
//    System.Console.WriteLine("Да");
// else
//    System.Console.WriteLine("Нет");   

// напишите программу, которая принимает от пользователя любое число любой разрядности и удаляет вторую цифру слева на право.
System.Console.WriteLine("Введите любое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int d = Math.Log(num1,10);

int x1=num/100;
int x3=num%10;
System.Console.WriteLine($"{x1}{x3}");