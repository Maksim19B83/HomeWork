// Задача 23. Напишите программу, которая на  вход принимает число N и выдает таблицу кубов чисуе от 1 до N.
string sqrInLine (double N)
{
    int count = 1;
    int sqr;
    string result = "";
    
    while (count <= N)
    {
     sqr = count*count*count;
     result = result +" "+ sqr.ToString();
     count ++;
    }
    return result;
}





