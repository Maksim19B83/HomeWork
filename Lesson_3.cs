// Задача 23. Напишите программу, которая на  вход принимает число N и выдает таблицу кубов чисуе от 1 до N.
// string sqrInLine (double N)
// {
//     int count = 1;
//     int sqr;
//     string result = "";
    
//     while (count <= N)
//     {
//      sqr = count*count*count;
//      result = result +" "+ sqr.ToString();
//      count ++;
//     }
//     return result;
// }
// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число A ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B ");
int num2 = Convert.ToInt32(Console.ReadLine());
double pow = Math.Pow(num1,num2);
System.Console.WriteLine("Квадрат введенного числа равен "+pow);





