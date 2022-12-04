Console.WriteLine ("Введите любое трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (num > 99)
{
    k = num;
    while (k >= 1000)
    {
        k/=10;
      //  d = k %10;
    }
    if (k >= 100 && k <= 999)
    {
        k/=10;
        d = k%10;
    }
    Console.WriteLine($"{d}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
