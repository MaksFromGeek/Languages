// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11; 82 -> 10; 9012 -> 12
System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int res = 0;
while (n>0)
{
    res = n%10;
    sum = sum + res;
    n/=10;
}
System.Console.WriteLine($"Сумма цифр = {sum}");


