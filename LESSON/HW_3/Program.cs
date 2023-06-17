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

void CheckQuarter(int num)
{
    switch(num)
    {
        case 1:
        {
            System.Console.WriteLine("x>0; У>0");
            break;
        }
        case 2:
        {
            System.Console.WriteLine("x>0; У<0");
            break;
        }
        case 3:
        {
            System.Console.WriteLine("x<0; У>0");
            break;
        }
        case 4:
        {
            System.Console.WriteLine("x<0; У<0");
            break;
        }
        default:
        {
            System.Console.WriteLine("Такой четверти нет");
            break;
        }
    }
}
System.Console.WriteLine("Введите четверть: ");
int num = Convert.ToInt32(Console.ReadLine());
CheckQuarter(num);