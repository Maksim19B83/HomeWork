// Задача 17. 
Console.clear();
System.Console.WriteLine("Введите координату х:");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0)
   System.Console.WriteLine("Это четверть № 1");
else if (x>0 && y<0)
   System.Console.WriteLine("Это четверть № 4");
else if (x<0 && y>0)
   System.Console.WriteLine("Это четверть № 2");
else if (x<0 && y<0)
   System.Console.WriteLine("Это четверть № 3");
else
   System.Console.WriteLine("Точка находится на координатной оси");




