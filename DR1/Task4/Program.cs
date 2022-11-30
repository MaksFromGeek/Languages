Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2 && num1>num3)
{
    Console.WriteLine("max число равно "+num1);
}
else if (num2>num1 && num2>num3)
{
    Console.WriteLine("max число равно "+num2);
}
else
{
    Console.WriteLine("max число равно "+num3); 
}
