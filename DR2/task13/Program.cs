Console.WriteLine("Введите любое целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0;
if (num > 99)
{
    while (num >= 1000)
    {
        num /= 10;
    }
    if (num >=100 && num <=999)
    {
        d = num % 10;
    }
Console.WriteLine($"Третья цифра заданного числа: {d}");
}
else
{
   Console.WriteLine($"Введенное число не является трехзначным"); 
}



/* Console.WriteLine ("Введите любое целое число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    for (int i = num; num >= 1000; i=i/10)
    {
        num /= 10;
    }
    if (num >= 100 && num <= 999)
    {
        num = num % 10;
    }
    Console.WriteLine($"{num}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
} */