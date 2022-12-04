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



/* Console.WriteLine("Введите трех-значное целое число");
int number = Convert.ToInt32(Console.ReadLine());
int k = 0, d = 0;
if (number > 99)
{
    k = number;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
Console.WriteLine($"The third number from the left is {d}");
}
else
{
   Console.WriteLine($"The number has fewer than 3 digits, sorry."); 
} */