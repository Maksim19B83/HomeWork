/// Задача 17. 


// void CheckKord(int x, int y) //ф-я которая ничего не возвращает.
// {
//    if (x>0 && y>0)
//        System.Console.WriteLine("Это четверть № 1");
//    else if (x>0 && y<0)
//        System.Console.WriteLine("Это четверть № 4");
//    else if (x<0 && y>0)
//        System.Console.WriteLine("Это четверть № 2");
//    else if (x<0 && y<0)
//        System.Console.WriteLine("Это четверть № 3");
//    else
//        System.Console.WriteLine("Точка находится на координатной оси");
// }

// 

// задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек этой четверти (Х и У)

// void CheckQuarter(int num)
// {
//     switch(num)
//     {
//         case 1:
//         {
//             System.Console.WriteLine("x>0; У>0");
//             break;
//         }
//         case 2:
//         {
//             System.Console.WriteLine("x>0; У<0");
//             break;
//         }
//         case 3:
//         {
//             System.Console.WriteLine("x<0; У>0");
//             break;
//         }
//         case 4:
//         {
//             System.Console.WriteLine("x<0; У<0");
//             break;
//         }
//         default:
//         {
//             System.Console.WriteLine("Такой четверти нет");
//             break;
//         }
//     }
// }
// System.Console.WriteLine("Введите четверть: ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckQuarter(num);

// напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними 2D пространстве.
// double Length(double A1, double A2, double B1, double B2)
// {
//     double result = Math.Sqrt((B1-A1)*(B1-A1)+(B2-A2)*(B2-A2));
//     return result;
// }

// System.Console.WriteLine("Введите первую координату точки А: ");
// double A1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату точки А: ");
// double A2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите первую координату точки В: ");
// double B1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите вторую координату точки В: ");
// int B2 = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine($"расстояние между точками составит {Length(A1, A2, B1, B2)}");



// Задача 23. Напишите программу, которая на  вход принимает число N и выдает таблицу кубов чисел от 1 до N.
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


// Console.Clear();
// System.Console.WriteLine("Введите целое положительное число");
// double N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sqrInLine(N));
// int count = 1;
// int sqr;
// while (count <= N)
// {
//      sqr = count*count;
//      System.Console.Write(sqr+",");
//      count ++
// }

// Console.WriteLine("Введите целое число A ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число B ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// double pow = Math.Pow(num1,num2);
// System.Console.WriteLine("Квадрат введенного числа равен "+pow);

// if (num>0)
// {
//      System.Console.WriteLine("Вы ввели положительное число");
// }
// else if (num==0)
//      System.Console.WriteLine("Вы ввели ноль");
// else
//      System.Console.WriteLine("Вы ввели отрицательное число");

