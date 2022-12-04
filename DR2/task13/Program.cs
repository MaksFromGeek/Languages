Console.WriteLine ("Введите любое целое число:");
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
}

